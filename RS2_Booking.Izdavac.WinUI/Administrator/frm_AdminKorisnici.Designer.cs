namespace RS2_Booking.Izdavac.WinUI.Administrator
{
    partial class frm_AdminKorisnici
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
            this.dgv_Korisnici = new System.Windows.Forms.DataGridView();
            this.KorisnikId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KorisnickoIme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Izmjeni = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Ukloni = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btn_DodajKorisnika = new System.Windows.Forms.Button();
            this.btn_Nazad = new System.Windows.Forms.Button();
            this.tb_Ime = new System.Windows.Forms.TextBox();
            this.tb_Prezime = new System.Windows.Forms.TextBox();
            this.tb_KorisnickoIme = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Pretraga = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Korisnici)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Korisnici
            // 
            this.dgv_Korisnici.AllowUserToAddRows = false;
            this.dgv_Korisnici.AllowUserToDeleteRows = false;
            this.dgv_Korisnici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Korisnici.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KorisnikId,
            this.KorisnickoIme,
            this.Ime,
            this.Prezime,
            this.Izmjeni,
            this.Ukloni});
            this.dgv_Korisnici.Location = new System.Drawing.Point(55, 102);
            this.dgv_Korisnici.Name = "dgv_Korisnici";
            this.dgv_Korisnici.ReadOnly = true;
            this.dgv_Korisnici.Size = new System.Drawing.Size(630, 249);
            this.dgv_Korisnici.TabIndex = 0;
            this.dgv_Korisnici.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Korisnici_CellContentClick);
            // 
            // KorisnikId
            // 
            this.KorisnikId.DataPropertyName = "KorisnikId";
            this.KorisnikId.HeaderText = "KorisnikId";
            this.KorisnikId.Name = "KorisnikId";
            this.KorisnikId.ReadOnly = true;
            this.KorisnikId.Visible = false;
            // 
            // KorisnickoIme
            // 
            this.KorisnickoIme.DataPropertyName = "KorisnickoIme";
            this.KorisnickoIme.HeaderText = "KorisnickoIme";
            this.KorisnickoIme.Name = "KorisnickoIme";
            this.KorisnickoIme.ReadOnly = true;
            // 
            // Ime
            // 
            this.Ime.DataPropertyName = "Ime";
            this.Ime.HeaderText = "Ime";
            this.Ime.Name = "Ime";
            this.Ime.ReadOnly = true;
            // 
            // Prezime
            // 
            this.Prezime.DataPropertyName = "Prezime";
            this.Prezime.HeaderText = "Prezime";
            this.Prezime.Name = "Prezime";
            this.Prezime.ReadOnly = true;
            // 
            // Izmjeni
            // 
            this.Izmjeni.HeaderText = "Izmjeni";
            this.Izmjeni.Name = "Izmjeni";
            this.Izmjeni.ReadOnly = true;
            this.Izmjeni.Text = "Izmjeni";
            this.Izmjeni.ToolTipText = "Izmjeni";
            this.Izmjeni.UseColumnTextForButtonValue = true;
            // 
            // Ukloni
            // 
            this.Ukloni.HeaderText = "Ukloni";
            this.Ukloni.Name = "Ukloni";
            this.Ukloni.ReadOnly = true;
            this.Ukloni.Text = "Ukloni";
            this.Ukloni.ToolTipText = "Ukloni";
            this.Ukloni.UseColumnTextForButtonValue = true;
            // 
            // btn_DodajKorisnika
            // 
            this.btn_DodajKorisnika.Location = new System.Drawing.Point(55, 359);
            this.btn_DodajKorisnika.Name = "btn_DodajKorisnika";
            this.btn_DodajKorisnika.Size = new System.Drawing.Size(141, 64);
            this.btn_DodajKorisnika.TabIndex = 1;
            this.btn_DodajKorisnika.Text = "Dodaj Korisnika";
            this.btn_DodajKorisnika.UseVisualStyleBackColor = true;
            this.btn_DodajKorisnika.Click += new System.EventHandler(this.btn_DodajKorisnika_Click);
            // 
            // btn_Nazad
            // 
            this.btn_Nazad.Location = new System.Drawing.Point(544, 359);
            this.btn_Nazad.Name = "btn_Nazad";
            this.btn_Nazad.Size = new System.Drawing.Size(141, 64);
            this.btn_Nazad.TabIndex = 2;
            this.btn_Nazad.Text = "Nazad";
            this.btn_Nazad.UseVisualStyleBackColor = true;
            this.btn_Nazad.Click += new System.EventHandler(this.btn_Nazad_Click);
            // 
            // tb_Ime
            // 
            this.tb_Ime.Location = new System.Drawing.Point(6, 47);
            this.tb_Ime.Name = "tb_Ime";
            this.tb_Ime.Size = new System.Drawing.Size(100, 20);
            this.tb_Ime.TabIndex = 3;
            // 
            // tb_Prezime
            // 
            this.tb_Prezime.Location = new System.Drawing.Point(112, 47);
            this.tb_Prezime.Name = "tb_Prezime";
            this.tb_Prezime.Size = new System.Drawing.Size(100, 20);
            this.tb_Prezime.TabIndex = 4;
            // 
            // tb_KorisnickoIme
            // 
            this.tb_KorisnickoIme.Location = new System.Drawing.Point(218, 47);
            this.tb_KorisnickoIme.Name = "tb_KorisnickoIme";
            this.tb_KorisnickoIme.Size = new System.Drawing.Size(100, 20);
            this.tb_KorisnickoIme.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ime";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Pretraga);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tb_Ime);
            this.groupBox1.Controls.Add(this.tb_KorisnickoIme);
            this.groupBox1.Controls.Add(this.tb_Prezime);
            this.groupBox1.Location = new System.Drawing.Point(55, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(630, 93);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pretraga Korisnika";
            // 
            // btn_Pretraga
            // 
            this.btn_Pretraga.Location = new System.Drawing.Point(9, 70);
            this.btn_Pretraga.Name = "btn_Pretraga";
            this.btn_Pretraga.Size = new System.Drawing.Size(75, 23);
            this.btn_Pretraga.TabIndex = 9;
            this.btn_Pretraga.Text = "Pretraga";
            this.btn_Pretraga.UseVisualStyleBackColor = true;
            this.btn_Pretraga.Click += new System.EventHandler(this.btn_Pretraga_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(215, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Korisnicko Ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Prezime";
            // 
            // frm_AdminKorisnici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Nazad);
            this.Controls.Add(this.btn_DodajKorisnika);
            this.Controls.Add(this.dgv_Korisnici);
            this.Name = "frm_AdminKorisnici";
            this.Text = "frm_AdminKorisnici";
            this.Load += new System.EventHandler(this.frm_AdminKorisnici_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Korisnici)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Korisnici;
        private System.Windows.Forms.Button btn_DodajKorisnika;
        private System.Windows.Forms.Button btn_Nazad;
        private System.Windows.Forms.TextBox tb_Ime;
        private System.Windows.Forms.TextBox tb_Prezime;
        private System.Windows.Forms.TextBox tb_KorisnickoIme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Pretraga;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn KorisnikId;
        private System.Windows.Forms.DataGridViewTextBoxColumn KorisnickoIme;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewButtonColumn Izmjeni;
        private System.Windows.Forms.DataGridViewButtonColumn Ukloni;
    }
}