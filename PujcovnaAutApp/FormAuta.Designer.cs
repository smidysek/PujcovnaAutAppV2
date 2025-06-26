namespace PujcovnaAutApp
{
    partial class FormAuta
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
            this.dgvAuta = new System.Windows.Forms.DataGridView();
            this.txtSPZ = new System.Windows.Forms.TextBox();
            this.txtZnacka = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.numRokVyroby = new System.Windows.Forms.NumericUpDown();
            this.numCenaZaDen = new System.Windows.Forms.NumericUpDown();
            this.chkDostupne = new System.Windows.Forms.CheckBox();
            this.btnAddAuto = new System.Windows.Forms.Button();
            this.btnDeleteAuto = new System.Windows.Forms.Button();
            this.btnUpdateAuto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnNahratObrazek = new System.Windows.Forms.Button();
            this.pictureBoxAuto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRokVyroby)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCenaZaDen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAuto)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAuta
            // 
            this.dgvAuta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAuta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAuta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAuta.Location = new System.Drawing.Point(12, 12);
            this.dgvAuta.Name = "dgvAuta";
            this.dgvAuta.Size = new System.Drawing.Size(737, 150);
            this.dgvAuta.TabIndex = 0;
            this.dgvAuta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAuta_CellClick);
            // 
            // txtSPZ
            // 
            this.txtSPZ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSPZ.Location = new System.Drawing.Point(12, 197);
            this.txtSPZ.Name = "txtSPZ";
            this.txtSPZ.Size = new System.Drawing.Size(158, 20);
            this.txtSPZ.TabIndex = 1;
            // 
            // txtZnacka
            // 
            this.txtZnacka.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtZnacka.Location = new System.Drawing.Point(12, 241);
            this.txtZnacka.Name = "txtZnacka";
            this.txtZnacka.Size = new System.Drawing.Size(158, 20);
            this.txtZnacka.TabIndex = 2;
            // 
            // txtModel
            // 
            this.txtModel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtModel.Location = new System.Drawing.Point(12, 289);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(158, 20);
            this.txtModel.TabIndex = 3;
            // 
            // numRokVyroby
            // 
            this.numRokVyroby.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numRokVyroby.Location = new System.Drawing.Point(176, 197);
            this.numRokVyroby.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.numRokVyroby.Name = "numRokVyroby";
            this.numRokVyroby.Size = new System.Drawing.Size(179, 20);
            this.numRokVyroby.TabIndex = 4;
            this.numRokVyroby.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // numCenaZaDen
            // 
            this.numCenaZaDen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numCenaZaDen.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numCenaZaDen.Location = new System.Drawing.Point(176, 242);
            this.numCenaZaDen.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.numCenaZaDen.Name = "numCenaZaDen";
            this.numCenaZaDen.Size = new System.Drawing.Size(179, 20);
            this.numCenaZaDen.TabIndex = 5;
            this.numCenaZaDen.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // chkDostupne
            // 
            this.chkDostupne.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkDostupne.AutoSize = true;
            this.chkDostupne.Location = new System.Drawing.Point(176, 291);
            this.chkDostupne.Name = "chkDostupne";
            this.chkDostupne.Size = new System.Drawing.Size(76, 17);
            this.chkDostupne.TabIndex = 6;
            this.chkDostupne.Text = "K dispozici";
            this.chkDostupne.UseVisualStyleBackColor = true;
            // 
            // btnAddAuto
            // 
            this.btnAddAuto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddAuto.BackColor = System.Drawing.Color.Peru;
            this.btnAddAuto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddAuto.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAddAuto.Location = new System.Drawing.Point(12, 335);
            this.btnAddAuto.Name = "btnAddAuto";
            this.btnAddAuto.Size = new System.Drawing.Size(158, 37);
            this.btnAddAuto.TabIndex = 7;
            this.btnAddAuto.Text = "Přidat auto";
            this.btnAddAuto.UseVisualStyleBackColor = false;
            this.btnAddAuto.Click += new System.EventHandler(this.btnAddAuto_Click);
            // 
            // btnDeleteAuto
            // 
            this.btnDeleteAuto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDeleteAuto.BackColor = System.Drawing.Color.Peru;
            this.btnDeleteAuto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteAuto.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDeleteAuto.Location = new System.Drawing.Point(176, 335);
            this.btnDeleteAuto.Name = "btnDeleteAuto";
            this.btnDeleteAuto.Size = new System.Drawing.Size(179, 37);
            this.btnDeleteAuto.TabIndex = 8;
            this.btnDeleteAuto.Text = "\tSmazat vybrané auto";
            this.btnDeleteAuto.UseVisualStyleBackColor = false;
            this.btnDeleteAuto.Click += new System.EventHandler(this.btnDeleteAuto_Click);
            // 
            // btnUpdateAuto
            // 
            this.btnUpdateAuto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUpdateAuto.BackColor = System.Drawing.Color.OrangeRed;
            this.btnUpdateAuto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdateAuto.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUpdateAuto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUpdateAuto.Location = new System.Drawing.Point(361, 335);
            this.btnUpdateAuto.Name = "btnUpdateAuto";
            this.btnUpdateAuto.Size = new System.Drawing.Size(170, 37);
            this.btnUpdateAuto.TabIndex = 9;
            this.btnUpdateAuto.Text = "Upravit vybrané auto";
            this.btnUpdateAuto.UseVisualStyleBackColor = false;
            this.btnUpdateAuto.Click += new System.EventHandler(this.btnUpdateAuto_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "SPZ";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Značka";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Model";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(176, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Rok výroby";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(173, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Cena za den";
            // 
            // btnNahratObrazek
            // 
            this.btnNahratObrazek.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNahratObrazek.BackColor = System.Drawing.Color.Peru;
            this.btnNahratObrazek.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNahratObrazek.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNahratObrazek.Location = new System.Drawing.Point(361, 273);
            this.btnNahratObrazek.Name = "btnNahratObrazek";
            this.btnNahratObrazek.Size = new System.Drawing.Size(170, 37);
            this.btnNahratObrazek.TabIndex = 15;
            this.btnNahratObrazek.Text = "Nahrát Obrázek";
            this.btnNahratObrazek.UseVisualStyleBackColor = false;
            this.btnNahratObrazek.Click += new System.EventHandler(this.btnNahratObrazek_Click);
            // 
            // pictureBoxAuto
            // 
            this.pictureBoxAuto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxAuto.Image = global::PujcovnaAutApp.Properties.Resources.default_car;
            this.pictureBoxAuto.Location = new System.Drawing.Point(543, 181);
            this.pictureBoxAuto.Name = "pictureBoxAuto";
            this.pictureBoxAuto.Size = new System.Drawing.Size(206, 129);
            this.pictureBoxAuto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAuto.TabIndex = 16;
            this.pictureBoxAuto.TabStop = false;
            // 
            // FormAuta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 450);
            this.Controls.Add(this.pictureBoxAuto);
            this.Controls.Add(this.btnNahratObrazek);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdateAuto);
            this.Controls.Add(this.btnDeleteAuto);
            this.Controls.Add(this.btnAddAuto);
            this.Controls.Add(this.chkDostupne);
            this.Controls.Add(this.numCenaZaDen);
            this.Controls.Add(this.numRokVyroby);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtZnacka);
            this.Controls.Add(this.txtSPZ);
            this.Controls.Add(this.dgvAuta);
            this.Name = "FormAuta";
            this.Text = "FormAuta";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRokVyroby)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCenaZaDen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAuto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAuta;
        private System.Windows.Forms.TextBox txtSPZ;
        private System.Windows.Forms.TextBox txtZnacka;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.NumericUpDown numRokVyroby;
        private System.Windows.Forms.NumericUpDown numCenaZaDen;
        private System.Windows.Forms.CheckBox chkDostupne;
        private System.Windows.Forms.Button btnAddAuto;
        private System.Windows.Forms.Button btnDeleteAuto;
        private System.Windows.Forms.Button btnUpdateAuto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnNahratObrazek;
        private System.Windows.Forms.PictureBox pictureBoxAuto;
    }
}