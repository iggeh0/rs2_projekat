namespace RS2_Booking.Izdavac.WinUI.Smjestaj
{
    partial class frm_UrediSobe
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
            this.btn_Nazad = new System.Windows.Forms.Button();
            this.btn_Snimi = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_Kupaonica = new System.Windows.Forms.CheckBox();
            this.tb_VrstaSmjestaja = new System.Windows.Forms.TextBox();
            this.tb_Cijena = new System.Windows.Forms.TextBox();
            this.tb_BrojKreveta = new System.Windows.Forms.TextBox();
            this.tb_Velicina = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_Inventar = new System.Windows.Forms.DataGridView();
            this.InventarId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ukloni = new System.Windows.Forms.DataGridViewButtonColumn();
            this.InventarSobaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_Inventar = new System.Windows.Forms.TextBox();
            this.btn_Inventar = new System.Windows.Forms.Button();
            this.tb_Opis = new System.Windows.Forms.RichTextBox();
            this.lbl_brKrevetaError = new System.Windows.Forms.Label();
            this.lbl_cijenaErr = new System.Windows.Forms.Label();
            this.lbl_VrstaErr = new System.Windows.Forms.Label();
            this.lbl_VelicinaErr = new System.Windows.Forms.Label();
            this.lbl_OpisErr = new System.Windows.Forms.Label();
            this.lbl_inventarError = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Inventar)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Nazad
            // 
            this.btn_Nazad.BackColor = System.Drawing.Color.Red;
            this.btn_Nazad.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Nazad.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_Nazad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Nazad.ForeColor = System.Drawing.Color.White;
            this.btn_Nazad.Location = new System.Drawing.Point(302, 353);
            this.btn_Nazad.Name = "btn_Nazad";
            this.btn_Nazad.Size = new System.Drawing.Size(75, 23);
            this.btn_Nazad.TabIndex = 24;
            this.btn_Nazad.Text = "Nazad";
            this.btn_Nazad.UseVisualStyleBackColor = false;
            this.btn_Nazad.Click += new System.EventHandler(this.btn_Nazad_Click);
            // 
            // btn_Snimi
            // 
            this.btn_Snimi.BackColor = System.Drawing.Color.Olive;
            this.btn_Snimi.FlatAppearance.BorderColor = System.Drawing.Color.Olive;
            this.btn_Snimi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Snimi.ForeColor = System.Drawing.Color.White;
            this.btn_Snimi.Location = new System.Drawing.Point(302, 324);
            this.btn_Snimi.Name = "btn_Snimi";
            this.btn_Snimi.Size = new System.Drawing.Size(75, 23);
            this.btn_Snimi.TabIndex = 23;
            this.btn_Snimi.Text = "Snimi";
            this.btn_Snimi.UseVisualStyleBackColor = false;
            this.btn_Snimi.Click += new System.EventHandler(this.btn_Snimi_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(38, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Veličina sobe (m²)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(40, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Opis";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(37, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Vrsta Smještaja";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(37, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Cijena (KM)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(38, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Broj Kreveta";
            // 
            // cb_Kupaonica
            // 
            this.cb_Kupaonica.AutoSize = true;
            this.cb_Kupaonica.ForeColor = System.Drawing.Color.White;
            this.cb_Kupaonica.Location = new System.Drawing.Point(41, 179);
            this.cb_Kupaonica.Name = "cb_Kupaonica";
            this.cb_Kupaonica.Size = new System.Drawing.Size(113, 17);
            this.cb_Kupaonica.TabIndex = 17;
            this.cb_Kupaonica.Text = "Vlastita kupaonica";
            this.cb_Kupaonica.UseVisualStyleBackColor = true;
            // 
            // tb_VrstaSmjestaja
            // 
            this.tb_VrstaSmjestaja.Location = new System.Drawing.Point(140, 147);
            this.tb_VrstaSmjestaja.Name = "tb_VrstaSmjestaja";
            this.tb_VrstaSmjestaja.Size = new System.Drawing.Size(100, 20);
            this.tb_VrstaSmjestaja.TabIndex = 15;
            // 
            // tb_Cijena
            // 
            this.tb_Cijena.Location = new System.Drawing.Point(142, 71);
            this.tb_Cijena.Name = "tb_Cijena";
            this.tb_Cijena.Size = new System.Drawing.Size(21, 20);
            this.tb_Cijena.TabIndex = 14;
            // 
            // tb_BrojKreveta
            // 
            this.tb_BrojKreveta.Location = new System.Drawing.Point(142, 32);
            this.tb_BrojKreveta.Name = "tb_BrojKreveta";
            this.tb_BrojKreveta.Size = new System.Drawing.Size(21, 20);
            this.tb_BrojKreveta.TabIndex = 13;
            // 
            // tb_Velicina
            // 
            this.tb_Velicina.Location = new System.Drawing.Point(140, 114);
            this.tb_Velicina.Name = "tb_Velicina";
            this.tb_Velicina.Size = new System.Drawing.Size(21, 20);
            this.tb_Velicina.TabIndex = 25;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_Inventar);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(267, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(421, 151);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inventar";
            // 
            // dgv_Inventar
            // 
            this.dgv_Inventar.AllowUserToAddRows = false;
            this.dgv_Inventar.AllowUserToDeleteRows = false;
            this.dgv_Inventar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Inventar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InventarId,
            this.Naziv,
            this.Ukloni,
            this.InventarSobaId});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Inventar.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Inventar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Inventar.Location = new System.Drawing.Point(3, 16);
            this.dgv_Inventar.Name = "dgv_Inventar";
            this.dgv_Inventar.ReadOnly = true;
            this.dgv_Inventar.Size = new System.Drawing.Size(415, 132);
            this.dgv_Inventar.TabIndex = 0;
            this.dgv_Inventar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Inventar_CellContentClick);
            // 
            // InventarId
            // 
            this.InventarId.DataPropertyName = "InventarId";
            this.InventarId.HeaderText = "InventarId";
            this.InventarId.Name = "InventarId";
            this.InventarId.ReadOnly = true;
            this.InventarId.Visible = false;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // Ukloni
            // 
            this.Ukloni.HeaderText = "Ukloni";
            this.Ukloni.Name = "Ukloni";
            this.Ukloni.ReadOnly = true;
            this.Ukloni.Text = "Ukloni";
            this.Ukloni.UseColumnTextForButtonValue = true;
            // 
            // InventarSobaId
            // 
            this.InventarSobaId.DataPropertyName = "InventarSobaId";
            this.InventarSobaId.HeaderText = "InventarSobaId";
            this.InventarSobaId.Name = "InventarSobaId";
            this.InventarSobaId.ReadOnly = true;
            this.InventarSobaId.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(278, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Dodaj novi inventar";
            // 
            // tb_Inventar
            // 
            this.tb_Inventar.Location = new System.Drawing.Point(390, 206);
            this.tb_Inventar.Name = "tb_Inventar";
            this.tb_Inventar.Size = new System.Drawing.Size(100, 20);
            this.tb_Inventar.TabIndex = 27;
            // 
            // btn_Inventar
            // 
            this.btn_Inventar.BackColor = System.Drawing.Color.Green;
            this.btn_Inventar.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btn_Inventar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Inventar.ForeColor = System.Drawing.Color.White;
            this.btn_Inventar.Location = new System.Drawing.Point(390, 232);
            this.btn_Inventar.Name = "btn_Inventar";
            this.btn_Inventar.Size = new System.Drawing.Size(100, 30);
            this.btn_Inventar.TabIndex = 29;
            this.btn_Inventar.Text = "Dodaj Inventar";
            this.btn_Inventar.UseVisualStyleBackColor = false;
            this.btn_Inventar.Click += new System.EventHandler(this.btn_Inventar_Click);
            // 
            // tb_Opis
            // 
            this.tb_Opis.Location = new System.Drawing.Point(125, 227);
            this.tb_Opis.Name = "tb_Opis";
            this.tb_Opis.Size = new System.Drawing.Size(100, 96);
            this.tb_Opis.TabIndex = 30;
            this.tb_Opis.Text = "";
            // 
            // lbl_brKrevetaError
            // 
            this.lbl_brKrevetaError.AutoSize = true;
            this.lbl_brKrevetaError.ForeColor = System.Drawing.Color.Red;
            this.lbl_brKrevetaError.Location = new System.Drawing.Point(142, 13);
            this.lbl_brKrevetaError.Name = "lbl_brKrevetaError";
            this.lbl_brKrevetaError.Size = new System.Drawing.Size(35, 13);
            this.lbl_brKrevetaError.TabIndex = 31;
            this.lbl_brKrevetaError.Text = "label7";
            this.lbl_brKrevetaError.Visible = false;
            // 
            // lbl_cijenaErr
            // 
            this.lbl_cijenaErr.AutoSize = true;
            this.lbl_cijenaErr.ForeColor = System.Drawing.Color.Red;
            this.lbl_cijenaErr.Location = new System.Drawing.Point(139, 56);
            this.lbl_cijenaErr.Name = "lbl_cijenaErr";
            this.lbl_cijenaErr.Size = new System.Drawing.Size(35, 13);
            this.lbl_cijenaErr.TabIndex = 32;
            this.lbl_cijenaErr.Text = "label8";
            this.lbl_cijenaErr.Visible = false;
            // 
            // lbl_VrstaErr
            // 
            this.lbl_VrstaErr.AutoSize = true;
            this.lbl_VrstaErr.ForeColor = System.Drawing.Color.Red;
            this.lbl_VrstaErr.Location = new System.Drawing.Point(205, 131);
            this.lbl_VrstaErr.Name = "lbl_VrstaErr";
            this.lbl_VrstaErr.Size = new System.Drawing.Size(35, 13);
            this.lbl_VrstaErr.TabIndex = 33;
            this.lbl_VrstaErr.Text = "label9";
            this.lbl_VrstaErr.Visible = false;
            // 
            // lbl_VelicinaErr
            // 
            this.lbl_VelicinaErr.AutoSize = true;
            this.lbl_VelicinaErr.ForeColor = System.Drawing.Color.Red;
            this.lbl_VelicinaErr.Location = new System.Drawing.Point(139, 99);
            this.lbl_VelicinaErr.Name = "lbl_VelicinaErr";
            this.lbl_VelicinaErr.Size = new System.Drawing.Size(41, 13);
            this.lbl_VelicinaErr.TabIndex = 34;
            this.lbl_VelicinaErr.Text = "label10";
            this.lbl_VelicinaErr.Visible = false;
            // 
            // lbl_OpisErr
            // 
            this.lbl_OpisErr.AutoSize = true;
            this.lbl_OpisErr.ForeColor = System.Drawing.Color.Red;
            this.lbl_OpisErr.Location = new System.Drawing.Point(122, 206);
            this.lbl_OpisErr.Name = "lbl_OpisErr";
            this.lbl_OpisErr.Size = new System.Drawing.Size(41, 13);
            this.lbl_OpisErr.TabIndex = 35;
            this.lbl_OpisErr.Text = "label11";
            this.lbl_OpisErr.Visible = false;
            // 
            // lbl_inventarError
            // 
            this.lbl_inventarError.AutoSize = true;
            this.lbl_inventarError.ForeColor = System.Drawing.Color.Red;
            this.lbl_inventarError.Location = new System.Drawing.Point(387, 192);
            this.lbl_inventarError.Name = "lbl_inventarError";
            this.lbl_inventarError.Size = new System.Drawing.Size(41, 13);
            this.lbl_inventarError.TabIndex = 36;
            this.lbl_inventarError.Text = "label12";
            this.lbl_inventarError.Visible = false;
            // 
            // frm_UrediSobe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.CancelButton = this.btn_Nazad;
            this.ClientSize = new System.Drawing.Size(698, 379);
            this.Controls.Add(this.lbl_inventarError);
            this.Controls.Add(this.lbl_OpisErr);
            this.Controls.Add(this.lbl_VelicinaErr);
            this.Controls.Add(this.lbl_VrstaErr);
            this.Controls.Add(this.lbl_cijenaErr);
            this.Controls.Add(this.lbl_brKrevetaError);
            this.Controls.Add(this.tb_Opis);
            this.Controls.Add(this.btn_Inventar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_Inventar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tb_Velicina);
            this.Controls.Add(this.btn_Nazad);
            this.Controls.Add(this.btn_Snimi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_Kupaonica);
            this.Controls.Add(this.tb_VrstaSmjestaja);
            this.Controls.Add(this.tb_Cijena);
            this.Controls.Add(this.tb_BrojKreveta);
            this.Name = "frm_UrediSobe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uredi Sobu";
            this.Load += new System.EventHandler(this.frm_UrediSobe_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Inventar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Nazad;
        private System.Windows.Forms.Button btn_Snimi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cb_Kupaonica;
        private System.Windows.Forms.TextBox tb_VrstaSmjestaja;
        private System.Windows.Forms.TextBox tb_Cijena;
        private System.Windows.Forms.TextBox tb_BrojKreveta;
        private System.Windows.Forms.TextBox tb_Velicina;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_Inventar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_Inventar;
        private System.Windows.Forms.Button btn_Inventar;
        private System.Windows.Forms.RichTextBox tb_Opis;
        private System.Windows.Forms.DataGridViewTextBoxColumn InventarId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewButtonColumn Ukloni;
        private System.Windows.Forms.DataGridViewTextBoxColumn InventarSobaId;
        private System.Windows.Forms.Label lbl_brKrevetaError;
        private System.Windows.Forms.Label lbl_cijenaErr;
        private System.Windows.Forms.Label lbl_VrstaErr;
        private System.Windows.Forms.Label lbl_VelicinaErr;
        private System.Windows.Forms.Label lbl_OpisErr;
        private System.Windows.Forms.Label lbl_inventarError;
    }
}