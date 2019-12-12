namespace RS2_Booking.Izdavac.WinUI.Smjestaj
{
    partial class frm_Smjestaj
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gb_Smjestaj = new System.Windows.Forms.GroupBox();
            this.dgv_Smjestaj = new System.Windows.Forms.DataGridView();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GradNaziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Izmjeni = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Ukloni = new System.Windows.Forms.DataGridViewButtonColumn();
            this.SmjestajId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cb_GradPretraga = new System.Windows.Forms.ComboBox();
            this.tb_NazivPretraga = new System.Windows.Forms.TextBox();
            this.btn_Filtriraj = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.btn_Rezervacije = new System.Windows.Forms.Button();
            this.btn_Report = new System.Windows.Forms.Button();
            this.btn_UrediProfil = new System.Windows.Forms.Button();
            this.btn_DodajSmjestaj = new System.Windows.Forms.Button();
            this.gb_Smjestaj.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Smjestaj)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_Smjestaj
            // 
            this.gb_Smjestaj.Controls.Add(this.dgv_Smjestaj);
            this.gb_Smjestaj.Location = new System.Drawing.Point(73, 65);
            this.gb_Smjestaj.Name = "gb_Smjestaj";
            this.gb_Smjestaj.Size = new System.Drawing.Size(702, 373);
            this.gb_Smjestaj.TabIndex = 0;
            this.gb_Smjestaj.TabStop = false;
            this.gb_Smjestaj.Text = "Smještaji";
            // 
            // dgv_Smjestaj
            // 
            this.dgv_Smjestaj.AllowUserToAddRows = false;
            this.dgv_Smjestaj.AllowUserToDeleteRows = false;
            this.dgv_Smjestaj.AllowUserToResizeColumns = false;
            this.dgv_Smjestaj.AllowUserToResizeRows = false;
            this.dgv_Smjestaj.BackgroundColor = System.Drawing.SystemColors.Highlight;
            this.dgv_Smjestaj.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Smjestaj.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Smjestaj.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_Smjestaj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Smjestaj.ColumnHeadersVisible = false;
            this.dgv_Smjestaj.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Naziv,
            this.GradNaziv,
            this.Adresa,
            this.Izmjeni,
            this.Ukloni,
            this.SmjestajId});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Smjestaj.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_Smjestaj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Smjestaj.GridColor = System.Drawing.SystemColors.HotTrack;
            this.dgv_Smjestaj.Location = new System.Drawing.Point(3, 16);
            this.dgv_Smjestaj.MultiSelect = false;
            this.dgv_Smjestaj.Name = "dgv_Smjestaj";
            this.dgv_Smjestaj.ReadOnly = true;
            this.dgv_Smjestaj.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Smjestaj.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_Smjestaj.RowHeadersVisible = false;
            this.dgv_Smjestaj.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_Smjestaj.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_Smjestaj.Size = new System.Drawing.Size(696, 354);
            this.dgv_Smjestaj.TabIndex = 0;
            this.dgv_Smjestaj.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Smjestaj_CellClick);
            // 
            // Naziv
            // 
            this.Naziv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            this.Naziv.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // GradNaziv
            // 
            this.GradNaziv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GradNaziv.DataPropertyName = "GradNaziv";
            this.GradNaziv.HeaderText = "Grad";
            this.GradNaziv.Name = "GradNaziv";
            this.GradNaziv.ReadOnly = true;
            this.GradNaziv.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Adresa
            // 
            this.Adresa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Adresa.DataPropertyName = "Adresa";
            this.Adresa.HeaderText = "Adresa";
            this.Adresa.Name = "Adresa";
            this.Adresa.ReadOnly = true;
            this.Adresa.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Izmjeni
            // 
            this.Izmjeni.DataPropertyName = "Izmjeni";
            this.Izmjeni.HeaderText = "Izmjeni";
            this.Izmjeni.Name = "Izmjeni";
            this.Izmjeni.ReadOnly = true;
            this.Izmjeni.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Izmjeni.Text = "Izmjeni";
            this.Izmjeni.ToolTipText = "Izmjeni";
            this.Izmjeni.UseColumnTextForButtonValue = true;
            // 
            // Ukloni
            // 
            this.Ukloni.DataPropertyName = "Ukloni";
            this.Ukloni.HeaderText = "Ukloni";
            this.Ukloni.Name = "Ukloni";
            this.Ukloni.ReadOnly = true;
            this.Ukloni.Text = "Ukloni";
            this.Ukloni.ToolTipText = "Ukloni";
            this.Ukloni.UseColumnTextForButtonValue = true;
            // 
            // SmjestajId
            // 
            this.SmjestajId.DataPropertyName = "SmjestajId";
            this.SmjestajId.HeaderText = "SmjestajId";
            this.SmjestajId.Name = "SmjestajId";
            this.SmjestajId.ReadOnly = true;
            this.SmjestajId.Visible = false;
            // 
            // cb_GradPretraga
            // 
            this.cb_GradPretraga.FormattingEnabled = true;
            this.cb_GradPretraga.Location = new System.Drawing.Point(105, 22);
            this.cb_GradPretraga.Name = "cb_GradPretraga";
            this.cb_GradPretraga.Size = new System.Drawing.Size(121, 21);
            this.cb_GradPretraga.TabIndex = 1;
            // 
            // tb_NazivPretraga
            // 
            this.tb_NazivPretraga.Location = new System.Drawing.Point(238, 23);
            this.tb_NazivPretraga.Name = "tb_NazivPretraga";
            this.tb_NazivPretraga.Size = new System.Drawing.Size(100, 20);
            this.tb_NazivPretraga.TabIndex = 2;
            // 
            // btn_Filtriraj
            // 
            this.btn_Filtriraj.Location = new System.Drawing.Point(357, 20);
            this.btn_Filtriraj.Name = "btn_Filtriraj";
            this.btn_Filtriraj.Size = new System.Drawing.Size(75, 23);
            this.btn_Filtriraj.TabIndex = 3;
            this.btn_Filtriraj.Text = "Pretraži";
            this.btn_Filtriraj.UseVisualStyleBackColor = true;
            this.btn_Filtriraj.Click += new System.EventHandler(this.btn_Filtriraj_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.btn_Logout);
            this.panel1.Controls.Add(this.btn_Rezervacije);
            this.panel1.Controls.Add(this.btn_Report);
            this.panel1.Controls.Add(this.btn_UrediProfil);
            this.panel1.Controls.Add(this.btn_DodajSmjestaj);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(65, 451);
            this.panel1.TabIndex = 4;
            // 
            // btn_Logout
            // 
            this.btn_Logout.Location = new System.Drawing.Point(4, 349);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(50, 51);
            this.btn_Logout.TabIndex = 5;
            this.btn_Logout.Text = "Odjavi se";
            this.btn_Logout.UseVisualStyleBackColor = true;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // btn_Rezervacije
            // 
            this.btn_Rezervacije.Location = new System.Drawing.Point(4, 295);
            this.btn_Rezervacije.Name = "btn_Rezervacije";
            this.btn_Rezervacije.Size = new System.Drawing.Size(50, 50);
            this.btn_Rezervacije.TabIndex = 4;
            this.btn_Rezervacije.Text = "Rezervacije";
            this.btn_Rezervacije.UseVisualStyleBackColor = true;
            this.btn_Rezervacije.Click += new System.EventHandler(this.btn_Rezervacije_Click);
            // 
            // btn_Report
            // 
            this.btn_Report.Location = new System.Drawing.Point(4, 238);
            this.btn_Report.Name = "btn_Report";
            this.btn_Report.Size = new System.Drawing.Size(50, 51);
            this.btn_Report.TabIndex = 3;
            this.btn_Report.Text = "Izvještaji";
            this.btn_Report.UseVisualStyleBackColor = true;
            this.btn_Report.Click += new System.EventHandler(this.btn_Report_Click);
            // 
            // btn_UrediProfil
            // 
            this.btn_UrediProfil.Location = new System.Drawing.Point(4, 171);
            this.btn_UrediProfil.Name = "btn_UrediProfil";
            this.btn_UrediProfil.Size = new System.Drawing.Size(50, 51);
            this.btn_UrediProfil.TabIndex = 2;
            this.btn_UrediProfil.Text = "Uredi profil";
            this.btn_UrediProfil.UseVisualStyleBackColor = true;
            this.btn_UrediProfil.Click += new System.EventHandler(this.btn_UrediProfil_Click);
            // 
            // btn_DodajSmjestaj
            // 
            this.btn_DodajSmjestaj.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_DodajSmjestaj.FlatAppearance.BorderSize = 0;
            this.btn_DodajSmjestaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DodajSmjestaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DodajSmjestaj.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_DodajSmjestaj.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_DodajSmjestaj.Location = new System.Drawing.Point(4, 4);
            this.btn_DodajSmjestaj.Name = "btn_DodajSmjestaj";
            this.btn_DodajSmjestaj.Size = new System.Drawing.Size(58, 65);
            this.btn_DodajSmjestaj.TabIndex = 0;
            this.btn_DodajSmjestaj.Text = "+";
            this.btn_DodajSmjestaj.UseVisualStyleBackColor = true;
            this.btn_DodajSmjestaj.Click += new System.EventHandler(this.btn_DodajSmjestaj_Click);
            // 
            // frm_Smjestaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Filtriraj);
            this.Controls.Add(this.tb_NazivPretraga);
            this.Controls.Add(this.cb_GradPretraga);
            this.Controls.Add(this.gb_Smjestaj);
            this.Name = "frm_Smjestaj";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Index";
            this.Load += new System.EventHandler(this.frm_Smjestaj_Load);
            this.gb_Smjestaj.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Smjestaj)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Smjestaj;
        private System.Windows.Forms.DataGridView dgv_Smjestaj;
        private System.Windows.Forms.ComboBox cb_GradPretraga;
        private System.Windows.Forms.TextBox tb_NazivPretraga;
        private System.Windows.Forms.Button btn_Filtriraj;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn GradNaziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adresa;
        private System.Windows.Forms.DataGridViewButtonColumn Izmjeni;
        private System.Windows.Forms.DataGridViewButtonColumn Ukloni;
        private System.Windows.Forms.DataGridViewTextBoxColumn SmjestajId;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_DodajSmjestaj;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Button btn_Rezervacije;
        private System.Windows.Forms.Button btn_Report;
        private System.Windows.Forms.Button btn_UrediProfil;
    }
}