namespace heavenHotel
{
    partial class Foglaláskezelő
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
            this.lblErkezes = new System.Windows.Forms.Label();
            this.lblTavozas = new System.Windows.Forms.Label();
            this.dtpErkezes = new System.Windows.Forms.DateTimePicker();
            this.dtpTavozas = new System.Windows.Forms.DateTimePicker();
            this.btnKeres = new System.Windows.Forms.Button();
            this.dgvTalalatok = new System.Windows.Forms.DataGridView();
            this.lblJavaslat = new System.Windows.Forms.Label();
            this.btnAPEH = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTalalatok)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(191, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(312, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Heaven Hotel – Foglaláskezelő";
            // 
            // lblErkezes
            // 
            this.lblErkezes.AutoSize = true;
            this.lblErkezes.Location = new System.Drawing.Point(55, 62);
            this.lblErkezes.Name = "lblErkezes";
            this.lblErkezes.Size = new System.Drawing.Size(48, 13);
            this.lblErkezes.TabIndex = 1;
            this.lblErkezes.Text = "Érkezés:";
            // 
            // lblTavozas
            // 
            this.lblTavozas.AutoSize = true;
            this.lblTavozas.Location = new System.Drawing.Point(215, 62);
            this.lblTavozas.Name = "lblTavozas";
            this.lblTavozas.Size = new System.Drawing.Size(51, 13);
            this.lblTavozas.TabIndex = 2;
            this.lblTavozas.Text = "Távozás:";
            // 
            // dtpErkezes
            // 
            this.dtpErkezes.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpErkezes.Location = new System.Drawing.Point(12, 78);
            this.dtpErkezes.Name = "dtpErkezes";
            this.dtpErkezes.Size = new System.Drawing.Size(141, 20);
            this.dtpErkezes.TabIndex = 3;
            // 
            // dtpTavozas
            // 
            this.dtpTavozas.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTavozas.Location = new System.Drawing.Point(171, 78);
            this.dtpTavozas.Name = "dtpTavozas";
            this.dtpTavozas.Size = new System.Drawing.Size(141, 20);
            this.dtpTavozas.TabIndex = 4;
            // 
            // btnKeres
            // 
            this.btnKeres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnKeres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKeres.ForeColor = System.Drawing.Color.Black;
            this.btnKeres.Location = new System.Drawing.Point(497, 77);
            this.btnKeres.Name = "btnKeres";
            this.btnKeres.Size = new System.Drawing.Size(176, 23);
            this.btnKeres.TabIndex = 5;
            this.btnKeres.Text = "Szabad szobák keresése";
            this.btnKeres.UseVisualStyleBackColor = false;
            // 
            // dgvTalalatok
            // 
            this.dgvTalalatok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTalalatok.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvTalalatok.Location = new System.Drawing.Point(12, 121);
            this.dgvTalalatok.Name = "dgvTalalatok";
            this.dgvTalalatok.Size = new System.Drawing.Size(661, 226);
            this.dgvTalalatok.TabIndex = 6;
            // 
            // lblJavaslat
            // 
            this.lblJavaslat.AutoSize = true;
            this.lblJavaslat.Location = new System.Drawing.Point(333, 77);
            this.lblJavaslat.Name = "lblJavaslat";
            this.lblJavaslat.Size = new System.Drawing.Size(148, 13);
            this.lblJavaslat.TabIndex = 7;
            this.lblJavaslat.Text = "Legközelebbi szabad időpont:";
            // 
            // btnAPEH
            // 
            this.btnAPEH.Location = new System.Drawing.Point(500, 353);
            this.btnAPEH.Name = "btnAPEH";
            this.btnAPEH.Size = new System.Drawing.Size(173, 24);
            this.btnAPEH.TabIndex = 8;
            this.btnAPEH.Text = "APEH lekérdezések →";
            this.btnAPEH.UseVisualStyleBackColor = true;
            this.btnAPEH.Click += new System.EventHandler(this.btnAPEH_Click_1);
            // 
            // Foglaláskezelő
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(685, 389);
            this.Controls.Add(this.btnAPEH);
            this.Controls.Add(this.lblJavaslat);
            this.Controls.Add(this.dgvTalalatok);
            this.Controls.Add(this.btnKeres);
            this.Controls.Add(this.dtpTavozas);
            this.Controls.Add(this.dtpErkezes);
            this.Controls.Add(this.lblTavozas);
            this.Controls.Add(this.lblErkezes);
            this.Controls.Add(this.lblTitle);
            this.Name = "Foglaláskezelő";
            this.Text = "Heaven Hotel";
            this.Load += new System.EventHandler(this.Foglaláskezelő_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTalalatok)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblErkezes;
        private System.Windows.Forms.Label lblTavozas;
        private System.Windows.Forms.DateTimePicker dtpErkezes;
        private System.Windows.Forms.DateTimePicker dtpTavozas;
        private System.Windows.Forms.Button btnKeres;
        private System.Windows.Forms.DataGridView dgvTalalatok;
        private System.Windows.Forms.Label lblJavaslat;
        private System.Windows.Forms.Button btnAPEH;
    }
}

