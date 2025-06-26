namespace PujcovnaAutApp
{
    partial class FormNovaPujcka
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
            this.cmbZakaznik = new System.Windows.Forms.ComboBox();
            this.cmbAuto = new System.Windows.Forms.ComboBox();
            this.dtpOd = new System.Windows.Forms.DateTimePicker();
            this.dtpDo = new System.Windows.Forms.DateTimePicker();
            this.btnUlozit = new System.Windows.Forms.Button();
            this.btnZrusit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBoxAuto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAuto)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbZakaznik
            // 
            this.cmbZakaznik.FormattingEnabled = true;
            this.cmbZakaznik.Location = new System.Drawing.Point(12, 122);
            this.cmbZakaznik.Name = "cmbZakaznik";
            this.cmbZakaznik.Size = new System.Drawing.Size(203, 21);
            this.cmbZakaznik.TabIndex = 0;
            // 
            // cmbAuto
            // 
            this.cmbAuto.FormattingEnabled = true;
            this.cmbAuto.Location = new System.Drawing.Point(12, 168);
            this.cmbAuto.Name = "cmbAuto";
            this.cmbAuto.Size = new System.Drawing.Size(203, 21);
            this.cmbAuto.TabIndex = 1;
            this.cmbAuto.SelectedIndexChanged += new System.EventHandler(this.cmbAuto_SelectedIndexChanged);
            // 
            // dtpOd
            // 
            this.dtpOd.Location = new System.Drawing.Point(15, 28);
            this.dtpOd.Name = "dtpOd";
            this.dtpOd.Size = new System.Drawing.Size(200, 20);
            this.dtpOd.TabIndex = 2;
            this.dtpOd.ValueChanged += new System.EventHandler(this.dtpOd_ValueChanged);
            // 
            // dtpDo
            // 
            this.dtpDo.Location = new System.Drawing.Point(15, 74);
            this.dtpDo.Name = "dtpDo";
            this.dtpDo.Size = new System.Drawing.Size(200, 20);
            this.dtpDo.TabIndex = 3;
            this.dtpDo.ValueChanged += new System.EventHandler(this.dtpDo_ValueChanged);
            // 
            // btnUlozit
            // 
            this.btnUlozit.BackColor = System.Drawing.Color.Peru;
            this.btnUlozit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUlozit.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUlozit.Location = new System.Drawing.Point(12, 209);
            this.btnUlozit.Name = "btnUlozit";
            this.btnUlozit.Size = new System.Drawing.Size(153, 37);
            this.btnUlozit.TabIndex = 22;
            this.btnUlozit.Text = "Uložit záznam";
            this.btnUlozit.UseVisualStyleBackColor = false;
            this.btnUlozit.Click += new System.EventHandler(this.btnUlozit_Click);
            // 
            // btnZrusit
            // 
            this.btnZrusit.BackColor = System.Drawing.Color.OrangeRed;
            this.btnZrusit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnZrusit.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZrusit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnZrusit.Location = new System.Drawing.Point(171, 209);
            this.btnZrusit.Name = "btnZrusit";
            this.btnZrusit.Size = new System.Drawing.Size(128, 37);
            this.btnZrusit.TabIndex = 23;
            this.btnZrusit.Text = "Zrušit";
            this.btnZrusit.UseVisualStyleBackColor = false;
            this.btnZrusit.Click += new System.EventHandler(this.btnZrusit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Datum OD:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Datum DO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Zákazník";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Vozidlo";
            // 
            // pictureBoxAuto
            // 
            this.pictureBoxAuto.Image = global::PujcovnaAutApp.Properties.Resources.default_car;
            this.pictureBoxAuto.Location = new System.Drawing.Point(236, 12);
            this.pictureBoxAuto.Name = "pictureBoxAuto";
            this.pictureBoxAuto.Size = new System.Drawing.Size(263, 177);
            this.pictureBoxAuto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAuto.TabIndex = 28;
            this.pictureBoxAuto.TabStop = false;
            // 
            // FormNovaPujcka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBoxAuto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnZrusit);
            this.Controls.Add(this.btnUlozit);
            this.Controls.Add(this.dtpDo);
            this.Controls.Add(this.dtpOd);
            this.Controls.Add(this.cmbAuto);
            this.Controls.Add(this.cmbZakaznik);
            this.Name = "FormNovaPujcka";
            this.Text = "FormNovaPujcka";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAuto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbZakaznik;
        private System.Windows.Forms.ComboBox cmbAuto;
        private System.Windows.Forms.DateTimePicker dtpOd;
        private System.Windows.Forms.DateTimePicker dtpDo;
        private System.Windows.Forms.Button btnUlozit;
        private System.Windows.Forms.Button btnZrusit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBoxAuto;
    }
}