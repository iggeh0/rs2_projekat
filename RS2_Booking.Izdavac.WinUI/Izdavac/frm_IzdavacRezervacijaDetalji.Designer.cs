﻿namespace RS2_Booking.Izdavac.WinUI.Smjestaj
{
    partial class frm_IzdavacRezervacijaDetalji
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_ImePrezime = new System.Windows.Forms.Label();
            this.lbl_DatumKreiranja = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_DatumOd = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_DatumDo = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_Odrasli = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_Djeca = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btn_Prihvati = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_Uplate = new System.Windows.Forms.DataGridView();
            this.SifraUplate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Iznos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumUplate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_Ukupno = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lbl_SmjestajNaziv = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_Sobe = new System.Windows.Forms.DataGridView();
            this.VrstaSmjestaja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojKreveta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VlastitaKupaonica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_DodajUplatu = new System.Windows.Forms.Button();
            this.btn_Otkazi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_UplataIznos = new System.Windows.Forms.TextBox();
            this.btn_Zavrsi = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Uplate)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Sobe)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(33, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime i prezime klijenta";
            // 
            // lbl_ImePrezime
            // 
            this.lbl_ImePrezime.AutoSize = true;
            this.lbl_ImePrezime.ForeColor = System.Drawing.Color.White;
            this.lbl_ImePrezime.Location = new System.Drawing.Point(174, 33);
            this.lbl_ImePrezime.Name = "lbl_ImePrezime";
            this.lbl_ImePrezime.Size = new System.Drawing.Size(35, 13);
            this.lbl_ImePrezime.TabIndex = 1;
            this.lbl_ImePrezime.Text = "label2";
            // 
            // lbl_DatumKreiranja
            // 
            this.lbl_DatumKreiranja.AutoSize = true;
            this.lbl_DatumKreiranja.ForeColor = System.Drawing.Color.White;
            this.lbl_DatumKreiranja.Location = new System.Drawing.Point(174, 58);
            this.lbl_DatumKreiranja.Name = "lbl_DatumKreiranja";
            this.lbl_DatumKreiranja.Size = new System.Drawing.Size(35, 13);
            this.lbl_DatumKreiranja.TabIndex = 3;
            this.lbl_DatumKreiranja.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(33, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Datum kreiranja rezervacije";
            // 
            // lbl_DatumOd
            // 
            this.lbl_DatumOd.AutoSize = true;
            this.lbl_DatumOd.ForeColor = System.Drawing.Color.White;
            this.lbl_DatumOd.Location = new System.Drawing.Point(174, 83);
            this.lbl_DatumOd.Name = "lbl_DatumOd";
            this.lbl_DatumOd.Size = new System.Drawing.Size(35, 13);
            this.lbl_DatumOd.TabIndex = 5;
            this.lbl_DatumOd.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(33, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Datum početka rezervacije";
            // 
            // lbl_DatumDo
            // 
            this.lbl_DatumDo.AutoSize = true;
            this.lbl_DatumDo.ForeColor = System.Drawing.Color.White;
            this.lbl_DatumDo.Location = new System.Drawing.Point(174, 108);
            this.lbl_DatumDo.Name = "lbl_DatumDo";
            this.lbl_DatumDo.Size = new System.Drawing.Size(35, 13);
            this.lbl_DatumDo.TabIndex = 7;
            this.lbl_DatumDo.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(33, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Datum završetka rezervacije";
            // 
            // lbl_Odrasli
            // 
            this.lbl_Odrasli.AutoSize = true;
            this.lbl_Odrasli.ForeColor = System.Drawing.Color.White;
            this.lbl_Odrasli.Location = new System.Drawing.Point(174, 131);
            this.lbl_Odrasli.Name = "lbl_Odrasli";
            this.lbl_Odrasli.Size = new System.Drawing.Size(35, 13);
            this.lbl_Odrasli.TabIndex = 9;
            this.lbl_Odrasli.Text = "label9";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(33, 131);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Broj odraslih osoba";
            // 
            // lbl_Djeca
            // 
            this.lbl_Djeca.AutoSize = true;
            this.lbl_Djeca.ForeColor = System.Drawing.Color.White;
            this.lbl_Djeca.Location = new System.Drawing.Point(174, 155);
            this.lbl_Djeca.Name = "lbl_Djeca";
            this.lbl_Djeca.Size = new System.Drawing.Size(41, 13);
            this.lbl_Djeca.TabIndex = 11;
            this.lbl_Djeca.Text = "label11";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(33, 155);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Broj djece";
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.ForeColor = System.Drawing.Color.White;
            this.lbl_Status.Location = new System.Drawing.Point(174, 179);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(41, 13);
            this.lbl_Status.TabIndex = 13;
            this.lbl_Status.Text = "label13";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(33, 179);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(91, 13);
            this.label14.TabIndex = 12;
            this.label14.Text = "Status rezervacije";
            // 
            // btn_Prihvati
            // 
            this.btn_Prihvati.BackColor = System.Drawing.Color.Green;
            this.btn_Prihvati.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btn_Prihvati.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btn_Prihvati.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btn_Prihvati.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Prihvati.ForeColor = System.Drawing.Color.White;
            this.btn_Prihvati.Location = new System.Drawing.Point(36, 236);
            this.btn_Prihvati.Name = "btn_Prihvati";
            this.btn_Prihvati.Size = new System.Drawing.Size(75, 23);
            this.btn_Prihvati.TabIndex = 14;
            this.btn_Prihvati.Text = "Prihvati";
            this.btn_Prihvati.UseVisualStyleBackColor = false;
            this.btn_Prihvati.Visible = false;
            this.btn_Prihvati.Click += new System.EventHandler(this.btn_Prihvati_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_Uplate);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(264, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(465, 109);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Uplate";
            // 
            // dgv_Uplate
            // 
            this.dgv_Uplate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Uplate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SifraUplate,
            this.Iznos,
            this.DatumUplate});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Uplate.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Uplate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Uplate.Location = new System.Drawing.Point(3, 16);
            this.dgv_Uplate.Name = "dgv_Uplate";
            this.dgv_Uplate.Size = new System.Drawing.Size(459, 90);
            this.dgv_Uplate.TabIndex = 0;
            // 
            // SifraUplate
            // 
            this.SifraUplate.DataPropertyName = "SifraUplate";
            this.SifraUplate.HeaderText = "Sifra Uplate";
            this.SifraUplate.Name = "SifraUplate";
            // 
            // Iznos
            // 
            this.Iznos.DataPropertyName = "Iznos";
            this.Iznos.HeaderText = "Iznos";
            this.Iznos.Name = "Iznos";
            // 
            // DatumUplate
            // 
            this.DatumUplate.DataPropertyName = "DatumUplate";
            this.DatumUplate.HeaderText = "Datum Uplate";
            this.DatumUplate.Name = "DatumUplate";
            // 
            // lbl_Ukupno
            // 
            this.lbl_Ukupno.AutoSize = true;
            this.lbl_Ukupno.ForeColor = System.Drawing.Color.White;
            this.lbl_Ukupno.Location = new System.Drawing.Point(365, 155);
            this.lbl_Ukupno.Name = "lbl_Ukupno";
            this.lbl_Ukupno.Size = new System.Drawing.Size(41, 13);
            this.lbl_Ukupno.TabIndex = 17;
            this.lbl_Ukupno.Text = "label15";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(264, 155);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(95, 13);
            this.label16.TabIndex = 16;
            this.label16.Text = "Ukupno uplaćeno:";
            // 
            // lbl_SmjestajNaziv
            // 
            this.lbl_SmjestajNaziv.AutoSize = true;
            this.lbl_SmjestajNaziv.ForeColor = System.Drawing.Color.White;
            this.lbl_SmjestajNaziv.Location = new System.Drawing.Point(150, 286);
            this.lbl_SmjestajNaziv.Name = "lbl_SmjestajNaziv";
            this.lbl_SmjestajNaziv.Size = new System.Drawing.Size(41, 13);
            this.lbl_SmjestajNaziv.TabIndex = 19;
            this.lbl_SmjestajNaziv.Text = "label17";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(9, 286);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(100, 13);
            this.label18.TabIndex = 18;
            this.label18.Text = "Rezervisan smještaj";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_Sobe);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(12, 302);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(774, 136);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rezervisane sobe";
            // 
            // dgv_Sobe
            // 
            this.dgv_Sobe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Sobe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VrstaSmjestaja,
            this.Opis,
            this.BrojKreveta,
            this.Cijena,
            this.VlastitaKupaonica});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Sobe.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_Sobe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Sobe.Location = new System.Drawing.Point(3, 16);
            this.dgv_Sobe.Name = "dgv_Sobe";
            this.dgv_Sobe.Size = new System.Drawing.Size(768, 117);
            this.dgv_Sobe.TabIndex = 0;
            // 
            // VrstaSmjestaja
            // 
            this.VrstaSmjestaja.DataPropertyName = "VrstaSmjestaja";
            this.VrstaSmjestaja.HeaderText = "Vrsta Smještaja";
            this.VrstaSmjestaja.Name = "VrstaSmjestaja";
            // 
            // Opis
            // 
            this.Opis.DataPropertyName = "Opis";
            this.Opis.HeaderText = "Opis";
            this.Opis.Name = "Opis";
            // 
            // BrojKreveta
            // 
            this.BrojKreveta.DataPropertyName = "BrojKreveta";
            this.BrojKreveta.HeaderText = "Broj Kreveta";
            this.BrojKreveta.Name = "BrojKreveta";
            // 
            // Cijena
            // 
            this.Cijena.DataPropertyName = "Cijena";
            this.Cijena.HeaderText = "Cijena";
            this.Cijena.Name = "Cijena";
            // 
            // VlastitaKupaonica
            // 
            this.VlastitaKupaonica.DataPropertyName = "VlastitaKupoanica";
            this.VlastitaKupaonica.HeaderText = "VlastitaKupoanica";
            this.VlastitaKupaonica.Name = "VlastitaKupaonica";
            // 
            // btn_DodajUplatu
            // 
            this.btn_DodajUplatu.BackColor = System.Drawing.Color.Green;
            this.btn_DodajUplatu.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btn_DodajUplatu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btn_DodajUplatu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btn_DodajUplatu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DodajUplatu.ForeColor = System.Drawing.Color.White;
            this.btn_DodajUplatu.Location = new System.Drawing.Point(267, 210);
            this.btn_DodajUplatu.Name = "btn_DodajUplatu";
            this.btn_DodajUplatu.Size = new System.Drawing.Size(75, 23);
            this.btn_DodajUplatu.TabIndex = 21;
            this.btn_DodajUplatu.Text = "Dodaj uplatu";
            this.btn_DodajUplatu.UseVisualStyleBackColor = false;
            this.btn_DodajUplatu.Click += new System.EventHandler(this.btn_DodajUplatu_Click);
            // 
            // btn_Otkazi
            // 
            this.btn_Otkazi.BackColor = System.Drawing.Color.Red;
            this.btn_Otkazi.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_Otkazi.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.btn_Otkazi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_Otkazi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_Otkazi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Otkazi.ForeColor = System.Drawing.Color.White;
            this.btn_Otkazi.Location = new System.Drawing.Point(36, 236);
            this.btn_Otkazi.Name = "btn_Otkazi";
            this.btn_Otkazi.Size = new System.Drawing.Size(75, 23);
            this.btn_Otkazi.TabIndex = 22;
            this.btn_Otkazi.Text = "Otkazi";
            this.btn_Otkazi.UseVisualStyleBackColor = false;
            this.btn_Otkazi.Visible = false;
            this.btn_Otkazi.Click += new System.EventHandler(this.btn_Otkazi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(264, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Uplaceni iznos:";
            // 
            // tb_UplataIznos
            // 
            this.tb_UplataIznos.Location = new System.Drawing.Point(352, 181);
            this.tb_UplataIznos.Name = "tb_UplataIznos";
            this.tb_UplataIznos.Size = new System.Drawing.Size(100, 20);
            this.tb_UplataIznos.TabIndex = 24;
            // 
            // btn_Zavrsi
            // 
            this.btn_Zavrsi.BackColor = System.Drawing.Color.Red;
            this.btn_Zavrsi.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_Zavrsi.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.btn_Zavrsi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_Zavrsi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_Zavrsi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Zavrsi.ForeColor = System.Drawing.Color.White;
            this.btn_Zavrsi.Location = new System.Drawing.Point(36, 235);
            this.btn_Zavrsi.Name = "btn_Zavrsi";
            this.btn_Zavrsi.Size = new System.Drawing.Size(75, 23);
            this.btn_Zavrsi.TabIndex = 25;
            this.btn_Zavrsi.Text = "Zavrsi";
            this.btn_Zavrsi.UseVisualStyleBackColor = false;
            this.btn_Zavrsi.Visible = false;
            this.btn_Zavrsi.Click += new System.EventHandler(this.btn_Zavrsi_Click);
            // 
            // frm_IzdavacRezervacijaDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Zavrsi);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tb_UplataIznos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Otkazi);
            this.Controls.Add(this.btn_DodajUplatu);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lbl_SmjestajNaziv);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.lbl_Ukupno);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.btn_Prihvati);
            this.Controls.Add(this.lbl_Status);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lbl_Djeca);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lbl_Odrasli);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lbl_DatumDo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbl_DatumOd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_DatumKreiranja);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_ImePrezime);
            this.Controls.Add(this.label1);
            this.Name = "frm_IzdavacRezervacijaDetalji";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rezervacija Detalji";
            this.Load += new System.EventHandler(this.frm_IzdavacRezervacijaDetalji_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Uplate)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Sobe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_ImePrezime;
        private System.Windows.Forms.Label lbl_DatumKreiranja;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_DatumOd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_DatumDo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_Odrasli;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl_Djeca;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btn_Prihvati;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_Uplate;
        private System.Windows.Forms.Label lbl_Ukupno;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lbl_SmjestajNaziv;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_DodajUplatu;
        private System.Windows.Forms.Button btn_Otkazi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_UplataIznos;
        private System.Windows.Forms.Button btn_Zavrsi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SifraUplate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Iznos;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumUplate;
        private System.Windows.Forms.DataGridViewTextBoxColumn VrstaSmjestaja;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opis;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojKreveta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn VlastitaKupaonica;
        private System.Windows.Forms.DataGridView dgv_Sobe;
    }
}