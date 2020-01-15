namespace RS2_Booking.Izdavac.WinUI.Smjestaj
{
    partial class frm_SmjestajOkoline
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
            this.dgv_Okolina = new System.Windows.Forms.DataGridView();
            this.OkolinaSmjestajId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OkolinaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Udaljenost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ukloni = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_DodajNovo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_NovaUdaljenost = new System.Windows.Forms.TextBox();
            this.tb_NovaNaziv = new System.Windows.Forms.TextBox();
            this.cb_PostojecaNaziv = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_DodajPostojece = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_PostojecaUdaljenost = new System.Windows.Forms.TextBox();
            this.lbl_novaNazivErr = new System.Windows.Forms.Label();
            this.lbl_novaUdaljenostErr = new System.Windows.Forms.Label();
            this.lbl_postojecaUdaljenaErr = new System.Windows.Forms.Label();
            this.btn_Nazad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Okolina)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Okolina
            // 
            this.dgv_Okolina.AllowUserToAddRows = false;
            this.dgv_Okolina.AllowUserToDeleteRows = false;
            this.dgv_Okolina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Okolina.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OkolinaSmjestajId,
            this.OkolinaId,
            this.Naziv,
            this.Udaljenost,
            this.Ukloni});
            this.dgv_Okolina.Location = new System.Drawing.Point(53, 140);
            this.dgv_Okolina.Name = "dgv_Okolina";
            this.dgv_Okolina.ReadOnly = true;
            this.dgv_Okolina.Size = new System.Drawing.Size(618, 150);
            this.dgv_Okolina.TabIndex = 0;
            this.dgv_Okolina.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Okolina_CellContentClick);
            // 
            // OkolinaSmjestajId
            // 
            this.OkolinaSmjestajId.DataPropertyName = "OkolinaSmjestajId";
            this.OkolinaSmjestajId.HeaderText = "OkolinaSmjestajId";
            this.OkolinaSmjestajId.Name = "OkolinaSmjestajId";
            this.OkolinaSmjestajId.ReadOnly = true;
            this.OkolinaSmjestajId.Visible = false;
            // 
            // OkolinaId
            // 
            this.OkolinaId.DataPropertyName = "OkolinaId";
            this.OkolinaId.HeaderText = "OkolinaId";
            this.OkolinaId.Name = "OkolinaId";
            this.OkolinaId.ReadOnly = true;
            this.OkolinaId.Visible = false;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // Udaljenost
            // 
            this.Udaljenost.DataPropertyName = "Udaljenost";
            this.Udaljenost.HeaderText = "Udaljenost";
            this.Udaljenost.Name = "Udaljenost";
            this.Udaljenost.ReadOnly = true;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(50, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Okolna mjesta";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_DodajNovo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tb_NovaUdaljenost);
            this.groupBox1.Controls.Add(this.tb_NovaNaziv);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(53, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dodaj novo okolno mjesto";
            // 
            // btn_DodajNovo
            // 
            this.btn_DodajNovo.BackColor = System.Drawing.Color.Green;
            this.btn_DodajNovo.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btn_DodajNovo.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btn_DodajNovo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_DodajNovo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_DodajNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DodajNovo.Location = new System.Drawing.Point(9, 71);
            this.btn_DodajNovo.Name = "btn_DodajNovo";
            this.btn_DodajNovo.Size = new System.Drawing.Size(75, 23);
            this.btn_DodajNovo.TabIndex = 4;
            this.btn_DodajNovo.Text = "Dodaj";
            this.btn_DodajNovo.UseVisualStyleBackColor = false;
            this.btn_DodajNovo.Click += new System.EventHandler(this.btn_DodajNovo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Udaljenost (km)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Naziv";
            // 
            // tb_NovaUdaljenost
            // 
            this.tb_NovaUdaljenost.Location = new System.Drawing.Point(94, 45);
            this.tb_NovaUdaljenost.Name = "tb_NovaUdaljenost";
            this.tb_NovaUdaljenost.Size = new System.Drawing.Size(100, 20);
            this.tb_NovaUdaljenost.TabIndex = 1;
            // 
            // tb_NovaNaziv
            // 
            this.tb_NovaNaziv.Location = new System.Drawing.Point(94, 19);
            this.tb_NovaNaziv.Name = "tb_NovaNaziv";
            this.tb_NovaNaziv.Size = new System.Drawing.Size(100, 20);
            this.tb_NovaNaziv.TabIndex = 0;
            // 
            // cb_PostojecaNaziv
            // 
            this.cb_PostojecaNaziv.FormattingEnabled = true;
            this.cb_PostojecaNaziv.Location = new System.Drawing.Point(92, 23);
            this.cb_PostojecaNaziv.MaxDropDownItems = 20;
            this.cb_PostojecaNaziv.Name = "cb_PostojecaNaziv";
            this.cb_PostojecaNaziv.Size = new System.Drawing.Size(121, 21);
            this.cb_PostojecaNaziv.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_DodajPostojece);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tb_PostojecaUdaljenost);
            this.groupBox2.Controls.Add(this.cb_PostojecaNaziv);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(422, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(217, 100);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dodaj postojeće okolno mjesto";
            // 
            // btn_DodajPostojece
            // 
            this.btn_DodajPostojece.BackColor = System.Drawing.Color.Green;
            this.btn_DodajPostojece.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btn_DodajPostojece.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btn_DodajPostojece.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_DodajPostojece.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_DodajPostojece.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DodajPostojece.Location = new System.Drawing.Point(6, 68);
            this.btn_DodajPostojece.Name = "btn_DodajPostojece";
            this.btn_DodajPostojece.Size = new System.Drawing.Size(75, 23);
            this.btn_DodajPostojece.TabIndex = 7;
            this.btn_DodajPostojece.Text = "Dodaj";
            this.btn_DodajPostojece.UseVisualStyleBackColor = false;
            this.btn_DodajPostojece.Click += new System.EventHandler(this.btn_DodajPostojece_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(11, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Naziv";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(7, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Udaljenost (km)";
            // 
            // tb_PostojecaUdaljenost
            // 
            this.tb_PostojecaUdaljenost.Location = new System.Drawing.Point(92, 52);
            this.tb_PostojecaUdaljenost.Name = "tb_PostojecaUdaljenost";
            this.tb_PostojecaUdaljenost.Size = new System.Drawing.Size(121, 20);
            this.tb_PostojecaUdaljenost.TabIndex = 4;
            // 
            // lbl_novaNazivErr
            // 
            this.lbl_novaNazivErr.AutoSize = true;
            this.lbl_novaNazivErr.BackColor = System.Drawing.Color.DodgerBlue;
            this.lbl_novaNazivErr.ForeColor = System.Drawing.Color.Red;
            this.lbl_novaNazivErr.Location = new System.Drawing.Point(259, 34);
            this.lbl_novaNazivErr.Name = "lbl_novaNazivErr";
            this.lbl_novaNazivErr.Size = new System.Drawing.Size(35, 13);
            this.lbl_novaNazivErr.TabIndex = 5;
            this.lbl_novaNazivErr.Text = "label6";
            this.lbl_novaNazivErr.Visible = false;
            // 
            // lbl_novaUdaljenostErr
            // 
            this.lbl_novaUdaljenostErr.AutoSize = true;
            this.lbl_novaUdaljenostErr.BackColor = System.Drawing.Color.DodgerBlue;
            this.lbl_novaUdaljenostErr.ForeColor = System.Drawing.Color.Red;
            this.lbl_novaUdaljenostErr.Location = new System.Drawing.Point(259, 57);
            this.lbl_novaUdaljenostErr.Name = "lbl_novaUdaljenostErr";
            this.lbl_novaUdaljenostErr.Size = new System.Drawing.Size(35, 13);
            this.lbl_novaUdaljenostErr.TabIndex = 6;
            this.lbl_novaUdaljenostErr.Text = "label7";
            this.lbl_novaUdaljenostErr.Visible = false;
            // 
            // lbl_postojecaUdaljenaErr
            // 
            this.lbl_postojecaUdaljenaErr.AutoSize = true;
            this.lbl_postojecaUdaljenaErr.BackColor = System.Drawing.Color.DodgerBlue;
            this.lbl_postojecaUdaljenaErr.ForeColor = System.Drawing.Color.Red;
            this.lbl_postojecaUdaljenaErr.Location = new System.Drawing.Point(645, 64);
            this.lbl_postojecaUdaljenaErr.Name = "lbl_postojecaUdaljenaErr";
            this.lbl_postojecaUdaljenaErr.Size = new System.Drawing.Size(35, 13);
            this.lbl_postojecaUdaljenaErr.TabIndex = 7;
            this.lbl_postojecaUdaljenaErr.Text = "label8";
            this.lbl_postojecaUdaljenaErr.Visible = false;
            // 
            // btn_Nazad
            // 
            this.btn_Nazad.BackColor = System.Drawing.Color.Red;
            this.btn_Nazad.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_Nazad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Nazad.ForeColor = System.Drawing.Color.White;
            this.btn_Nazad.Location = new System.Drawing.Point(307, 300);
            this.btn_Nazad.Name = "btn_Nazad";
            this.btn_Nazad.Size = new System.Drawing.Size(75, 23);
            this.btn_Nazad.TabIndex = 8;
            this.btn_Nazad.Text = "Nazad";
            this.btn_Nazad.UseVisualStyleBackColor = false;
            this.btn_Nazad.Click += new System.EventHandler(this.btn_Nazad_Click);
            // 
            // frm_SmjestajOkoline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(703, 335);
            this.Controls.Add(this.btn_Nazad);
            this.Controls.Add(this.lbl_postojecaUdaljenaErr);
            this.Controls.Add(this.lbl_novaUdaljenostErr);
            this.Controls.Add(this.lbl_novaNazivErr);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_Okolina);
            this.Name = "frm_SmjestajOkoline";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uredi Okoline Smještaja";
            this.Load += new System.EventHandler(this.frm_SmjestajOkoline_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Okolina)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Okolina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_NovaUdaljenost;
        private System.Windows.Forms.TextBox tb_NovaNaziv;
        private System.Windows.Forms.ComboBox cb_PostojecaNaziv;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_PostojecaUdaljenost;
        private System.Windows.Forms.Button btn_DodajNovo;
        private System.Windows.Forms.Button btn_DodajPostojece;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn OkolinaSmjestajId;
        private System.Windows.Forms.DataGridViewTextBoxColumn OkolinaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Udaljenost;
        private System.Windows.Forms.DataGridViewButtonColumn Ukloni;
        private System.Windows.Forms.Label lbl_novaNazivErr;
        private System.Windows.Forms.Label lbl_novaUdaljenostErr;
        private System.Windows.Forms.Label lbl_postojecaUdaljenaErr;
        private System.Windows.Forms.Button btn_Nazad;
    }
}