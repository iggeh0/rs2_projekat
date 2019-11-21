namespace RS2_Booking.Izdavac.WinUI.Administrator
{
    partial class frm_AdminSmjestaj
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_PretragaKorisnika = new System.Windows.Forms.Button();
            this.tb_KorisnickoIme = new System.Windows.Forms.TextBox();
            this.tb_IzdavacIme = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_PretragaSmjestaja = new System.Windows.Forms.Button();
            this.tb_SmjestajNaziv = new System.Windows.Forms.TextBox();
            this.cb_Grad = new System.Windows.Forms.ComboBox();
            this.btn_Nazad = new System.Windows.Forms.Button();
            this.dgv_Izdavac = new System.Windows.Forms.DataGridView();
            this.KorisnikId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KorisnickoIme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_Smjestaj = new System.Windows.Forms.DataGridView();
            this.SmjestajId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GradNaziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Izmjeni = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Ukloni = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Izdavac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Smjestaj)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_PretragaKorisnika);
            this.groupBox1.Controls.Add(this.tb_KorisnickoIme);
            this.groupBox1.Controls.Add(this.tb_IzdavacIme);
            this.groupBox1.Location = new System.Drawing.Point(59, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(651, 55);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pretraga izdavača";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Korisničko Ime";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ime";
            // 
            // btn_PretragaKorisnika
            // 
            this.btn_PretragaKorisnika.Location = new System.Drawing.Point(218, 33);
            this.btn_PretragaKorisnika.Name = "btn_PretragaKorisnika";
            this.btn_PretragaKorisnika.Size = new System.Drawing.Size(75, 23);
            this.btn_PretragaKorisnika.TabIndex = 2;
            this.btn_PretragaKorisnika.Text = "Pretraži";
            this.btn_PretragaKorisnika.UseVisualStyleBackColor = true;
            this.btn_PretragaKorisnika.Click += new System.EventHandler(this.btn_PretragaKorisnika_Click);
            // 
            // tb_KorisnickoIme
            // 
            this.tb_KorisnickoIme.Location = new System.Drawing.Point(112, 35);
            this.tb_KorisnickoIme.Name = "tb_KorisnickoIme";
            this.tb_KorisnickoIme.Size = new System.Drawing.Size(100, 20);
            this.tb_KorisnickoIme.TabIndex = 1;
            // 
            // tb_IzdavacIme
            // 
            this.tb_IzdavacIme.Location = new System.Drawing.Point(6, 35);
            this.tb_IzdavacIme.Name = "tb_IzdavacIme";
            this.tb_IzdavacIme.Size = new System.Drawing.Size(100, 20);
            this.tb_IzdavacIme.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btn_PretragaSmjestaja);
            this.groupBox2.Controls.Add(this.tb_SmjestajNaziv);
            this.groupBox2.Controls.Add(this.cb_Grad);
            this.groupBox2.Location = new System.Drawing.Point(59, 187);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(651, 55);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pretraga smještaja";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(133, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Naziv";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Grad";
            // 
            // btn_PretragaSmjestaja
            // 
            this.btn_PretragaSmjestaja.Location = new System.Drawing.Point(242, 31);
            this.btn_PretragaSmjestaja.Name = "btn_PretragaSmjestaja";
            this.btn_PretragaSmjestaja.Size = new System.Drawing.Size(75, 23);
            this.btn_PretragaSmjestaja.TabIndex = 2;
            this.btn_PretragaSmjestaja.Text = "Pretraži";
            this.btn_PretragaSmjestaja.UseVisualStyleBackColor = true;
            this.btn_PretragaSmjestaja.Click += new System.EventHandler(this.btn_PretragaSmjestaja_Click);
            // 
            // tb_SmjestajNaziv
            // 
            this.tb_SmjestajNaziv.Location = new System.Drawing.Point(133, 35);
            this.tb_SmjestajNaziv.Name = "tb_SmjestajNaziv";
            this.tb_SmjestajNaziv.Size = new System.Drawing.Size(100, 20);
            this.tb_SmjestajNaziv.TabIndex = 1;
            // 
            // cb_Grad
            // 
            this.cb_Grad.FormattingEnabled = true;
            this.cb_Grad.Location = new System.Drawing.Point(6, 34);
            this.cb_Grad.Name = "cb_Grad";
            this.cb_Grad.Size = new System.Drawing.Size(121, 21);
            this.cb_Grad.TabIndex = 0;
            // 
            // btn_Nazad
            // 
            this.btn_Nazad.Location = new System.Drawing.Point(338, 415);
            this.btn_Nazad.Name = "btn_Nazad";
            this.btn_Nazad.Size = new System.Drawing.Size(75, 23);
            this.btn_Nazad.TabIndex = 4;
            this.btn_Nazad.Text = "Nazad";
            this.btn_Nazad.UseVisualStyleBackColor = true;
            this.btn_Nazad.Click += new System.EventHandler(this.btn_Nazad_Click);
            // 
            // dgv_Izdavac
            // 
            this.dgv_Izdavac.AllowUserToAddRows = false;
            this.dgv_Izdavac.AllowUserToDeleteRows = false;
            this.dgv_Izdavac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Izdavac.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KorisnikId,
            this.KorisnickoIme,
            this.Ime,
            this.Prezime});
            this.dgv_Izdavac.Location = new System.Drawing.Point(59, 90);
            this.dgv_Izdavac.Name = "dgv_Izdavac";
            this.dgv_Izdavac.ReadOnly = true;
            this.dgv_Izdavac.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Izdavac.Size = new System.Drawing.Size(651, 81);
            this.dgv_Izdavac.TabIndex = 5;
            this.dgv_Izdavac.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Izdavac_CellContentClick);
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
            // dgv_Smjestaj
            // 
            this.dgv_Smjestaj.AllowUserToAddRows = false;
            this.dgv_Smjestaj.AllowUserToDeleteRows = false;
            this.dgv_Smjestaj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Smjestaj.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SmjestajId,
            this.Naziv,
            this.GradNaziv,
            this.Adresa,
            this.Izmjeni,
            this.Ukloni});
            this.dgv_Smjestaj.Location = new System.Drawing.Point(59, 248);
            this.dgv_Smjestaj.Name = "dgv_Smjestaj";
            this.dgv_Smjestaj.ReadOnly = true;
            this.dgv_Smjestaj.Size = new System.Drawing.Size(651, 140);
            this.dgv_Smjestaj.TabIndex = 1;
            this.dgv_Smjestaj.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Smjestaj_CellContentClick);
            // 
            // SmjestajId
            // 
            this.SmjestajId.DataPropertyName = "SmjestajId";
            this.SmjestajId.HeaderText = "SmjestajId";
            this.SmjestajId.Name = "SmjestajId";
            this.SmjestajId.ReadOnly = true;
            this.SmjestajId.Visible = false;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // GradNaziv
            // 
            this.GradNaziv.DataPropertyName = "GradNaziv";
            this.GradNaziv.HeaderText = "Grad";
            this.GradNaziv.Name = "GradNaziv";
            this.GradNaziv.ReadOnly = true;
            // 
            // Adresa
            // 
            this.Adresa.DataPropertyName = "Adresa";
            this.Adresa.HeaderText = "Adresa";
            this.Adresa.Name = "Adresa";
            this.Adresa.ReadOnly = true;
            // 
            // Izmjeni
            // 
            this.Izmjeni.HeaderText = "Izmjeni";
            this.Izmjeni.Name = "Izmjeni";
            this.Izmjeni.ReadOnly = true;
            this.Izmjeni.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Izmjeni.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
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
            // frm_AdminSmjestaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_Izdavac);
            this.Controls.Add(this.btn_Nazad);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_Smjestaj);
            this.Name = "frm_AdminSmjestaj";
            this.Text = "frm_AdminSmjestaj";
            this.Load += new System.EventHandler(this.frm_AdminSmjestaj_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Izdavac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Smjestaj)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_PretragaKorisnika;
        private System.Windows.Forms.TextBox tb_KorisnickoIme;
        private System.Windows.Forms.TextBox tb_IzdavacIme;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_PretragaSmjestaja;
        private System.Windows.Forms.TextBox tb_SmjestajNaziv;
        private System.Windows.Forms.ComboBox cb_Grad;
        private System.Windows.Forms.Button btn_Nazad;
        private System.Windows.Forms.DataGridView dgv_Izdavac;
        private System.Windows.Forms.DataGridViewTextBoxColumn KorisnikId;
        private System.Windows.Forms.DataGridViewTextBoxColumn KorisnickoIme;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridView dgv_Smjestaj;
        private System.Windows.Forms.DataGridViewTextBoxColumn SmjestajId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn GradNaziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adresa;
        private System.Windows.Forms.DataGridViewButtonColumn Izmjeni;
        private System.Windows.Forms.DataGridViewButtonColumn Ukloni;
    }
}