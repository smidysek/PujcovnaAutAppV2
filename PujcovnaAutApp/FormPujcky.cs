using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using PdfSharp.Pdf;
using PdfSharp.Drawing;
using System.Diagnostics;

namespace PujcovnaAutApp
{
    public partial class FormPujcky : Form
    {
        public FormPujcky()
        {
            InitializeComponent();
            txtVyhledat.TextChanged += FilterChanged;
            txtVyhledatAuto.TextChanged += FilterChanged;
            NacistPujcky();
        }

        private void NacistPujcky(string hledatZakaznik = "", string hledatAuto = "")
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();

                var query = @"
            SELECT Pujcky.ID, 
                   Zakaznici.Jmeno || ' ' || Zakaznici.Prijmeni AS Zakaznik, 
                   Auta.Znacka || ' ' || Auta.Model AS Auto, 
                   Pujcky.DatumOd, Pujcky.DatumDo
            FROM Pujcky
            JOIN Zakaznici ON Pujcky.ZakaznikID = Zakaznici.ID
            JOIN Auta ON Pujcky.AutoID = Auta.ID
            WHERE 1=1";

                if (!string.IsNullOrWhiteSpace(hledatZakaznik))
                {
                    query += " AND Zakaznici.Jmeno || ' ' || Zakaznici.Prijmeni LIKE @hledatZakaznik";
                }

                if (!string.IsNullOrWhiteSpace(hledatAuto))
                {
                    query += " AND Auta.Znacka || ' ' || Auta.Model LIKE @hledatAuto";
                }

                query += " ORDER BY Pujcky.DatumOd DESC;";

                var adapter = new SQLiteDataAdapter(query, conn);

                if (!string.IsNullOrWhiteSpace(hledatZakaznik))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@hledatZakaznik", $"%{hledatZakaznik}%");
                }

                if (!string.IsNullOrWhiteSpace(hledatAuto))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@hledatAuto", $"%{hledatAuto}%");
                }

                var dt = new DataTable();
                adapter.Fill(dt);
                dgvPujcky.DataSource = dt;
            }
        }

        private void ExportovatFakturu(int pujckaId)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();

                var cmd = new SQLiteCommand(@"
            SELECT 
                Pujcky.ID,
                Zakaznici.Jmeno || ' ' || Zakaznici.Prijmeni AS Zakaznik,
                Zakaznici.Email,
                Auta.Znacka || ' ' || Auta.Model || ' (' || Auta.SPZ || ')' AS Auto,
                Auta.CenaZaDen,
                DatumOd,
                DatumDo
            FROM Pujcky
            JOIN Zakaznici ON Pujcky.ZakaznikID = Zakaznici.ID
            JOIN Auta ON Pujcky.AutoID = Auta.ID
            WHERE Pujcky.ID = @id", conn);

                cmd.Parameters.AddWithValue("@id", pujckaId);

                using (var reader = cmd.ExecuteReader())
                {
                    if (!reader.Read())
                    {
                        MessageBox.Show("Nepodařilo se načíst údaje o půjčce.");
                        return;
                    }

                    // Získání dat
                    string zakaznik = reader.GetString(reader.GetOrdinal("Zakaznik"));
                    string email = reader["Email"]?.ToString();
                    string auto = reader.GetString(reader.GetOrdinal("Auto"));
                    decimal cenaZaDen = reader.GetDecimal(reader.GetOrdinal("CenaZaDen"));
                    DateTime datumOd = DateTime.Parse(reader["DatumOd"].ToString());
                    DateTime datumDo = DateTime.Parse(reader["DatumDo"].ToString());

                    int pocetDni = (int)(datumDo - datumOd).TotalDays + 1;
                    decimal celkovaCena = cenaZaDen * pocetDni;

                    // Vytvoř PDF
                    var doc = new PdfDocument();
                    doc.Info.Title = $"Faktura_{pujckaId}";
                    var page = doc.AddPage();
                    var gfx = XGraphics.FromPdfPage(page);
                    var font = new XFont("Montserrat", 12, XFontStyle.Regular);
                    var bold = new XFont("Montserrat", 12, XFontStyle.Bold);

                    int y = 40;
                    gfx.DrawString("FAKTURA ZA PŮJČENÍ VOZIDLA", new XFont("Montserrat", 16, XFontStyle.Bold), XBrushes.Black, new XRect(0, y, page.Width, 30), XStringFormats.TopCenter);
                    y += 50;

                    gfx.DrawString($"Číslo faktury: {pujckaId}", font, XBrushes.Black, 50, y); y += 25;
                    gfx.DrawString($"Zákazník: {zakaznik}", font, XBrushes.Black, 50, y); y += 25;
                    gfx.DrawString($"Email: {email}", font, XBrushes.Black, 50, y); y += 25;

                    gfx.DrawString($"Vozidlo: {auto}", font, XBrushes.Black, 50, y); y += 25;
                    gfx.DrawString($"Období: {datumOd:dd.MM.yyyy} – {datumDo:dd.MM.yyyy} ({pocetDni} dnů)", font, XBrushes.Black, 50, y); y += 25;
                    gfx.DrawString($"Cena za den: {cenaZaDen} Kč", font, XBrushes.Black, 50, y); y += 25;
                    gfx.DrawString($"Celková cena: {celkovaCena} Kč", bold, XBrushes.Black, 50, y); y += 25;

                    gfx.DrawString($"Datum vystavení: {DateTime.Now:dd.MM.yyyy}", font, XBrushes.Black, 50, y);

                    // Uložení
                    string vystupPath = $"Faktura_{pujckaId}_{zakaznik.Replace(" ", "_")}.pdf";
                    doc.Save(vystupPath);

                    MessageBox.Show($"Faktura byla uložena jako:\n{vystupPath}", "Export dokončen");

                    // Otevři soubor
                    Process.Start(new ProcessStartInfo
                    {
                        FileName = vystupPath,
                        UseShellExecute = true
                    });
                }
            }
        }


        private void btnObnovit_Click(object sender, EventArgs e)
        {
            txtVyhledat.Clear();
            txtVyhledatAuto.Clear();
            NacistPujcky();
        }

        private void btnVyhledat_Click(object sender, EventArgs e)
        {
            NacistPujcky(txtVyhledat.Text);
        }

        private void btnSmazat_Click(object sender, EventArgs e)
        {
            if (dgvPujcky.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vyberte půjčku k odstranění.");
                return;
            }

            int id = Convert.ToInt32(dgvPujcky.SelectedRows[0].Cells["ID"].Value);

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                var cmd = new SQLiteCommand("DELETE FROM Pujcky WHERE ID = @id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Půjčka smazána.");
            NacistPujcky();
        }

        private void FilterChanged(object sender, EventArgs e)
        {
            NacistPujcky(txtVyhledat.Text, txtVyhledatAuto.Text);
        }

        private void txtVyhledat_TextChanged(object sender, EventArgs e)
        {
            NacistPujcky(txtVyhledat.Text);
        }

        private void btnExportFaktura_Click(object sender, EventArgs e)
        {
            if (dgvPujcky.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vyberte půjčku pro export faktury.");
                return;
            }

            int pujckaId = Convert.ToInt32(dgvPujcky.SelectedRows[0].Cells["ID"].Value);
            ExportovatFakturu(pujckaId);
        }
    }
}
