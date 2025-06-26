using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PujcovnaAutApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            DatabaseHelper.AktualizovatDostupnostPodleDnesnihoData();
        }

        private void btnAuta_Click(object sender, EventArgs e)
        {
            var form = new FormAuta();
            form.ShowDialog();
        }

        private void btnZakaznici_Click(object sender, EventArgs e)
        {
            var form = new FormZakaznici();
            form.ShowDialog();
        }

        private void btnPujcky_Click(object sender, EventArgs e)
        {
            var form = new FormPujcky();
            form.ShowDialog();
        }

        private void btnStatistika_Click(object sender, EventArgs e)
        {
            var form = new FormStatistika();
            form.ShowDialog();
        }

        private void btnNovaPujcka_Click(object sender, EventArgs e)
        {
            var form = new FormNovaPujcka();
            form.ShowDialog();
        }

        private void btnKonec_Click(object sender, EventArgs e)
        {
            Close();
        }

        //MENU
        private void autaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormAuta();
            form.ShowDialog();
        }

        private void zákaznícíToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormZakaznici();
            form.ShowDialog();
        }

        private void novéZapůjčeníToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormNovaPujcka();
            form.ShowDialog();
        }

        private void záznamyPůjčeníToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormPujcky();
            form.ShowDialog();
        }

        private void četnostPůjčováníToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormStatistika();
            form.ShowDialog();
        }

        private void jednotlivéVozidlaPodleObdobíToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormPujckyVCase();
            form.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var form = new FormAuta();
            form.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            var form = new FormZakaznici();
            form.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            var form = new FormNovaPujcka();
            form.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            var form = new FormPujcky();
            form.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            var form = new FormStatistika();
            form.ShowDialog();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string napovedaText = @"🧭 Uživatelská příručka – Aplikace Půjčovna aut

1. 🚗 SPRÁVA VOZIDEL:
- Přidání, úprava, mazání aut
- Stav dostupnosti
- Nahrávání obrázků

2. 👤 ZÁKAZNÍCI:
- Přidání a úprava údajů zákazníků

3. 📅 PŮJČKY:
- Přidání nové půjčky
- Vyhledávání podle jména a vozidla
- Mazání záznamů

4. 📤 EXPORT FAKTURY (PDF):
- Vyberte záznam a klikněte na 'Export faktury'
- Faktura se uloží jako PDF s celkovou cenou

5. 📊 STATISTIKA:
- Přehledné grafy podle četnosti půjček

💾 Data se ukládají do SQLite (data.db)
📂 Obrázky jsou v podsložce /obrazky

✅ Tip: Faktury lze kdykoli vygenerovat znovu.
";

            MessageBox.Show(napovedaText, "Nápověda", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
