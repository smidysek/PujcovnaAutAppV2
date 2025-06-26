namespace PujcovnaAutApp
{
    partial class FormStatistika
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.chartPujcky = new LiveCharts.WinForms.CartesianChart();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.autaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zákaznícíToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novéZapůjčeníToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.záznamyPůjčeníToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statistikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.četnostPůjčováníToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jednotlivéVozidlaPodleObdobíToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartPujcky
            // 
            this.chartPujcky.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartPujcky.Location = new System.Drawing.Point(0, 0);
            this.chartPujcky.Name = "chartPujcky";
            this.chartPujcky.Size = new System.Drawing.Size(800, 450);
            this.chartPujcky.TabIndex = 0;
            this.chartPujcky.Text = "cartesianChart1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Peru;
            this.menuStrip1.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autaToolStripMenuItem,
            this.zákaznícíToolStripMenuItem,
            this.novéZapůjčeníToolStripMenuItem,
            this.záznamyPůjčeníToolStripMenuItem,
            this.statistikaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 26);
            this.menuStrip1.TabIndex = 29;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // autaToolStripMenuItem
            // 
            this.autaToolStripMenuItem.Name = "autaToolStripMenuItem";
            this.autaToolStripMenuItem.Size = new System.Drawing.Size(53, 22);
            this.autaToolStripMenuItem.Text = "Auta";
            this.autaToolStripMenuItem.Click += new System.EventHandler(this.autaToolStripMenuItem_Click);
            // 
            // zákaznícíToolStripMenuItem
            // 
            this.zákaznícíToolStripMenuItem.Name = "zákaznícíToolStripMenuItem";
            this.zákaznícíToolStripMenuItem.Size = new System.Drawing.Size(86, 22);
            this.zákaznícíToolStripMenuItem.Text = "Zákaznící";
            this.zákaznícíToolStripMenuItem.Click += new System.EventHandler(this.zákaznícíToolStripMenuItem_Click_1);
            // 
            // novéZapůjčeníToolStripMenuItem
            // 
            this.novéZapůjčeníToolStripMenuItem.Name = "novéZapůjčeníToolStripMenuItem";
            this.novéZapůjčeníToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.novéZapůjčeníToolStripMenuItem.Text = "Nové zapůjčení";
            this.novéZapůjčeníToolStripMenuItem.Click += new System.EventHandler(this.novéZapůjčeníToolStripMenuItem_Click_1);
            // 
            // záznamyPůjčeníToolStripMenuItem
            // 
            this.záznamyPůjčeníToolStripMenuItem.Name = "záznamyPůjčeníToolStripMenuItem";
            this.záznamyPůjčeníToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.záznamyPůjčeníToolStripMenuItem.Text = "Záznamy půjčení";
            this.záznamyPůjčeníToolStripMenuItem.Click += new System.EventHandler(this.záznamyPůjčeníToolStripMenuItem_Click_1);
            // 
            // statistikaToolStripMenuItem
            // 
            this.statistikaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.četnostPůjčováníToolStripMenuItem,
            this.jednotlivéVozidlaPodleObdobíToolStripMenuItem});
            this.statistikaToolStripMenuItem.Name = "statistikaToolStripMenuItem";
            this.statistikaToolStripMenuItem.Size = new System.Drawing.Size(86, 22);
            this.statistikaToolStripMenuItem.Text = "Statistika";
            // 
            // četnostPůjčováníToolStripMenuItem
            // 
            this.četnostPůjčováníToolStripMenuItem.Name = "četnostPůjčováníToolStripMenuItem";
            this.četnostPůjčováníToolStripMenuItem.Size = new System.Drawing.Size(297, 22);
            this.četnostPůjčováníToolStripMenuItem.Text = "Četnost půjčování";
            // 
            // jednotlivéVozidlaPodleObdobíToolStripMenuItem
            // 
            this.jednotlivéVozidlaPodleObdobíToolStripMenuItem.Name = "jednotlivéVozidlaPodleObdobíToolStripMenuItem";
            this.jednotlivéVozidlaPodleObdobíToolStripMenuItem.Size = new System.Drawing.Size(297, 22);
            this.jednotlivéVozidlaPodleObdobíToolStripMenuItem.Text = "Jednotlivé vozidla podle období";
            this.jednotlivéVozidlaPodleObdobíToolStripMenuItem.Click += new System.EventHandler(this.jednotlivéVozidlaPodleObdobíToolStripMenuItem_Click_1);
            // 
            // FormStatistika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.chartPujcky);
            this.Name = "FormStatistika";
            this.Text = "FormStatistika";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LiveCharts.WinForms.CartesianChart chartPujcky;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem autaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zákaznícíToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novéZapůjčeníToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem záznamyPůjčeníToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statistikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem četnostPůjčováníToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jednotlivéVozidlaPodleObdobíToolStripMenuItem;
    }
}