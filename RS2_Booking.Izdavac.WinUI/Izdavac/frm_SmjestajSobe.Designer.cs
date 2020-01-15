namespace RS2_Booking.Izdavac.WinUI.Smjestaj
{
    partial class frm_SmjestajSobe
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
            this.dgv_Sobe = new System.Windows.Forms.DataGridView();
            this.SobaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojKreveta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VrstaSmjestaja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VelicinaSobe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VlastitaKupoanica = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Izmjeni = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Ukloni = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btn_DodajSobu = new System.Windows.Forms.Button();
            this.btn_Nazad = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Sobe)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_Sobe);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(856, 273);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Trenutno dostupne sobe u smještaju";
            // 
            // dgv_Sobe
            // 
            this.dgv_Sobe.AllowUserToAddRows = false;
            this.dgv_Sobe.AllowUserToResizeColumns = false;
            this.dgv_Sobe.AllowUserToResizeRows = false;
            this.dgv_Sobe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Sobe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SobaId,
            this.BrojKreveta,
            this.Cijena,
            this.VrstaSmjestaja,
            this.VelicinaSobe,
            this.VlastitaKupoanica,
            this.Izmjeni,
            this.Ukloni});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Sobe.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Sobe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Sobe.Location = new System.Drawing.Point(3, 16);
            this.dgv_Sobe.MultiSelect = false;
            this.dgv_Sobe.Name = "dgv_Sobe";
            this.dgv_Sobe.Size = new System.Drawing.Size(850, 254);
            this.dgv_Sobe.TabIndex = 0;
            this.dgv_Sobe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Sobe_CellClick);
            // 
            // SobaId
            // 
            this.SobaId.DataPropertyName = "SobaId";
            this.SobaId.HeaderText = "Column1";
            this.SobaId.Name = "SobaId";
            this.SobaId.ReadOnly = true;
            this.SobaId.Visible = false;
            // 
            // BrojKreveta
            // 
            this.BrojKreveta.DataPropertyName = "BrojKreveta";
            this.BrojKreveta.HeaderText = "Broj Kreveta";
            this.BrojKreveta.Name = "BrojKreveta";
            this.BrojKreveta.ReadOnly = true;
            // 
            // Cijena
            // 
            this.Cijena.DataPropertyName = "Cijena";
            this.Cijena.HeaderText = "Cijena";
            this.Cijena.Name = "Cijena";
            this.Cijena.ReadOnly = true;
            // 
            // VrstaSmjestaja
            // 
            this.VrstaSmjestaja.DataPropertyName = "VrstaSmjestaja";
            this.VrstaSmjestaja.HeaderText = "Vrsta Smještaja";
            this.VrstaSmjestaja.Name = "VrstaSmjestaja";
            this.VrstaSmjestaja.ReadOnly = true;
            // 
            // VelicinaSobe
            // 
            this.VelicinaSobe.DataPropertyName = "VelicinaSobe";
            this.VelicinaSobe.HeaderText = "Veličina Sobe";
            this.VelicinaSobe.Name = "VelicinaSobe";
            this.VelicinaSobe.ReadOnly = true;
            // 
            // VlastitaKupoanica
            // 
            this.VlastitaKupoanica.DataPropertyName = "VlastitaKupoanica";
            this.VlastitaKupoanica.HeaderText = "Vlastita Kupaonica";
            this.VlastitaKupoanica.Name = "VlastitaKupoanica";
            this.VlastitaKupoanica.ReadOnly = true;
            // 
            // Izmjeni
            // 
            this.Izmjeni.DataPropertyName = "Izmjeni";
            this.Izmjeni.HeaderText = "Izmjeni";
            this.Izmjeni.Name = "Izmjeni";
            this.Izmjeni.Text = "Izmjeni";
            this.Izmjeni.ToolTipText = "Izmjeni";
            this.Izmjeni.UseColumnTextForButtonValue = true;
            // 
            // Ukloni
            // 
            this.Ukloni.DataPropertyName = "Ukloni";
            this.Ukloni.HeaderText = "Ukloni";
            this.Ukloni.Name = "Ukloni";
            this.Ukloni.Text = "Ukloni";
            this.Ukloni.UseColumnTextForButtonValue = true;
            // 
            // btn_DodajSobu
            // 
            this.btn_DodajSobu.BackColor = System.Drawing.Color.Green;
            this.btn_DodajSobu.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btn_DodajSobu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DodajSobu.ForeColor = System.Drawing.Color.White;
            this.btn_DodajSobu.Location = new System.Drawing.Point(15, 291);
            this.btn_DodajSobu.Name = "btn_DodajSobu";
            this.btn_DodajSobu.Size = new System.Drawing.Size(101, 38);
            this.btn_DodajSobu.TabIndex = 1;
            this.btn_DodajSobu.Text = "Dodaj novu sobu";
            this.btn_DodajSobu.UseVisualStyleBackColor = false;
            this.btn_DodajSobu.Click += new System.EventHandler(this.btn_DodajSobu_Click);
            // 
            // btn_Nazad
            // 
            this.btn_Nazad.BackColor = System.Drawing.Color.Red;
            this.btn_Nazad.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Nazad.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_Nazad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Nazad.ForeColor = System.Drawing.Color.White;
            this.btn_Nazad.Location = new System.Drawing.Point(767, 291);
            this.btn_Nazad.Name = "btn_Nazad";
            this.btn_Nazad.Size = new System.Drawing.Size(101, 38);
            this.btn_Nazad.TabIndex = 2;
            this.btn_Nazad.Text = "Nazad";
            this.btn_Nazad.UseVisualStyleBackColor = false;
            this.btn_Nazad.Click += new System.EventHandler(this.btn_Nazad_Click);
            // 
            // frm_SmjestajSobe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.CancelButton = this.btn_Nazad;
            this.ClientSize = new System.Drawing.Size(887, 338);
            this.Controls.Add(this.btn_Nazad);
            this.Controls.Add(this.btn_DodajSobu);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_SmjestajSobe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uredi Sobe";
            this.Load += new System.EventHandler(this.frm_SmjestajSobe_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Sobe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_Sobe;
        private System.Windows.Forms.Button btn_DodajSobu;
        private System.Windows.Forms.Button btn_Nazad;
        private System.Windows.Forms.DataGridViewTextBoxColumn SobaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojKreveta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn VrstaSmjestaja;
        private System.Windows.Forms.DataGridViewTextBoxColumn VelicinaSobe;
        private System.Windows.Forms.DataGridViewCheckBoxColumn VlastitaKupoanica;
        private System.Windows.Forms.DataGridViewButtonColumn Izmjeni;
        private System.Windows.Forms.DataGridViewButtonColumn Ukloni;
    }
}