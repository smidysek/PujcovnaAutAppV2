using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace PujcovnaAutApp
{
    public partial class FormNovaPujcka : Form
    {
        public FormNovaPujcka()
        {
            InitializeComponent();
            pictureBoxAuto.Image = Properties.Resources._default;
            NacistZakazniky();
            NacistAuta();
        }

        public class ComboBoxItem
        {
            public int Value { get; set; }
            public string Text { get; set; }
            public string ImagePath { get; set; }

            public ComboBoxItem(int value, string text, string imagePath = null)
            {
                Value = value;
                Text = text;
                ImagePath = imagePath;
            }

            public override string ToString() => Text;
        }


        private void NacistZakazniky()
        {
            cmbZakaznik.Items.Clear();
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                var cmd = new SQLiteCommand("SELECT ID, Jmeno || ' ' || Prijmeni FROM Zakaznici", conn);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cmbZakaznik.Items.Add(new ComboBoxItem(reader.GetInt32(0), reader.GetString(1)));
                }
            }
        }

        /*
        private void NacistAuta()
        {
            cmbAuto.Items.Clear();

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();

                var cmd = new SQLiteCommand(@"
            SELECT ID, Znacka || ' ' || Model || ' (' || SPZ || ')' AS AutoInfo 
            FROM Auta 
            WHERE ID NOT IN (
                SELECT AutoID FROM Pujcky
                WHERE NOT (
                    DatumDo < @od OR DatumOd > @do
                )
            )", conn);

                cmd.Parameters.AddWithValue("@od", dtpOd.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@do", dtpDo.Value.ToString("yyyy-MM-dd"));

                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cmbAuto.Items.Add(new ComboBoxItem(reader.GetInt32(0), reader.GetString(1)));
                }
            }
        }
        */

        private void NacistAuta()
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();

                var cmd = new SQLiteCommand(@"
            SELECT ID, Znacka || ' ' || Model || ' (' || SPZ || ')' AS AutoInfo, Obrazek
            FROM Auta 
            WHERE ID NOT IN (
                SELECT AutoID FROM Pujcky
                WHERE NOT (
                    DatumDo < @od OR DatumOd > @do
                )
            )", conn);

                cmd.Parameters.AddWithValue("@od", dtpOd.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@do", dtpDo.Value.ToString("yyyy-MM-dd"));

                var adapter = new SQLiteDataAdapter(cmd);
                var dt = new DataTable();
                adapter.Fill(dt);

                cmbAuto.DisplayMember = "AutoInfo";
                cmbAuto.ValueMember = "ID";
                cmbAuto.DataSource = dt;

                // Uložíme si DataTable do Tagu, abychom měli přístup k cestám obrázků
                cmbAuto.Tag = dt;
            }
        }

        private void AktualizujDostupnostAut(DateTime datumOd, DateTime datumDo)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();

                var cmd = new SQLiteCommand("SELECT ID FROM Auta", conn);
                var reader = cmd.ExecuteReader();

                List<int> vsechnaAuta = new List<int>();
                while (reader.Read())
                {
                    vsechnaAuta.Add(reader.GetInt32(0));
                }
                reader.Close();

                foreach (int autoId in vsechnaAuta)
                {
                    var checkCmd = new SQLiteCommand(@"
                        SELECT COUNT(*) FROM Pujcky
                        WHERE AutoID = @id
                        AND NOT (DatumDo < @od OR DatumOd > @do)
                    ", conn);

                    checkCmd.Parameters.AddWithValue("@id", autoId);
                    checkCmd.Parameters.AddWithValue("@od", datumOd.ToString("yyyy-MM-dd"));
                    checkCmd.Parameters.AddWithValue("@do", datumDo.ToString("yyyy-MM-dd"));

                    int kolize = Convert.ToInt32(checkCmd.ExecuteScalar());

                    var updateCmd = new SQLiteCommand("UPDATE Auta SET KDispozici = @dispo WHERE ID = @id", conn);
                    updateCmd.Parameters.AddWithValue("@id", autoId);
                    updateCmd.Parameters.AddWithValue("@dispo", kolize == 0 ? 1 : 0);
                    updateCmd.ExecuteNonQuery();
                }
            }
        }

        private void btnUlozit_Click(object sender, EventArgs e)
        {
            if (cmbZakaznik.SelectedItem == null || cmbAuto.SelectedItem == null)
            {
                MessageBox.Show("Vyberte zákazníka a auto.");
                return;
            }

            if (dtpOd.Value > dtpDo.Value)
            {
                MessageBox.Show("Datum 'Od' nesmí být později než datum 'Do'.");
                return;
            }

            // Získání ID zákazníka (ComboBoxItem)
            var zakaznikItem = cmbZakaznik.SelectedItem as FormNovaPujcka.ComboBoxItem;
            if (zakaznikItem == null)
            {
                MessageBox.Show("Nelze získat zákazníka.");
                return;
            }
            int zakaznikId = zakaznikItem.Value;

            // Získání ID auta z ValueMember (DataBound)
            int autoId = Convert.ToInt32(cmbAuto.SelectedValue);

            string datumOd = dtpOd.Value.ToString("yyyy-MM-dd");
            string datumDo = dtpDo.Value.ToString("yyyy-MM-dd");

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();

                // Kontrola, zda auto není půjčené v daném termínu
                var kontrola = new SQLiteCommand(@"
            SELECT COUNT(*) FROM Pujcky 
            WHERE AutoID = @autoId AND 
            NOT (DatumDo < @od OR DatumOd > @do);", conn);
                kontrola.Parameters.AddWithValue("@autoId", autoId);
                kontrola.Parameters.AddWithValue("@od", datumOd);
                kontrola.Parameters.AddWithValue("@do", datumDo);
                long kolize = (long)kontrola.ExecuteScalar();

                if (kolize > 0)
                {
                    MessageBox.Show("Auto je v tomto termínu již půjčeno.");
                    return;
                }

                // Vložení půjčky
                var cmd = new SQLiteCommand("INSERT INTO Pujcky (ZakaznikID, AutoID, DatumOd, DatumDo) VALUES (@zakId, @autoId, @od, @do)", conn);
                cmd.Parameters.AddWithValue("@zakId", zakaznikId);
                cmd.Parameters.AddWithValue("@autoId", autoId);
                cmd.Parameters.AddWithValue("@od", datumOd);
                cmd.Parameters.AddWithValue("@do", datumDo);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Půjčka uložena.");

            // Aktualizuj dostupnost a seznam aut
            AktualizujDostupnostAut(dtpOd.Value, dtpDo.Value);
            NacistAuta();

            DialogResult = DialogResult.OK;
            Close();
        }


        private void btnZrusit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dtpOd_ValueChanged(object sender, EventArgs e)
        {
            if (dtpOd.Value <= dtpDo.Value)
            {
                AktualizujDostupnostAut(dtpOd.Value, dtpDo.Value);
                NacistAuta();
            }
        }

        private void dtpDo_ValueChanged(object sender, EventArgs e)
        {
            if (dtpOd.Value <= dtpDo.Value)
            {
                AktualizujDostupnostAut(dtpOd.Value, dtpDo.Value);
                NacistAuta();
            }
        }

        private void cmbAuto_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Uvolníme případný předchozí obrázek
            if (pictureBoxAuto.Image != null)
            {
                pictureBoxAuto.Image.Dispose();
                pictureBoxAuto.Image = null;
            }

            // Pokud není nic vybráno nebo tag není nastaven, nic neděláme
            if (cmbAuto.SelectedIndex < 0 || cmbAuto.Tag == null)
                return;

            var dt = cmbAuto.Tag as DataTable;
            if (dt == null) return;

            int index = cmbAuto.SelectedIndex;
            string imagePath = dt.Rows[index]["Obrazek"].ToString();

            // Kontrola existence cesty a souboru
            if (!string.IsNullOrWhiteSpace(imagePath) && File.Exists(imagePath))
            {
                pictureBoxAuto.Image = Image.FromFile(imagePath);
            }
            else
            {
                // Výchozí obrázek – přidáš si ho do Resources (viz níže)
                pictureBoxAuto.Image = Properties.Resources.default_car;
            }
        }
    }
}
