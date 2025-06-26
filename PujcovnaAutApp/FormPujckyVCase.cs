using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Windows.Forms;

namespace PujcovnaAutApp
{
    public partial class FormPujckyVCase : Form
    {
        public FormPujckyVCase()
        {
            InitializeComponent();
            NacistDataProGraf();
        }

        private void NacistDataProGraf()
        {
            var serieDict = new Dictionary<string, Dictionary<DateTime, int>>();

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                var cmd = new SQLiteCommand(@"
                    SELECT a.SPZ, a.Znacka, a.Model, p.DatumOd 
                    FROM Pujcky p
                    JOIN Auta a ON p.AutoID = a.ID
                ", conn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string autoKey = $"{reader.GetString(0)} ({reader.GetString(1)} {reader.GetString(2)})";
                        DateTime datum = DateTime.Parse(reader["DatumOd"].ToString());

                        if (!serieDict.ContainsKey(autoKey))
                            serieDict[autoKey] = new Dictionary<DateTime, int>();

                        if (!serieDict[autoKey].ContainsKey(datum))
                            serieDict[autoKey][datum] = 0;

                        serieDict[autoKey][datum]++;
                    }
                }
            }

            var series = new SeriesCollection();
            var allDates = serieDict.SelectMany(s => s.Value.Keys).Distinct().OrderBy(d => d).ToList();
            var labels = allDates.Select(d => d.ToString("dd.MM.yyyy")).ToArray();

            foreach (var auto in serieDict)
            {
                var values = new ChartValues<int>();
                foreach (var date in allDates)
                {
                    auto.Value.TryGetValue(date, out int count);
                    values.Add(count);
                }

                series.Add(new LineSeries
                {
                    Title = auto.Key,
                    Values = values,
                    PointGeometry = DefaultGeometries.Circle,
                    PointGeometrySize = 6
                });
            }

            chartCasovyVyvoj.Series = series;
            chartCasovyVyvoj.AxisX.Clear();
            chartCasovyVyvoj.AxisX.Add(new Axis
            {
                Title = "Datum",
                Labels = labels
            });
            chartCasovyVyvoj.AxisY.Clear();
            chartCasovyVyvoj.AxisY.Add(new Axis
            {
                Title = "Počet půjček"
            });
        }

        private void četnostPůjčováníToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new FormStatistika();
            f.ShowDialog();
        }

        private void jednotlivéVozidlaPodleObdobíToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new FormPujckyVCase();
            f.ShowDialog();
        }
    }
}
