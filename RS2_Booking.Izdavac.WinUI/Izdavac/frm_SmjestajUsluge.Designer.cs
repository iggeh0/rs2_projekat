namespace RS2_Booking.Izdavac.WinUI.Smjestaj
{
    partial class frm_SmjestajUsluge
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_Usluge = new System.Windows.Forms.DataGridView();
            this.Usluga_SmjestajId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UslugaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ukloni = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Opis_Nova = new System.Windows.Forms.TextBox();
            this.tb_Naziv_Nova = new System.Windows.Forms.TextBox();
            this.btn_Dodaj_Novu = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_Dodaj_Postojecu = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_Usluge = new System.Windows.Forms.ComboBox();
            this.btn_Nazad = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Usluge)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.groupBox1.Controls.Add(this.dgv_Usluge);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(9, 153);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(540, 147);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Trenutne usluge u ponudi";
            // 
            // dgv_Usluge
            // 
            this.dgv_Usluge.AllowUserToAddRows = false;
            this.dgv_Usluge.AllowUserToDeleteRows = false;
            this.dgv_Usluge.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Usluge.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Usluga_SmjestajId,
            this.Naziv,
            this.Opis,
            this.UslugaId,
            this.Ukloni});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Usluge.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Usluge.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Usluge.Location = new System.Drawing.Point(3, 16);
            this.dgv_Usluge.Name = "dgv_Usluge";
            this.dgv_Usluge.ReadOnly = true;
            this.dgv_Usluge.Size = new System.Drawing.Size(534, 128);
            this.dgv_Usluge.TabIndex = 0;
            this.dgv_Usluge.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Usluge_CellContentClick);
            // 
            // Usluga_SmjestajId
            // 
            this.Usluga_SmjestajId.DataPropertyName = "UslugaSmjestajId";
            this.Usluga_SmjestajId.HeaderText = "Us_SmId";
            this.Usluga_SmjestajId.Name = "Usluga_SmjestajId";
            this.Usluga_SmjestajId.ReadOnly = true;
            this.Usluga_SmjestajId.Visible = false;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // Opis
            // 
            this.Opis.DataPropertyName = "Opis";
            this.Opis.HeaderText = "Opis";
            this.Opis.Name = "Opis";
            this.Opis.ReadOnly = true;
            // 
            // UslugaId
            // 
            this.UslugaId.DataPropertyName = "UslugaId";
            this.UslugaId.HeaderText = "UslugaId";
            this.UslugaId.Name = "UslugaId";
            this.UslugaId.ReadOnly = true;
            this.UslugaId.Visible = false;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tb_Opis_Nova);
            this.groupBox2.Controls.Add(this.tb_Naziv_Nova);
            this.groupBox2.Controls.Add(this.btn_Dodaj_Novu);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(293, 135);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dodaj novu uslugu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Opis usluge:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Naziv usluge:";
            // 
            // tb_Opis_Nova
            // 
            this.tb_Opis_Nova.Location = new System.Drawing.Point(6, 78);
            this.tb_Opis_Nova.Name = "tb_Opis_Nova";
            this.tb_Opis_Nova.Size = new System.Drawing.Size(100, 20);
            this.tb_Opis_Nova.TabIndex = 3;
            // 
            // tb_Naziv_Nova
            // 
            this.tb_Naziv_Nova.Location = new System.Drawing.Point(6, 40);
            this.tb_Naziv_Nova.Name = "tb_Naziv_Nova";
            this.tb_Naziv_Nova.Size = new System.Drawing.Size(100, 20);
            this.tb_Naziv_Nova.TabIndex = 2;
            // 
            // btn_Dodaj_Novu
            // 
            this.btn_Dodaj_Novu.BackColor = System.Drawing.Color.Green;
            this.btn_Dodaj_Novu.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btn_Dodaj_Novu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Dodaj_Novu.Location = new System.Drawing.Point(6, 106);
            this.btn_Dodaj_Novu.Name = "btn_Dodaj_Novu";
            this.btn_Dodaj_Novu.Size = new System.Drawing.Size(75, 23);
            this.btn_Dodaj_Novu.TabIndex = 1;
            this.btn_Dodaj_Novu.Text = "Dodaj";
            this.btn_Dodaj_Novu.UseVisualStyleBackColor = false;
            this.btn_Dodaj_Novu.Click += new System.EventHandler(this.btn_Dodaj_Novu_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_Dodaj_Postojecu);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.cb_Usluge);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(311, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(235, 135);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dodaj postojeću uslugu";
            // 
            // btn_Dodaj_Postojecu
            // 
            this.btn_Dodaj_Postojecu.BackColor = System.Drawing.Color.Green;
            this.btn_Dodaj_Postojecu.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btn_Dodaj_Postojecu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Dodaj_Postojecu.Location = new System.Drawing.Point(7, 106);
            this.btn_Dodaj_Postojecu.Name = "btn_Dodaj_Postojecu";
            this.btn_Dodaj_Postojecu.Size = new System.Drawing.Size(75, 23);
            this.btn_Dodaj_Postojecu.TabIndex = 2;
            this.btn_Dodaj_Postojecu.Text = "Dodaj";
            this.btn_Dodaj_Postojecu.UseVisualStyleBackColor = false;
            this.btn_Dodaj_Postojecu.Click += new System.EventHandler(this.btn_Dodaj_Postojecu_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(7, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Naziv usluge";
            // 
            // cb_Usluge
            // 
            this.cb_Usluge.FormattingEnabled = true;
            this.cb_Usluge.Location = new System.Drawing.Point(7, 38);
            this.cb_Usluge.Name = "cb_Usluge";
            this.cb_Usluge.Size = new System.Drawing.Size(121, 21);
            this.cb_Usluge.TabIndex = 0;
            // 
            // btn_Nazad
            // 
            this.btn_Nazad.BackColor = System.Drawing.Color.Red;
            this.btn_Nazad.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_Nazad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Nazad.ForeColor = System.Drawing.Color.White;
            this.btn_Nazad.Location = new System.Drawing.Point(230, 315);
            this.btn_Nazad.Name = "btn_Nazad";
            this.btn_Nazad.Size = new System.Drawing.Size(75, 23);
            this.btn_Nazad.TabIndex = 3;
            this.btn_Nazad.Text = "Nazad";
            this.btn_Nazad.UseVisualStyleBackColor = false;
            this.btn_Nazad.Click += new System.EventHandler(this.btn_Nazad_Click);
            // 
            // frm_SmjestajUsluge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(566, 350);
            this.Controls.Add(this.btn_Nazad);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_SmjestajUsluge";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uredi Usluge";
            this.Load += new System.EventHandler(this.frm_SmjestajUsluge_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Usluge)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_Usluge;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Dodaj_Novu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Opis_Nova;
        private System.Windows.Forms.TextBox tb_Naziv_Nova;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_Dodaj_Postojecu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_Usluge;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usluga_SmjestajId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opis;
        private System.Windows.Forms.DataGridViewTextBoxColumn UslugaId;
        private System.Windows.Forms.DataGridViewButtonColumn Ukloni;
        private System.Windows.Forms.Button btn_Nazad;
    }
}