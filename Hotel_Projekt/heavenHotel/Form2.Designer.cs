namespace heavenHotel
{
    partial class APEH
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.cbLekerdezesek = new System.Windows.Forms.ComboBox();
            this.btnFuttat = new System.Windows.Forms.Button();
            this.dgvEredmeny = new System.Windows.Forms.DataGridView();
            this.btnExportPDF = new System.Windows.Forms.Button();
            this.btnVissza = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEredmeny)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(195, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(341, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "APEH lekérdezések és statisztikák";
            // 
            // cbLekerdezesek
            // 
            this.cbLekerdezesek.FormattingEnabled = true;
            this.cbLekerdezesek.Location = new System.Drawing.Point(41, 67);
            this.cbLekerdezesek.Name = "cbLekerdezesek";
            this.cbLekerdezesek.Size = new System.Drawing.Size(257, 21);
            this.cbLekerdezesek.TabIndex = 1;
            // 
            // btnFuttat
            // 
            this.btnFuttat.Location = new System.Drawing.Point(326, 66);
            this.btnFuttat.Name = "btnFuttat";
            this.btnFuttat.Size = new System.Drawing.Size(147, 23);
            this.btnFuttat.TabIndex = 2;
            this.btnFuttat.Text = "Lekérdezés futtatása";
            this.btnFuttat.UseVisualStyleBackColor = true;
            this.btnFuttat.Click += new System.EventHandler(this.btnFuttat_Click);
            // 
            // dgvEredmeny
            // 
            this.dgvEredmeny.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEredmeny.Location = new System.Drawing.Point(41, 112);
            this.dgvEredmeny.Name = "dgvEredmeny";
            this.dgvEredmeny.Size = new System.Drawing.Size(608, 226);
            this.dgvEredmeny.TabIndex = 3;
            // 
            // btnExportPDF
            // 
            this.btnExportPDF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnExportPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportPDF.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExportPDF.Location = new System.Drawing.Point(495, 66);
            this.btnExportPDF.Name = "btnExportPDF";
            this.btnExportPDF.Size = new System.Drawing.Size(154, 23);
            this.btnExportPDF.TabIndex = 4;
            this.btnExportPDF.Text = "Exportálás PDF-be";
            this.btnExportPDF.UseVisualStyleBackColor = false;
            // 
            // btnVissza
            // 
            this.btnVissza.Location = new System.Drawing.Point(583, 356);
            this.btnVissza.Name = "btnVissza";
            this.btnVissza.Size = new System.Drawing.Size(98, 27);
            this.btnVissza.TabIndex = 5;
            this.btnVissza.Text = "← Vissza";
            this.btnVissza.UseVisualStyleBackColor = true;
            this.btnVissza.Click += new System.EventHandler(this.btnVissza_Click);
            // 
            // APEH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(693, 395);
            this.Controls.Add(this.btnVissza);
            this.Controls.Add(this.btnExportPDF);
            this.Controls.Add(this.dgvEredmeny);
            this.Controls.Add(this.btnFuttat);
            this.Controls.Add(this.cbLekerdezesek);
            this.Controls.Add(this.lblTitle);
            this.Name = "APEH";
            this.Text = "Heaven Hotel";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEredmeny)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox cbLekerdezesek;
        private System.Windows.Forms.Button btnFuttat;
        private System.Windows.Forms.DataGridView dgvEredmeny;
        private System.Windows.Forms.Button btnExportPDF;
        private System.Windows.Forms.Button btnVissza;
    }
}