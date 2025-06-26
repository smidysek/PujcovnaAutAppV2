using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace PujcovnaAutApp
{
    public partial class FormZakaznici : Form
    {

        private int selectedZakaznikId = -1;

        public FormZakaznici()
        {
            InitializeComponent();
            NacistZakazniky();
        }

        private void NacistZakazniky()
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                var adapter = new SQLiteDataAdapter("SELECT * FROM Zakaznici", conn);
                var dt = new DataTable();
                adapter.Fill(dt);
                dgvZakaznici.DataSource = dt;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                var cmd = new SQLiteCommand("INSERT INTO Zakaznici (Jmeno, Prijmeni, Telefon, Email) VALUES (@jmeno, @prijmeni, @telefon, @email)", conn);
                cmd.Parameters.AddWithValue("@jmeno", txtJmeno.Text);
                cmd.Parameters.AddWithValue("@prijmeni", txtPrijmeni.Text);
                cmd.Parameters.AddWithValue("@telefon", txtTelefon.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.ExecuteNonQuery();
            }
            NacistZakazniky();
            MessageBox.Show("Zákazník přidán.");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedZakaznikId == -1)
            {
                MessageBox.Show("Vyberte zákazníka k úpravě.");
                return;
            }

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                var cmd = new SQLiteCommand(@"
            UPDATE Zakaznici SET 
                Jmeno = @jmeno,
                Prijmeni = @prijmeni,
                Telefon = @telefon,
                Email = @email
            WHERE ID = @id", conn);

                cmd.Parameters.AddWithValue("@jmeno", txtJmeno.Text);
                cmd.Parameters.AddWithValue("@prijmeni", txtPrijmeni.Text);
                cmd.Parameters.AddWithValue("@telefon", txtTelefon.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@id", selectedZakaznikId);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Zákazník byl upraven.");
            NacistZakazniky(); // metoda, která znovu načte DataGridView
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvZakaznici.SelectedRows.Count == 0) return;

            int id = Convert.ToInt32(dgvZakaznici.SelectedRows[0].Cells["ID"].Value);

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                var cmd = new SQLiteCommand("DELETE FROM Zakaznici WHERE ID=@id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }

            NacistZakazniky();
            MessageBox.Show("Zákazník smazán.");
        }

        private void dgvZakaznici_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvZakaznici.Rows.Count - 1)
            {
                DataGridViewRow row = dgvZakaznici.Rows[e.RowIndex];

                selectedZakaznikId = Convert.ToInt32(row.Cells["ID"].Value);
                txtJmeno.Text = row.Cells["Jmeno"].Value?.ToString();
                txtPrijmeni.Text = row.Cells["Prijmeni"].Value?.ToString();
                txtTelefon.Text = row.Cells["Telefon"].Value?.ToString();
                txtEmail.Text = row.Cells["Email"].Value?.ToString();
            }
            else
            {
                // Kliknuto na prázdný řádek – vyčisti formulář
                selectedZakaznikId = -1;
                txtJmeno.Text = "";
                txtPrijmeni.Text = "";
                txtTelefon.Text = "";
                txtEmail.Text = "";
            }
        }
    }
}
