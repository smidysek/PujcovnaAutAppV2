namespace PujcovnaAutApp
{
    partial class FormPujcky
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
            this.dgvPujcky = new System.Windows.Forms.DataGridView();
            this.btnObnovit = new System.Windows.Forms.Button();
            this.btnSmazat = new System.Windows.Forms.Button();
            this.txtVyhledat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVyhledatAuto = new System.Windows.Forms.TextBox();
            this.btnExportFaktura = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPujcky)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPujcky
            // 
            this.dgvPujcky.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPujcky.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPujcky.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPujcky.Location = new System.Drawing.Point(12, 12);
            this.dgvPujcky.Name = "dgvPujcky";
            this.dgvPujcky.Size = new System.Drawing.Size(743, 150);
            this.dgvPujcky.TabIndex = 0;
            // 
            // btnObnovit
            // 
            this.btnObnovit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnObnovit.BackColor = System.Drawing.Color.Peru;
            this.btnObnovit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnObnovit.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnObnovit.Location = new System.Drawing.Point(12, 190);
            this.btnObnovit.Name = "btnObnovit";
            this.btnObnovit.Size = new System.Drawing.Size(159, 37);
            this.btnObnovit.TabIndex = 23;
            this.btnObnovit.Text = "Obnovit seznam";
            this.btnObnovit.UseVisualStyleBackColor = false;
            this.btnObnovit.Click += new System.EventHandler(this.btnObnovit_Click);
            // 
            // btnSmazat
            // 
            this.btnSmazat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSmazat.BackColor = System.Drawing.Color.OrangeRed;
            this.btnSmazat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSmazat.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSmazat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSmazat.Location = new System.Drawing.Point(376, 190);
            this.btnSmazat.Name = "btnSmazat";
            this.btnSmazat.Size = new System.Drawing.Size(140, 37);
            this.btnSmazat.TabIndex = 24;
            this.btnSmazat.Text = "Smazat záznam";
            this.btnSmazat.UseVisualStyleBackColor = false;
            this.btnSmazat.Click += new System.EventHandler(this.btnSmazat_Click);
            // 
            // txtVyhledat
            // 
            this.txtVyhledat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtVyhledat.Location = new System.Drawing.Point(12, 266);
            this.txtVyhledat.Name = "txtVyhledat";
            this.txtVyhledat.Size = new System.Drawing.Size(159, 20);
            this.txtVyhledat.TabIndex = 25;
            this.txtVyhledat.TextChanged += new System.EventHandler(this.txtVyhledat_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 18);
            this.label1.TabIndex = 26;
            this.label1.Text = "Vyhledat podle jména";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(177, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 18);
            this.label2.TabIndex = 28;
            this.label2.Text = "Vyhledat podle vozidla";
            // 
            // txtVyhledatAuto
            // 
            this.txtVyhledatAuto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtVyhledatAuto.Location = new System.Drawing.Point(177, 266);
            this.txtVyhledatAuto.Name = "txtVyhledatAuto";
            this.txtVyhledatAuto.Size = new System.Drawing.Size(159, 20);
            this.txtVyhledatAuto.TabIndex = 27;
            // 
            // btnExportFaktura
            // 
            this.btnExportFaktura.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExportFaktura.BackColor = System.Drawing.Color.Peru;
            this.btnExportFaktura.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExportFaktura.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnExportFaktura.Location = new System.Drawing.Point(177, 190);
            this.btnExportFaktura.Name = "btnExportFaktura";
            this.btnExportFaktura.Size = new System.Drawing.Size(193, 37);
            this.btnExportFaktura.TabIndex = 29;
            this.btnExportFaktura.Text = "Exportovat Fakturu PDF";
            this.btnExportFaktura.UseVisualStyleBackColor = false;
            this.btnExportFaktura.Click += new System.EventHandler(this.btnExportFaktura_Click);
            // 
            // FormPujcky
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 450);
            this.Controls.Add(this.btnExportFaktura);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtVyhledatAuto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtVyhledat);
            this.Controls.Add(this.btnSmazat);
            this.Controls.Add(this.btnObnovit);
            this.Controls.Add(this.dgvPujcky);
            this.Name = "FormPujcky";
            this.Text = "FormPujcky";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPujcky)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPujcky;
        private System.Windows.Forms.Button btnObnovit;
        private System.Windows.Forms.Button btnSmazat;
        private System.Windows.Forms.TextBox txtVyhledat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVyhledatAuto;
        private System.Windows.Forms.Button btnExportFaktura;
    }
}