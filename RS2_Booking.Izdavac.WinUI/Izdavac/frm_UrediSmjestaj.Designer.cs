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
            this.btn_SmjestajOkolina = new System.Windows.Forms.Button();
            this.btn_SmjestajUsluge = new System.Windows.Forms.Button();
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
            this.SuspendLayout();
            // 
            // btn_SmjestajSobe
            // 
            this.btn_SmjestajSobe.Location = new System.Drawing.Point(196, 8);
            this.btn_SmjestajSobe.Name = "btn_SmjestajSobe";
            this.btn_SmjestajSobe.Size = new System.Drawing.Size(147, 66);
            this.btn_SmjestajSobe.TabIndex = 1;
            this.btn_SmjestajSobe.Text = "Upravljanje sobama";
            this.btn_SmjestajSobe.UseVisualStyleBackColor = true;
            this.btn_SmjestajSobe.Click += new System.EventHandler(this.btn_SmjestajSobe_Click);
            // 
            // btn_SmjestajOkolina
            // 
            this.btn_SmjestajOkolina.Location = new System.Drawing.Point(74, 8);
            this.btn_SmjestajOkolina.Name = "btn_SmjestajOkolina";
            this.btn_SmjestajOkolina.Size = new System.Drawing.Size(100, 66);
            this.btn_SmjestajOkolina.TabIndex = 2;
            this.btn_SmjestajOkolina.Text = "Upravljanje okolinom";
            this.btn_SmjestajOkolina.UseVisualStyleBackColor = true;
            // 
            // btn_SmjestajUsluge
            // 
            this.btn_SmjestajUsluge.Location = new System.Drawing.Point(349, 8);
            this.btn_SmjestajUsluge.Name = "btn_SmjestajUsluge";
            this.btn_SmjestajUsluge.Size = new System.Drawing.Size(138, 66);
            this.btn_SmjestajUsluge.TabIndex = 3;
            this.btn_SmjestajUsluge.Text = "Upravljanje uslugama";
            this.btn_SmjestajUsluge.UseVisualStyleBackColor = true;
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
            this.label5.Location = new System.Drawing.Point(292, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Opis";
            // 
            // tb_Opis
            // 
            this.tb_Opis.Location = new System.Drawing.Point(295, 131);
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
            this.btn_Slike.Location = new System.Drawing.Point(503, 12);
            this.btn_Slike.Name = "btn_Slike";
            this.btn_Slike.Size = new System.Drawing.Size(118, 62);
            this.btn_Slike.TabIndex = 19;
            this.btn_Slike.Text = "Upravljanje slikama";
            this.btn_Slike.UseVisualStyleBackColor = true;
            // 
            // frm_UrediSmjestaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Controls.Add(this.btn_SmjestajUsluge);
            this.Controls.Add(this.btn_SmjestajOkolina);
            this.Controls.Add(this.btn_SmjestajSobe);
            this.Name = "frm_UrediSmjestaj";
            this.Text = "Uredi Smještaj";
            this.Load += new System.EventHandler(this.frm_UrediSmjestaj_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_SmjestajSobe;
        private System.Windows.Forms.Button btn_SmjestajOkolina;
        private System.Windows.Forms.Button btn_SmjestajUsluge;
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
    }
}