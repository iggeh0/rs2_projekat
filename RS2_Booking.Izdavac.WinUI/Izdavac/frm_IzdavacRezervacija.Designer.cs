namespace RS2_Booking.Izdavac.WinUI.Smjestaj
{
    partial class frm_IzdavacRezervacija
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
            this.dgv_Cekanje = new System.Windows.Forms.DataGridView();
            this.RezervacijaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NazivSmjestaja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdresaSmjestaja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumRezervacijeShort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RezervacijaOdShort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RezervacijaDoShort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojOdraslih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojDjece = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detaljnije = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_Aktivne = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgv_Zavrsene = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Cekanje)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Aktivne)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Zavrsene)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_Cekanje);
            this.groupBox1.Location = new System.Drawing.Point(31, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(957, 134);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rezervacije na čekanju";
            // 
            // dgv_Cekanje
            // 
            this.dgv_Cekanje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Cekanje.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RezervacijaId,
            this.NazivSmjestaja,
            this.AdresaSmjestaja,
            this.DatumRezervacijeShort,
            this.RezervacijaOdShort,
            this.RezervacijaDoShort,
            this.BrojOdraslih,
            this.BrojDjece,
            this.Detaljnije});
            this.dgv_Cekanje.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Cekanje.Location = new System.Drawing.Point(3, 16);
            this.dgv_Cekanje.Name = "dgv_Cekanje";
            this.dgv_Cekanje.Size = new System.Drawing.Size(951, 115);
            this.dgv_Cekanje.TabIndex = 0;
            this.dgv_Cekanje.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Cekanje_CellClick);
            // 
            // RezervacijaId
            // 
            this.RezervacijaId.DataPropertyName = "RezervacijaId";
            this.RezervacijaId.HeaderText = "RezervacijaId";
            this.RezervacijaId.Name = "RezervacijaId";
            // 
            // NazivSmjestaja
            // 
            this.NazivSmjestaja.DataPropertyName = "NazivSmjestaja";
            this.NazivSmjestaja.HeaderText = "Naziv Smjestaja";
            this.NazivSmjestaja.Name = "NazivSmjestaja";
            // 
            // AdresaSmjestaja
            // 
            this.AdresaSmjestaja.DataPropertyName = "AdresaSmjestaja";
            this.AdresaSmjestaja.HeaderText = "Adresa Smjestaja";
            this.AdresaSmjestaja.Name = "AdresaSmjestaja";
            // 
            // DatumRezervacijeShort
            // 
            this.DatumRezervacijeShort.DataPropertyName = "DatumRezervacijeShort";
            this.DatumRezervacijeShort.HeaderText = "Datum Rezervacije";
            this.DatumRezervacijeShort.Name = "DatumRezervacijeShort";
            // 
            // RezervacijaOdShort
            // 
            this.RezervacijaOdShort.DataPropertyName = "RezervacijaOdShort";
            this.RezervacijaOdShort.HeaderText = "Početak rezervacije";
            this.RezervacijaOdShort.Name = "RezervacijaOdShort";
            // 
            // RezervacijaDoShort
            // 
            this.RezervacijaDoShort.DataPropertyName = "RezervacijaDoShort";
            this.RezervacijaDoShort.HeaderText = "Završetak rezervacije";
            this.RezervacijaDoShort.Name = "RezervacijaDoShort";
            // 
            // BrojOdraslih
            // 
            this.BrojOdraslih.DataPropertyName = "BrojOdraslih";
            this.BrojOdraslih.HeaderText = "Broj Odraslih";
            this.BrojOdraslih.Name = "BrojOdraslih";
            // 
            // BrojDjece
            // 
            this.BrojDjece.DataPropertyName = "BrojDjece";
            this.BrojDjece.HeaderText = "Broj Djece";
            this.BrojDjece.Name = "BrojDjece";
            // 
            // Detaljnije
            // 
            this.Detaljnije.HeaderText = "Detaljnije";
            this.Detaljnije.Name = "Detaljnije";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(447, 475);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Nazad";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_Aktivne);
            this.groupBox2.Location = new System.Drawing.Point(31, 163);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(957, 134);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Aktivne rezervacije";
            // 
            // dgv_Aktivne
            // 
            this.dgv_Aktivne.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Aktivne.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewButtonColumn1});
            this.dgv_Aktivne.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Aktivne.Location = new System.Drawing.Point(3, 16);
            this.dgv_Aktivne.Name = "dgv_Aktivne";
            this.dgv_Aktivne.Size = new System.Drawing.Size(951, 115);
            this.dgv_Aktivne.TabIndex = 0;
            this.dgv_Aktivne.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Aktivne_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "RezervacijaId";
            this.dataGridViewTextBoxColumn1.HeaderText = "RezervacijaId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NazivSmjestaja";
            this.dataGridViewTextBoxColumn2.HeaderText = "Naziv Smjestaja";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "AdresaSmjestaja";
            this.dataGridViewTextBoxColumn3.HeaderText = "Adresa Smjestaja";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DatumRezervacijeShort";
            this.dataGridViewTextBoxColumn4.HeaderText = "Datum Rezervacije";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "RezervacijaOdShort";
            this.dataGridViewTextBoxColumn5.HeaderText = "Početak rezervacije";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "RezervacijaDoShort";
            this.dataGridViewTextBoxColumn6.HeaderText = "Završetak rezervacije";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "BrojOdraslih";
            this.dataGridViewTextBoxColumn7.HeaderText = "Broj Odraslih";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "BrojDjece";
            this.dataGridViewTextBoxColumn8.HeaderText = "Broj Djece";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.HeaderText = "Detaljnije";
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgv_Zavrsene);
            this.groupBox3.Location = new System.Drawing.Point(34, 303);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(957, 134);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Završene rezervacije";
            // 
            // dgv_Zavrsene
            // 
            this.dgv_Zavrsene.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Zavrsene.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewButtonColumn2});
            this.dgv_Zavrsene.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Zavrsene.Location = new System.Drawing.Point(3, 16);
            this.dgv_Zavrsene.Name = "dgv_Zavrsene";
            this.dgv_Zavrsene.Size = new System.Drawing.Size(951, 115);
            this.dgv_Zavrsene.TabIndex = 0;
            this.dgv_Zavrsene.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Zavrsene_CellClick);
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "RezervacijaId";
            this.dataGridViewTextBoxColumn9.HeaderText = "RezervacijaId";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "NazivSmjestaja";
            this.dataGridViewTextBoxColumn10.HeaderText = "Naziv Smjestaja";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "AdresaSmjestaja";
            this.dataGridViewTextBoxColumn11.HeaderText = "Adresa Smjestaja";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "DatumRezervacijeShort";
            this.dataGridViewTextBoxColumn12.HeaderText = "Datum Rezervacije";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "RezervacijaOdShort";
            this.dataGridViewTextBoxColumn13.HeaderText = "Početak rezervacije";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "RezervacijaDoShort";
            this.dataGridViewTextBoxColumn14.HeaderText = "Završetak rezervacije";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "BrojOdraslih";
            this.dataGridViewTextBoxColumn15.HeaderText = "Broj Odraslih";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "BrojDjece";
            this.dataGridViewTextBoxColumn16.HeaderText = "Broj Djece";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // dataGridViewButtonColumn2
            // 
            this.dataGridViewButtonColumn2.HeaderText = "Detaljnije";
            this.dataGridViewButtonColumn2.Name = "dataGridViewButtonColumn2";
            // 
            // frm_IzdavacRezervacija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 687);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.MinimumSize = new System.Drawing.Size(1024, 726);
            this.Name = "frm_IzdavacRezervacija";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rezervacije";
            this.Load += new System.EventHandler(this.frm_IzdavacRezervacija_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Cekanje)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Aktivne)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Zavrsene)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_Cekanje;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn RezervacijaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazivSmjestaja;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdresaSmjestaja;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumRezervacijeShort;
        private System.Windows.Forms.DataGridViewTextBoxColumn RezervacijaOdShort;
        private System.Windows.Forms.DataGridViewTextBoxColumn RezervacijaDoShort;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojOdraslih;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojDjece;
        private System.Windows.Forms.DataGridViewButtonColumn Detaljnije;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_Aktivne;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgv_Zavrsene;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn2;
    }
}