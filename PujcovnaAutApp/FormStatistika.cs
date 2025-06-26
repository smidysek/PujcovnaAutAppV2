using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Windows.Forms;

namespace PujcovnaAutApp
{
    public partial class FormStatistika : Form
    {
        public FormStatistika()
        {
            InitializeComponent();
            NacistDataAGenerovatGraf();
        }

        private void NacistDataAGenerovatGraf()
        {
            var auta = new Dictionary<int, string>(); // ID auta → "Značka Model (SPZ)"
            var pocetPujcek = new Dictionary<int, int>(); // ID auta → počet půjček

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();

                // 1. Načti auta (i značku a model)
                var cmdAuta = new SQLiteCommand("SELECT ID, Znacka, Model, SPZ FROM Auta", conn);
                using (var reader = cmdAuta.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string znacka = reader.GetString(1);
                        string model = reader.GetString(2);
                        string spz = reader.GetString(3);

                        string popis = $"{znacka} {model} ({spz})";
                        auta[id] = popis;
                        pocetPujcek[id] = 0;
                    }
                }

                // 2. Spočítej výskyty půjček
                var cmdPujcky = new SQLiteCommand("SELECT AutoID FROM Pujcky", conn);
                using (var reader = cmdPujcky.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int autoId = reader.GetInt32(0);
                        if (pocetPujcek.ContainsKey(autoId))
                            pocetPujcek[autoId]++;
                    }
                }
            }

            // 3. Připrav data pro graf
            var labels = auta.Values.ToArray(); // Značka Model (SPZ)
            var values = new ChartValues<int>(pocetPujcek.Select(p => p.Value));

            var series = new ColumnSeries
            {
                Title = "Počet půjčení",
                Values = values,
                DataLabels = false,
                LabelPoint = point => $"{labels[point.Key]}: {point.Y}x", // Tooltip při najetí
                Fill = System.Windows.Media.Brushes.Peru
            };

            chartPujcky.Series = new SeriesCollection { series };

            chartPujcky.AxisX.Clear();
            chartPujcky.AxisX.Add(new Axis
            {
                Title = "Auta",
                Labels = labels
            });

            chartPujcky.AxisY.Clear();
            chartPujcky.AxisY.Add(new Axis
            {
                Title = "Počet půjčení"
            });
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

        private void statistikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormStatistika();
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

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Close();
        }

        //MENU
        private void autaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormAuta();
            form.ShowDialog();
        }
        private void zákaznícíToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var form = new FormZakaznici();
            form.ShowDialog();
        }

        private void novéZapůjčeníToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var form = new FormNovaPujcka();
            form.ShowDialog();
        }

        private void záznamyPůjčeníToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var form = new FormPujcky();
            form.ShowDialog();
        }

        private void jednotlivéVozidlaPodleObdobíToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var form = new FormPujckyVCase();
            form.ShowDialog();
        }
    }
}
