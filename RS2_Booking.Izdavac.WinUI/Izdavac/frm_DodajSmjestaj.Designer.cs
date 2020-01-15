namespace RS2_Booking.Izdavac.WinUI.Smjestaj
{
    partial class frm_DodajSmjestaj
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
            this.tb_Naziv = new System.Windows.Forms.TextBox();
            this.tb_Udaljenost = new System.Windows.Forms.TextBox();
            this.tb_Email = new System.Windows.Forms.TextBox();
            this.tb_Adresa = new System.Windows.Forms.TextBox();
            this.tb_Telefon = new System.Windows.Forms.TextBox();
            this.cb_Grad = new System.Windows.Forms.ComboBox();
            this.lbl_Naziv = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rtb_Opis = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Dodaj = new System.Windows.Forms.Button();
            this.btn_Nazad = new System.Windows.Forms.Button();
            this.lbl_NazivErr = new System.Windows.Forms.Label();
            this.lbl_UdaljenostErr = new System.Windows.Forms.Label();
            this.lbl_GradErr = new System.Windows.Forms.Label();
            this.lbl_OpisErr = new System.Windows.Forms.Label();
            this.lbl_AdresaErr = new System.Windows.Forms.Label();
            this.lbl_TelefonErr = new System.Windows.Forms.Label();
            this.lbl_EmailErr = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_Naziv
            // 
            this.tb_Naziv.Location = new System.Drawing.Point(167, 32);
            this.tb_Naziv.Name = "tb_Naziv";
            this.tb_Naziv.Size = new System.Drawing.Size(215, 20);
            this.tb_Naziv.TabIndex = 0;
            // 
            // tb_Udaljenost
            // 
            this.tb_Udaljenost.Location = new System.Drawing.Point(167, 58);
            this.tb_Udaljenost.Name = "tb_Udaljenost";
            this.tb_Udaljenost.Size = new System.Drawing.Size(215, 20);
            this.tb_Udaljenost.TabIndex = 1;
            // 
            // tb_Email
            // 
            this.tb_Email.Location = new System.Drawing.Point(167, 268);
            this.tb_Email.Name = "tb_Email";
            this.tb_Email.Size = new System.Drawing.Size(215, 20);
            this.tb_Email.TabIndex = 2;
            // 
            // tb_Adresa
            // 
            this.tb_Adresa.Location = new System.Drawing.Point(167, 213);
            this.tb_Adresa.Name = "tb_Adresa";
            this.tb_Adresa.Size = new System.Drawing.Size(215, 20);
            this.tb_Adresa.TabIndex = 12;
            // 
            // tb_Telefon
            // 
            this.tb_Telefon.Location = new System.Drawing.Point(167, 242);
            this.tb_Telefon.Name = "tb_Telefon";
            this.tb_Telefon.Size = new System.Drawing.Size(215, 20);
            this.tb_Telefon.TabIndex = 5;
            // 
            // cb_Grad
            // 
            this.cb_Grad.FormattingEnabled = true;
            this.cb_Grad.Location = new System.Drawing.Point(167, 84);
            this.cb_Grad.Name = "cb_Grad";
            this.cb_Grad.Size = new System.Drawing.Size(215, 21);
            this.cb_Grad.TabIndex = 6;
            // 
            // lbl_Naziv
            // 
            this.lbl_Naziv.AutoSize = true;
            this.lbl_Naziv.ForeColor = System.Drawing.Color.White;
            this.lbl_Naziv.Location = new System.Drawing.Point(54, 36);
            this.lbl_Naziv.Name = "lbl_Naziv";
            this.lbl_Naziv.Size = new System.Drawing.Size(34, 13);
            this.lbl_Naziv.TabIndex = 7;
            this.lbl_Naziv.Text = "Naziv";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(54, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Udaljenost od centra";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(57, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Grad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(57, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Opis";
            // 
            // rtb_Opis
            // 
            this.rtb_Opis.Location = new System.Drawing.Point(167, 111);
            this.rtb_Opis.Name = "rtb_Opis";
            this.rtb_Opis.Size = new System.Drawing.Size(215, 96);
            this.rtb_Opis.TabIndex = 11;
            this.rtb_Opis.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(54, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Adresa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(54, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Kontakt Telefon";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(54, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Email";
            // 
            // btn_Dodaj
            // 
            this.btn_Dodaj.BackColor = System.Drawing.Color.Green;
            this.btn_Dodaj.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btn_Dodaj.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btn_Dodaj.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btn_Dodaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Dodaj.ForeColor = System.Drawing.Color.White;
            this.btn_Dodaj.Location = new System.Drawing.Point(246, 307);
            this.btn_Dodaj.Name = "btn_Dodaj";
            this.btn_Dodaj.Size = new System.Drawing.Size(75, 23);
            this.btn_Dodaj.TabIndex = 16;
            this.btn_Dodaj.Text = "Dodaj";
            this.btn_Dodaj.UseVisualStyleBackColor = false;
            this.btn_Dodaj.Click += new System.EventHandler(this.btn_Dodaj_Click);
            // 
            // btn_Nazad
            // 
            this.btn_Nazad.BackColor = System.Drawing.Color.Red;
            this.btn_Nazad.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_Nazad.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_Nazad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_Nazad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Nazad.ForeColor = System.Drawing.Color.White;
            this.btn_Nazad.Location = new System.Drawing.Point(246, 337);
            this.btn_Nazad.Name = "btn_Nazad";
            this.btn_Nazad.Size = new System.Drawing.Size(75, 23);
            this.btn_Nazad.TabIndex = 17;
            this.btn_Nazad.Text = "Nazad";
            this.btn_Nazad.UseVisualStyleBackColor = false;
            this.btn_Nazad.Click += new System.EventHandler(this.btn_Nazad_Click);
            // 
            // lbl_NazivErr
            // 
            this.lbl_NazivErr.AutoSize = true;
            this.lbl_NazivErr.ForeColor = System.Drawing.Color.Firebrick;
            this.lbl_NazivErr.Location = new System.Drawing.Point(404, 35);
            this.lbl_NazivErr.Name = "lbl_NazivErr";
            this.lbl_NazivErr.Size = new System.Drawing.Size(35, 13);
            this.lbl_NazivErr.TabIndex = 18;
            this.lbl_NazivErr.Text = "label7";
            this.lbl_NazivErr.Visible = false;
            // 
            // lbl_UdaljenostErr
            // 
            this.lbl_UdaljenostErr.AutoSize = true;
            this.lbl_UdaljenostErr.ForeColor = System.Drawing.Color.Firebrick;
            this.lbl_UdaljenostErr.Location = new System.Drawing.Point(404, 64);
            this.lbl_UdaljenostErr.Name = "lbl_UdaljenostErr";
            this.lbl_UdaljenostErr.Size = new System.Drawing.Size(35, 13);
            this.lbl_UdaljenostErr.TabIndex = 19;
            this.lbl_UdaljenostErr.Text = "label8";
            this.lbl_UdaljenostErr.Visible = false;
            // 
            // lbl_GradErr
            // 
            this.lbl_GradErr.AutoSize = true;
            this.lbl_GradErr.ForeColor = System.Drawing.Color.Firebrick;
            this.lbl_GradErr.Location = new System.Drawing.Point(404, 90);
            this.lbl_GradErr.Name = "lbl_GradErr";
            this.lbl_GradErr.Size = new System.Drawing.Size(35, 13);
            this.lbl_GradErr.TabIndex = 20;
            this.lbl_GradErr.Text = "label9";
            this.lbl_GradErr.Visible = false;
            // 
            // lbl_OpisErr
            // 
            this.lbl_OpisErr.AutoSize = true;
            this.lbl_OpisErr.ForeColor = System.Drawing.Color.Firebrick;
            this.lbl_OpisErr.Location = new System.Drawing.Point(403, 117);
            this.lbl_OpisErr.Name = "lbl_OpisErr";
            this.lbl_OpisErr.Size = new System.Drawing.Size(41, 13);
            this.lbl_OpisErr.TabIndex = 21;
            this.lbl_OpisErr.Text = "label10";
            this.lbl_OpisErr.Visible = false;
            // 
            // lbl_AdresaErr
            // 
            this.lbl_AdresaErr.AutoSize = true;
            this.lbl_AdresaErr.ForeColor = System.Drawing.Color.Firebrick;
            this.lbl_AdresaErr.Location = new System.Drawing.Point(404, 216);
            this.lbl_AdresaErr.Name = "lbl_AdresaErr";
            this.lbl_AdresaErr.Size = new System.Drawing.Size(41, 13);
            this.lbl_AdresaErr.TabIndex = 22;
            this.lbl_AdresaErr.Text = "label11";
            this.lbl_AdresaErr.Visible = false;
            // 
            // lbl_TelefonErr
            // 
            this.lbl_TelefonErr.AutoSize = true;
            this.lbl_TelefonErr.ForeColor = System.Drawing.Color.Firebrick;
            this.lbl_TelefonErr.Location = new System.Drawing.Point(404, 245);
            this.lbl_TelefonErr.Name = "lbl_TelefonErr";
            this.lbl_TelefonErr.Size = new System.Drawing.Size(41, 13);
            this.lbl_TelefonErr.TabIndex = 23;
            this.lbl_TelefonErr.Text = "label12";
            this.lbl_TelefonErr.Visible = false;
            // 
            // lbl_EmailErr
            // 
            this.lbl_EmailErr.AutoSize = true;
            this.lbl_EmailErr.ForeColor = System.Drawing.Color.Firebrick;
            this.lbl_EmailErr.Location = new System.Drawing.Point(404, 271);
            this.lbl_EmailErr.Name = "lbl_EmailErr";
            this.lbl_EmailErr.Size = new System.Drawing.Size(41, 13);
            this.lbl_EmailErr.TabIndex = 24;
            this.lbl_EmailErr.Text = "label13";
            this.lbl_EmailErr.Visible = false;
            // 
            // frm_DodajSmjestaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(473, 384);
            this.Controls.Add(this.lbl_EmailErr);
            this.Controls.Add(this.lbl_TelefonErr);
            this.Controls.Add(this.lbl_AdresaErr);
            this.Controls.Add(this.lbl_OpisErr);
            this.Controls.Add(this.lbl_GradErr);
            this.Controls.Add(this.lbl_UdaljenostErr);
            this.Controls.Add(this.lbl_NazivErr);
            this.Controls.Add(this.btn_Nazad);
            this.Controls.Add(this.btn_Dodaj);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rtb_Opis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_Naziv);
            this.Controls.Add(this.cb_Grad);
            this.Controls.Add(this.tb_Telefon);
            this.Controls.Add(this.tb_Adresa);
            this.Controls.Add(this.tb_Email);
            this.Controls.Add(this.tb_Udaljenost);
            this.Controls.Add(this.tb_Naziv);
            this.Name = "frm_DodajSmjestaj";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj Smještaj";
            this.Load += new System.EventHandler(this.frm_DodajSmjestaj_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Naziv;
        private System.Windows.Forms.TextBox tb_Udaljenost;
        private System.Windows.Forms.TextBox tb_Email;
        private System.Windows.Forms.TextBox tb_Adresa;
        private System.Windows.Forms.TextBox tb_Telefon;
        private System.Windows.Forms.ComboBox cb_Grad;
        private System.Windows.Forms.Label lbl_Naziv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtb_Opis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Dodaj;
        private System.Windows.Forms.Button btn_Nazad;
        private System.Windows.Forms.Label lbl_NazivErr;
        private System.Windows.Forms.Label lbl_UdaljenostErr;
        private System.Windows.Forms.Label lbl_GradErr;
        private System.Windows.Forms.Label lbl_OpisErr;
        private System.Windows.Forms.Label lbl_AdresaErr;
        private System.Windows.Forms.Label lbl_TelefonErr;
        private System.Windows.Forms.Label lbl_EmailErr;
    }
}