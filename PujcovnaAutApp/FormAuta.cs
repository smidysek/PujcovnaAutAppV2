using System;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace PujcovnaAutApp
{
    public partial class FormAuta : Form
    {
        public FormAuta()
        {
            InitializeComponent();
            pictureBoxAuto.Image = Properties.Resources._default;
            NacistAuta();
        }

        private void NacistAuta()
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();

                var adapter = new SQLiteDataAdapter(@"
            SELECT 
                a.ID, a.SPZ, a.Znacka, a.Model, a.RokVyroby, a.CenaZaDen, a.KDispozici, a.Obrazek,
                CASE 
                    WHEN EXISTS (
                        SELECT 1 FROM Pujcky p 
                        WHERE p.AutoID = a.ID 
                          AND DATE('now') BETWEEN p.DatumOd AND p.DatumDo
                    ) 
                    THEN '❌ Obsazeno' 
                    ELSE '✔️ K dispozici' 
                END AS Dostupnost
            FROM Auta a", conn);

                var dt = new DataTable();
                adapter.Fill(dt);
                dgvAuta.DataSource = dt;

                dgvAuta.Columns["KDispozici"].Visible = false;
                // Skrytí sloupce s cestou k obrázku
                if (dgvAuta.Columns.Contains("Obrazek"))
                {
                    dgvAuta.Columns["Obrazek"].Visible = false;
                }
            }
        }

        private void btnAddAuto_Click(object sender, EventArgs e)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                var cmd = new SQLiteCommand("INSERT INTO Auta (SPZ, Znacka, Model, RokVyroby, CenaZaDen, KDispozici) VALUES (@spz, @znacka, @model, @rok, @cena, @dispo)", conn);
                cmd.Parameters.AddWithValue("@spz", txtSPZ.Text);
                cmd.Parameters.AddWithValue("@znacka", txtZnacka.Text);
                cmd.Parameters.AddWithValue("@model", txtModel.Text);
                cmd.Parameters.AddWithValue("@rok", numRokVyroby.Value);
                cmd.Parameters.AddWithValue("@cena", numCenaZaDen.Value);
                cmd.Parameters.AddWithValue("@dispo", chkDostupne.Checked ? 1 : 0);
                cmd.ExecuteNonQuery();
            }
            NacistAuta();
            MessageBox.Show("Auto přidáno.");
        }

        private void btnDeleteAuto_Click(object sender, EventArgs e)
        {
            if (dgvAuta.SelectedRows.Count == 0) return;

            int id = Convert.ToInt32(dgvAuta.SelectedRows[0].Cells["ID"].Value);
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                var cmd = new SQLiteCommand("DELETE FROM Auta WHERE ID=@id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
            NacistAuta();
            MessageBox.Show("Auto smazáno.");
        }

        private void btnUpdateAuto_Click(object sender, EventArgs e)
        {
            if (dgvAuta.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vyberte auto pro úpravu.");
                return;
            }

            int id = Convert.ToInt32(dgvAuta.SelectedRows[0].Cells["ID"].Value);

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                var cmd = new SQLiteCommand(@"UPDATE Auta 
                    SET SPZ = @spz, Znacka = @znacka, Model = @model, 
                        RokVyroby = @rok, CenaZaDen = @cena, KDispozici = @dispo 
                    WHERE ID = @id", conn);

                cmd.Parameters.AddWithValue("@spz", txtSPZ.Text);
                cmd.Parameters.AddWithValue("@znacka", txtZnacka.Text);
                cmd.Parameters.AddWithValue("@model", txtModel.Text);
                cmd.Parameters.AddWithValue("@rok", numRokVyroby.Value);
                cmd.Parameters.AddWithValue("@cena", numCenaZaDen.Value);
                cmd.Parameters.AddWithValue("@dispo", chkDostupne.Checked ? 1 : 0);
                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Auto bylo upraveno.");
            NacistAuta();
        }

        private void dgvAuta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvAuta.Rows[e.RowIndex];

            if (row.IsNewRow)
            {
                txtSPZ.Clear();
                txtZnacka.Clear();
                txtModel.Clear();
                numRokVyroby.Value = numRokVyroby.Minimum;
                numCenaZaDen.Value = numCenaZaDen.Minimum;
                chkDostupne.Checked = false;
                pictureBoxAuto.Image = Properties.Resources._default;
                return;
            }

            txtSPZ.Text = row.Cells["SPZ"].Value?.ToString() ?? "";
            txtZnacka.Text = row.Cells["Znacka"].Value?.ToString() ?? "";
            txtModel.Text = row.Cells["Model"].Value?.ToString() ?? "";

            if (row.Cells["RokVyroby"].Value != DBNull.Value)
            {
                int rok = Convert.ToInt32(row.Cells["RokVyroby"].Value);
                rok = Math.Min(Math.Max(rok, (int)numRokVyroby.Minimum), (int)numRokVyroby.Maximum);
                numRokVyroby.Value = rok;
            }

            if (row.Cells["CenaZaDen"].Value != DBNull.Value)
            {
                decimal cena = Convert.ToDecimal(row.Cells["CenaZaDen"].Value);
                cena = Math.Min(Math.Max(cena, numCenaZaDen.Minimum), numCenaZaDen.Maximum);
                numCenaZaDen.Value = cena;
            }

            chkDostupne.Checked = row.Cells["KDispozici"].Value is int dostupnost && dostupnost == 1;

            // Zobrazit obrázek (pokud existuje sloupec Obrazek)
            if (dgvAuta.Columns.Contains("Obrazek"))
            {
                var imagePathObj = row.Cells["Obrazek"].Value;
                if (imagePathObj != DBNull.Value && imagePathObj != null)
                {
                    string relPath = imagePathObj.ToString();
                    string absPath = Path.Combine(Application.StartupPath, relPath);

                    if (File.Exists(absPath))
                    {
                        try
                        {
                            pictureBoxAuto.Image = Image.FromFile(absPath);
                        }
                        catch
                        {
                            pictureBoxAuto.Image = Properties.Resources._default;
                            MessageBox.Show("Obrázek se nepodařilo načíst.");
                        }
                    }
                    else
                    {
                        pictureBoxAuto.Image = Properties.Resources._default;
                    }
                }
                else
                {
                    pictureBoxAuto.Image = Properties.Resources._default;
                }
            }
        }


        private void btnNahratObrazek_Click(object sender, EventArgs e)
        {
            if (dgvAuta.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vyberte auto, ke kterému chcete nahrát obrázek.");
                return;
            }

            int autoId = Convert.ToInt32(dgvAuta.SelectedRows[0].Cells["ID"].Value);

            using (var dialog = new OpenFileDialog())
            {
                dialog.Title = "Vyberte obrázek auta";
                dialog.Filter = "Obrázky (*.jpg;*.png;*.jpeg)|*.jpg;*.png;*.jpeg";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string originalPath = dialog.FileName;

                    // Cíl do složky "obrazky" v aplikaci
                    string targetDir = Path.Combine(Application.StartupPath, "obrazky");
                    Directory.CreateDirectory(targetDir);
                    string fileName = $"{autoId}_{Path.GetFileName(originalPath)}";
                    string newRelPath = Path.Combine("obrazky", fileName);
                    string newAbsPath = Path.Combine(targetDir, fileName);

                    File.Copy(originalPath, newAbsPath, true);

                    using (var conn = DatabaseHelper.GetConnection())
                    {
                        conn.Open();
                        var cmd = new SQLiteCommand("UPDATE Auta SET Obrazek = @obrazek WHERE ID = @id", conn);
                        cmd.Parameters.AddWithValue("@obrazek", newRelPath);
                        cmd.Parameters.AddWithValue("@id", autoId);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Obrázek byl úspěšně přiřazen k autu.");
                    NacistAuta();
                }
            }
        }
    }
}
