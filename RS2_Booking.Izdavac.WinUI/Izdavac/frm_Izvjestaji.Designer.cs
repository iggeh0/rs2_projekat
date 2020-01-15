namespace RS2_Booking.Izdavac.WinUI.Izdavac
{
    partial class frm_Izvjestaji
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
            this.dgv_Smjestaji = new System.Windows.Forms.DataGridView();
            this.NazivSmjestaja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojRezervacija2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zarada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_Klijenti = new System.Windows.Forms.DataGridView();
            this.ImePrezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KorisnickoIme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojRezervacija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Smjestaji)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Klijenti)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Smjestaji
            // 
            this.dgv_Smjestaji.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.dgv_Smjestaji.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Smjestaji.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Smjestaji.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NazivSmjestaja,
            this.BrojRezervacija2,
            this.Zarada});
            this.dgv_Smjestaji.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Smjestaji.Location = new System.Drawing.Point(3, 18);
            this.dgv_Smjestaji.Name = "dgv_Smjestaji";
            this.dgv_Smjestaji.Size = new System.Drawing.Size(349, 405);
            this.dgv_Smjestaji.TabIndex = 0;
            // 
            // NazivSmjestaja
            // 
            this.NazivSmjestaja.DataPropertyName = "NazivSmjestaja";
            this.NazivSmjestaja.HeaderText = "Naziv Smjestaja";
            this.NazivSmjestaja.Name = "NazivSmjestaja";
            // 
            // BrojRezervacija2
            // 
            this.BrojRezervacija2.DataPropertyName = "BrojRezervacija";
            this.BrojRezervacija2.HeaderText = "Broj Rezervacija";
            this.BrojRezervacija2.Name = "BrojRezervacija2";
            // 
            // Zarada
            // 
            this.Zarada.DataPropertyName = "Zarada";
            this.Zarada.HeaderText = "Zarada";
            this.Zarada.Name = "Zarada";
            // 
            // dgv_Klijenti
            // 
            this.dgv_Klijenti.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.dgv_Klijenti.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Klijenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Klijenti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ImePrezime,
            this.KorisnickoIme,
            this.BrojRezervacija});
            this.dgv_Klijenti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Klijenti.Location = new System.Drawing.Point(3, 18);
            this.dgv_Klijenti.Name = "dgv_Klijenti";
            this.dgv_Klijenti.Size = new System.Drawing.Size(409, 405);
            this.dgv_Klijenti.TabIndex = 1;
            // 
            // ImePrezime
            // 
            this.ImePrezime.DataPropertyName = "ImePrezime";
            this.ImePrezime.HeaderText = "Ime ";
            this.ImePrezime.Name = "ImePrezime";
            // 
            // KorisnickoIme
            // 
            this.KorisnickoIme.DataPropertyName = "KorisnickoIme";
            this.KorisnickoIme.HeaderText = "Korisnicko Ime";
            this.KorisnickoIme.Name = "KorisnickoIme";
            // 
            // BrojRezervacija
            // 
            this.BrojRezervacija.DataPropertyName = "BrojRezervacija";
            this.BrojRezervacija.HeaderText = "Broj Rezervacija";
            this.BrojRezervacija.Name = "BrojRezervacija";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_Smjestaji);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 426);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Najaktivniji smještaji";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_Klijenti);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(373, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(415, 426);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Najaktivniji klijenti";
            // 
            // frm_Izvjestaji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_Izvjestaji";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Izvještaji";
            this.Load += new System.EventHandler(this.frm_Izvjestaji_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Smjestaji)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Klijenti)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Smjestaji;
        private System.Windows.Forms.DataGridView dgv_Klijenti;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImePrezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn KorisnickoIme;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojRezervacija;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazivSmjestaja;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojRezervacija2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zarada;
    }
}