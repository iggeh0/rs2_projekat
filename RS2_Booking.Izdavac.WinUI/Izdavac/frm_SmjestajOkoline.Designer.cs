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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_NovaUdaljenost = new System.Windows.Forms.TextBox();
            this.tb_NovaNaziv = new System.Windows.Forms.TextBox();
            this.cb_PostojecaNaziv = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_PostojecaUdaljenost = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_DodajNovo = new System.Windows.Forms.Button();
            this.btn_DodajPostojece = new System.Windows.Forms.Button();
            this.OkolinaSmjestajId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Udaljenost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ukloni = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Okolina)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Okolina
            // 
            this.dgv_Okolina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Okolina.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OkolinaSmjestajId,
            this.Naziv,
            this.Udaljenost,
            this.Ukloni});
            this.dgv_Okolina.Location = new System.Drawing.Point(53, 140);
            this.dgv_Okolina.Name = "dgv_Okolina";
            this.dgv_Okolina.Size = new System.Drawing.Size(618, 150);
            this.dgv_Okolina.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(319, 113);
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
            this.groupBox1.Location = new System.Drawing.Point(53, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dodaj novo okolno mjesto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Udaljenost";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
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
            this.cb_PostojecaNaziv.Location = new System.Drawing.Point(73, 19);
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
            this.groupBox2.Location = new System.Drawing.Point(422, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dodaj postojeće okolno mjesto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Udaljenost";
            // 
            // tb_PostojecaUdaljenost
            // 
            this.tb_PostojecaUdaljenost.Location = new System.Drawing.Point(73, 52);
            this.tb_PostojecaUdaljenost.Name = "tb_PostojecaUdaljenost";
            this.tb_PostojecaUdaljenost.Size = new System.Drawing.Size(121, 20);
            this.tb_PostojecaUdaljenost.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Naziv";
            // 
            // btn_DodajNovo
            // 
            this.btn_DodajNovo.Location = new System.Drawing.Point(9, 71);
            this.btn_DodajNovo.Name = "btn_DodajNovo";
            this.btn_DodajNovo.Size = new System.Drawing.Size(75, 23);
            this.btn_DodajNovo.TabIndex = 4;
            this.btn_DodajNovo.Text = "Dodaj";
            this.btn_DodajNovo.UseVisualStyleBackColor = true;
            this.btn_DodajNovo.Click += new System.EventHandler(this.btn_DodajNovo_Click);
            // 
            // btn_DodajPostojece
            // 
            this.btn_DodajPostojece.Location = new System.Drawing.Point(6, 77);
            this.btn_DodajPostojece.Name = "btn_DodajPostojece";
            this.btn_DodajPostojece.Size = new System.Drawing.Size(75, 23);
            this.btn_DodajPostojece.TabIndex = 7;
            this.btn_DodajPostojece.Text = "Dodaj";
            this.btn_DodajPostojece.UseVisualStyleBackColor = true;
            // 
            // OkolinaSmjestajId
            // 
            this.OkolinaSmjestajId.DataPropertyName = "OkolinaSmjestajId";
            this.OkolinaSmjestajId.HeaderText = "Column1";
            this.OkolinaSmjestajId.Name = "OkolinaSmjestajId";
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            // 
            // Udaljenost
            // 
            this.Udaljenost.DataPropertyName = "Udaljenost";
            this.Udaljenost.HeaderText = "Udaljenost";
            this.Udaljenost.Name = "Udaljenost";
            // 
            // Ukloni
            // 
            this.Ukloni.HeaderText = "Ukloni";
            this.Ukloni.Name = "Ukloni";
            this.Ukloni.Text = "Ukloni";
            this.Ukloni.ToolTipText = "Ukloni";
            // 
            // frm_SmjestajOkoline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_Okolina);
            this.Name = "frm_SmjestajOkoline";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Udaljenost;
        private System.Windows.Forms.DataGridViewButtonColumn Ukloni;
    }
}