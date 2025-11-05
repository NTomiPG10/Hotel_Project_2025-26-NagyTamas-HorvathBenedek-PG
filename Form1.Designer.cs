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
            this.btnFoglalas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
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
            this.dtpErkezes.ValueChanged += new System.EventHandler(this.dtpErkezes_ValueChanged);
            // 
            // dtpTavozas
            // 
            this.dtpTavozas.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTavozas.Location = new System.Drawing.Point(171, 78);
            this.dtpTavozas.Name = "dtpTavozas";
            this.dtpTavozas.Size = new System.Drawing.Size(141, 20);
            this.dtpTavozas.TabIndex = 4;
            this.dtpTavozas.ValueChanged += new System.EventHandler(this.dtpTavozas_ValueChanged);
            // 
            // btnKeres
            // 
            this.btnKeres.BackColor = System.Drawing.Color.LightGreen;
            this.btnKeres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKeres.ForeColor = System.Drawing.Color.Black;
            this.btnKeres.Location = new System.Drawing.Point(518, 75);
            this.btnKeres.Name = "btnKeres";
            this.btnKeres.Size = new System.Drawing.Size(176, 23);
            this.btnKeres.TabIndex = 5;
            this.btnKeres.Text = "Szabad szobák keresése";
            this.btnKeres.UseVisualStyleBackColor = false;
            this.btnKeres.Click += new System.EventHandler(this.btnKeres_Click);
            // 
            // dgvTalalatok
            // 
            this.dgvTalalatok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTalalatok.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvTalalatok.Location = new System.Drawing.Point(12, 121);
            this.dgvTalalatok.Name = "dgvTalalatok";
            this.dgvTalalatok.Size = new System.Drawing.Size(682, 226);
            this.dgvTalalatok.TabIndex = 6;
            this.dgvTalalatok.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTalalatok_CellContentClick);
            // 
            // lblJavaslat
            // 
            this.lblJavaslat.AutoSize = true;
            this.lblJavaslat.Location = new System.Drawing.Point(344, 62);
            this.lblJavaslat.Name = "lblJavaslat";
            this.lblJavaslat.Size = new System.Drawing.Size(148, 13);
            this.lblJavaslat.TabIndex = 7;
            this.lblJavaslat.Text = "Legközelebbi szabad időpont:";
            // 
            // btnAPEH
            // 
            this.btnAPEH.Location = new System.Drawing.Point(521, 353);
            this.btnAPEH.Name = "btnAPEH";
            this.btnAPEH.Size = new System.Drawing.Size(173, 24);
            this.btnAPEH.TabIndex = 8;
            this.btnAPEH.Text = "APEH lekérdezések →";
            this.btnAPEH.UseVisualStyleBackColor = true;
            this.btnAPEH.Click += new System.EventHandler(this.btnAPEH_Click_1);
            // 
            // btnFoglalas
            // 
            this.btnFoglalas.Location = new System.Drawing.Point(13, 353);
            this.btnFoglalas.Name = "btnFoglalas";
            this.btnFoglalas.Size = new System.Drawing.Size(168, 23);
            this.btnFoglalas.TabIndex = 9;
            this.btnFoglalas.Text = "Foglalás";
            this.btnFoglalas.UseVisualStyleBackColor = true;
            this.btnFoglalas.Click += new System.EventHandler(this.btnFoglalas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(327, 84);
            this.label1.MaximumSize = new System.Drawing.Size(185, 30);
            this.label1.MinimumSize = new System.Drawing.Size(185, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 30);
            this.label1.TabIndex = 10;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // Foglaláskezelő
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(706, 389);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFoglalas);
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
        private System.Windows.Forms.Button btnFoglalas;
        private System.Windows.Forms.Label label1;
    }
}

