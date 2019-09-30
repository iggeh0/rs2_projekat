namespace RS2_Booking.Izdavac.WinUI.Smjestaj
{
    partial class frm_UrediSmjestaj
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
            this.btn_SmjestajSobe = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Naziv = new System.Windows.Forms.TextBox();
            this.tb_Telefon = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_Email = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_Opis = new System.Windows.Forms.RichTextBox();
            this.btn_Snimi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Grad = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_Adresa = new System.Windows.Forms.Label();
            this.btn_Slike = new System.Windows.Forms.Button();
            this.btn_Nazad = new System.Windows.Forms.Button();
            this.dgv_Okolina = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_OkolinaDodaj = new System.Windows.Forms.TextBox();
            this.btn_OkolinaDodaj = new System.Windows.Forms.Button();
            this.dgv_Usluge = new System.Windows.Forms.DataGridView();
            this.tb_UslugaDodaj = new System.Windows.Forms.TextBox();
            this.btn_UslugaDodaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Okolina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Usluge)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_SmjestajSobe
            // 
            this.btn_SmjestajSobe.Location = new System.Drawing.Point(74, 10);
            this.btn_SmjestajSobe.Name = "btn_SmjestajSobe";
            this.btn_SmjestajSobe.Size = new System.Drawing.Size(147, 66);
            this.btn_SmjestajSobe.TabIndex = 1;
            this.btn_SmjestajSobe.Text = "Upravljanje sobama";
            this.btn_SmjestajSobe.UseVisualStyleBackColor = true;
            this.btn_SmjestajSobe.Click += new System.EventHandler(this.btn_SmjestajSobe_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Naziv";
            // 
            // tb_Naziv
            // 
            this.tb_Naziv.Location = new System.Drawing.Point(74, 125);
            this.tb_Naziv.Name = "tb_Naziv";
            this.tb_Naziv.Size = new System.Drawing.Size(100, 20);
            this.tb_Naziv.TabIndex = 5;
            // 
            // tb_Telefon
            // 
            this.tb_Telefon.Location = new System.Drawing.Point(74, 167);
            this.tb_Telefon.Name = "tb_Telefon";
            this.tb_Telefon.Size = new System.Drawing.Size(100, 20);
            this.tb_Telefon.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Kontakt telefon";
            // 
            // tb_Email
            // 
            this.tb_Email.Location = new System.Drawing.Point(74, 206);
            this.tb_Email.Name = "tb_Email";
            this.tb_Email.Size = new System.Drawing.Size(100, 20);
            this.tb_Email.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "E-mail";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(259, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Opis";
            // 
            // tb_Opis
            // 
            this.tb_Opis.Location = new System.Drawing.Point(262, 125);
            this.tb_Opis.Name = "tb_Opis";
            this.tb_Opis.Size = new System.Drawing.Size(239, 117);
            this.tb_Opis.TabIndex = 13;
            this.tb_Opis.Text = "";
            // 
            // btn_Snimi
            // 
            this.btn_Snimi.Location = new System.Drawing.Point(74, 298);
            this.btn_Snimi.Name = "btn_Snimi";
            this.btn_Snimi.Size = new System.Drawing.Size(75, 23);
            this.btn_Snimi.TabIndex = 14;
            this.btn_Snimi.Text = "Snimi";
            this.btn_Snimi.UseVisualStyleBackColor = true;
            this.btn_Snimi.Click += new System.EventHandler(this.btn_Snimi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Grad:";
            // 
            // lbl_Grad
            // 
            this.lbl_Grad.AutoSize = true;
            this.lbl_Grad.Location = new System.Drawing.Point(193, 131);
            this.lbl_Grad.Name = "lbl_Grad";
            this.lbl_Grad.Size = new System.Drawing.Size(35, 13);
            this.lbl_Grad.TabIndex = 16;
            this.lbl_Grad.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(193, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Adresa:";
            // 
            // lbl_Adresa
            // 
            this.lbl_Adresa.AutoSize = true;
            this.lbl_Adresa.Location = new System.Drawing.Point(193, 173);
            this.lbl_Adresa.Name = "lbl_Adresa";
            this.lbl_Adresa.Size = new System.Drawing.Size(35, 13);
            this.lbl_Adresa.TabIndex = 18;
            this.lbl_Adresa.Text = "label8";
            // 
            // btn_Slike
            // 
            this.btn_Slike.Location = new System.Drawing.Point(262, 10);
            this.btn_Slike.Name = "btn_Slike";
            this.btn_Slike.Size = new System.Drawing.Size(118, 62);
            this.btn_Slike.TabIndex = 19;
            this.btn_Slike.Text = "Upravljanje slikama";
            this.btn_Slike.UseVisualStyleBackColor = true;
            // 
            // btn_Nazad
            // 
            this.btn_Nazad.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Nazad.Location = new System.Drawing.Point(74, 328);
            this.btn_Nazad.Name = "btn_Nazad";
            this.btn_Nazad.Size = new System.Drawing.Size(75, 23);
            this.btn_Nazad.TabIndex = 20;
            this.btn_Nazad.Text = "Nazad";
            this.btn_Nazad.UseVisualStyleBackColor = true;
            this.btn_Nazad.Click += new System.EventHandler(this.btn_Nazad_Click);
            // 
            // dgv_Okolina
            // 
            this.dgv_Okolina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Okolina.Location = new System.Drawing.Point(537, 125);
            this.dgv_Okolina.Name = "dgv_Okolina";
            this.dgv_Okolina.Size = new System.Drawing.Size(369, 117);
            this.dgv_Okolina.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(537, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Okolna mjesta:";
            // 
            // tb_OkolinaDodaj
            // 
            this.tb_OkolinaDodaj.Location = new System.Drawing.Point(540, 265);
            this.tb_OkolinaDodaj.Name = "tb_OkolinaDodaj";
            this.tb_OkolinaDodaj.Size = new System.Drawing.Size(100, 20);
            this.tb_OkolinaDodaj.TabIndex = 23;
            // 
            // btn_OkolinaDodaj
            // 
            this.btn_OkolinaDodaj.Location = new System.Drawing.Point(646, 262);
            this.btn_OkolinaDodaj.Name = "btn_OkolinaDodaj";
            this.btn_OkolinaDodaj.Size = new System.Drawing.Size(75, 23);
            this.btn_OkolinaDodaj.TabIndex = 24;
            this.btn_OkolinaDodaj.Text = "Dodaj";
            this.btn_OkolinaDodaj.UseVisualStyleBackColor = true;
            this.btn_OkolinaDodaj.Click += new System.EventHandler(this.btn_OkolinaDodaj_Click);
            // 
            // dgv_Usluge
            // 
            this.dgv_Usluge.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Usluge.Location = new System.Drawing.Point(262, 365);
            this.dgv_Usluge.Name = "dgv_Usluge";
            this.dgv_Usluge.Size = new System.Drawing.Size(240, 150);
            this.dgv_Usluge.TabIndex = 25;
            // 
            // tb_UslugaDodaj
            // 
            this.tb_UslugaDodaj.Location = new System.Drawing.Point(262, 521);
            this.tb_UslugaDodaj.Name = "tb_UslugaDodaj";
            this.tb_UslugaDodaj.Size = new System.Drawing.Size(100, 20);
            this.tb_UslugaDodaj.TabIndex = 26;
            // 
            // btn_UslugaDodaj
            // 
            this.btn_UslugaDodaj.Location = new System.Drawing.Point(368, 518);
            this.btn_UslugaDodaj.Name = "btn_UslugaDodaj";
            this.btn_UslugaDodaj.Size = new System.Drawing.Size(75, 23);
            this.btn_UslugaDodaj.TabIndex = 27;
            this.btn_UslugaDodaj.Text = "Dodaj";
            this.btn_UslugaDodaj.UseVisualStyleBackColor = true;
            // 
            // frm_UrediSmjestaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Nazad;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.btn_UslugaDodaj);
            this.Controls.Add(this.tb_UslugaDodaj);
            this.Controls.Add(this.dgv_Usluge);
            this.Controls.Add(this.btn_OkolinaDodaj);
            this.Controls.Add(this.tb_OkolinaDodaj);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgv_Okolina);
            this.Controls.Add(this.btn_Nazad);
            this.Controls.Add(this.btn_Slike);
            this.Controls.Add(this.lbl_Adresa);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbl_Grad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Snimi);
            this.Controls.Add(this.tb_Opis);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_Email);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_Telefon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_Naziv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_SmjestajSobe);
            this.Name = "frm_UrediSmjestaj";
            this.Text = "Uredi Smještaj";
            this.Load += new System.EventHandler(this.frm_UrediSmjestaj_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Okolina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Usluge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_SmjestajSobe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Naziv;
        private System.Windows.Forms.TextBox tb_Telefon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_Email;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox tb_Opis;
        private System.Windows.Forms.Button btn_Snimi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_Grad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_Adresa;
        private System.Windows.Forms.Button btn_Slike;
        private System.Windows.Forms.Button btn_Nazad;
        private System.Windows.Forms.DataGridView dgv_Okolina;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_OkolinaDodaj;
        private System.Windows.Forms.Button btn_OkolinaDodaj;
        private System.Windows.Forms.DataGridView dgv_Usluge;
        private System.Windows.Forms.TextBox tb_UslugaDodaj;
        private System.Windows.Forms.Button btn_UslugaDodaj;
    }
}