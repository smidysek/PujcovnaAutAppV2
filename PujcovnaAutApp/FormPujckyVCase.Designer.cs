namespace PujcovnaAutApp
{
    partial class FormPujckyVCase
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
            this.chartCasovyVyvoj = new LiveCharts.WinForms.CartesianChart();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.četnostPůjčováníToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jednotlivéVozidlaPodleObdobíToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartCasovyVyvoj
            // 
            this.chartCasovyVyvoj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartCasovyVyvoj.Location = new System.Drawing.Point(0, 0);
            this.chartCasovyVyvoj.Name = "chartCasovyVyvoj";
            this.chartCasovyVyvoj.Size = new System.Drawing.Size(800, 450);
            this.chartCasovyVyvoj.TabIndex = 0;
            this.chartCasovyVyvoj.Text = "cartesianChart1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Peru;
            this.menuStrip1.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.četnostPůjčováníToolStripMenuItem,
            this.jednotlivéVozidlaPodleObdobíToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 26);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // četnostPůjčováníToolStripMenuItem
            // 
            this.četnostPůjčováníToolStripMenuItem.Name = "četnostPůjčováníToolStripMenuItem";
            this.četnostPůjčováníToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.četnostPůjčováníToolStripMenuItem.Text = "Četnost půjčování";
            this.četnostPůjčováníToolStripMenuItem.Click += new System.EventHandler(this.četnostPůjčováníToolStripMenuItem_Click);
            // 
            // jednotlivéVozidlaPodleObdobíToolStripMenuItem
            // 
            this.jednotlivéVozidlaPodleObdobíToolStripMenuItem.Name = "jednotlivéVozidlaPodleObdobíToolStripMenuItem";
            this.jednotlivéVozidlaPodleObdobíToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.jednotlivéVozidlaPodleObdobíToolStripMenuItem.Text = "Jednotlivé vozidla podle období";
            this.jednotlivéVozidlaPodleObdobíToolStripMenuItem.Click += new System.EventHandler(this.jednotlivéVozidlaPodleObdobíToolStripMenuItem_Click);
            // 
            // FormPujckyVCase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.chartCasovyVyvoj);
            this.Name = "FormPujckyVCase";
            this.Text = "FormPujckyVCase";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LiveCharts.WinForms.CartesianChart chartCasovyVyvoj;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem četnostPůjčováníToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jednotlivéVozidlaPodleObdobíToolStripMenuItem;
    }
}