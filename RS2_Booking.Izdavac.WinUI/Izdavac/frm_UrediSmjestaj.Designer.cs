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
            this.btn_Nazad = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_OpisErr = new System.Windows.Forms.Label();
            this.lbl_EmailErr = new System.Windows.Forms.Label();
            this.lbl_TelefonErr = new System.Windows.Forms.Label();
            this.lbl_NazivErr = new System.Windows.Forms.Label();
            this.btn_Usluge = new System.Windows.Forms.Button();
            this.btn_Okoline = new System.Windows.Forms.Button();
            this.btn_Slike = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_SmjestajSobe
            // 
            this.btn_SmjestajSobe.Location = new System.Drawing.Point(60, 10);
            this.btn_SmjestajSobe.Name = "btn_SmjestajSobe";
            this.btn_SmjestajSobe.Size = new System.Drawing.Size(150, 50);
            this.btn_SmjestajSobe.TabIndex = 1;
            this.btn_SmjestajSobe.Text = "Upravljanje sobama";
            this.btn_SmjestajSobe.UseVisualStyleBackColor = true;
            this.btn_SmjestajSobe.Click += new System.EventHandler(this.btn_SmjestajSobe_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Naziv";
            // 
            // tb_Naziv
            // 
            this.tb_Naziv.Location = new System.Drawing.Point(9, 36);
            this.tb_Naziv.Name = "tb_Naziv";
            this.tb_Naziv.Size = new System.Drawing.Size(100, 20);
            this.tb_Naziv.TabIndex = 5;
            // 
            // tb_Telefon
            // 
            this.tb_Telefon.Location = new System.Drawing.Point(9, 75);
            this.tb_Telefon.Name = "tb_Telefon";
            this.tb_Telefon.Size = new System.Drawing.Size(100, 20);
            this.tb_Telefon.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Kontakt telefon";
            // 
            // tb_Email
            // 
            this.tb_Email.Location = new System.Drawing.Point(9, 118);
            this.tb_Email.Name = "tb_Email";
            this.tb_Email.Size = new System.Drawing.Size(100, 20);
            this.tb_Email.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "E-mail";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(175, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Opis";
            // 
            // tb_Opis
            // 
            this.tb_Opis.Location = new System.Drawing.Point(178, 42);
            this.tb_Opis.Name = "tb_Opis";
            this.tb_Opis.Size = new System.Drawing.Size(239, 117);
            this.tb_Opis.TabIndex = 13;
            this.tb_Opis.Text = "";
            // 
            // btn_Snimi
            // 
            this.btn_Snimi.Location = new System.Drawing.Point(81, 379);
            this.btn_Snimi.Name = "btn_Snimi";
            this.btn_Snimi.Size = new System.Drawing.Size(109, 23);
            this.btn_Snimi.TabIndex = 14;
            this.btn_Snimi.Text = "Snimi promjene";
            this.btn_Snimi.UseVisualStyleBackColor = true;
            this.btn_Snimi.Click += new System.EventHandler(this.btn_Snimi_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Grad:";
            // 
            // lbl_Grad
            // 
            this.lbl_Grad.AutoSize = true;
            this.lbl_Grad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Grad.Location = new System.Drawing.Point(79, 112);
            this.lbl_Grad.Name = "lbl_Grad";
            this.lbl_Grad.Size = new System.Drawing.Size(51, 20);
            this.lbl_Grad.TabIndex = 16;
            this.lbl_Grad.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(80, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Adresa:";
            // 
            // lbl_Adresa
            // 
            this.lbl_Adresa.AutoSize = true;
            this.lbl_Adresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Adresa.Location = new System.Drawing.Point(80, 158);
            this.lbl_Adresa.Name = "lbl_Adresa";
            this.lbl_Adresa.Size = new System.Drawing.Size(51, 20);
            this.lbl_Adresa.TabIndex = 18;
            this.lbl_Adresa.Text = "label8";
            // 
            // btn_Nazad
            // 
            this.btn_Nazad.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Nazad.Location = new System.Drawing.Point(81, 408);
            this.btn_Nazad.Name = "btn_Nazad";
            this.btn_Nazad.Size = new System.Drawing.Size(109, 23);
            this.btn_Nazad.TabIndex = 20;
            this.btn_Nazad.Text = "Nazad";
            this.btn_Nazad.UseVisualStyleBackColor = true;
            this.btn_Nazad.Click += new System.EventHandler(this.btn_Nazad_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_OpisErr);
            this.groupBox1.Controls.Add(this.lbl_EmailErr);
            this.groupBox1.Controls.Add(this.lbl_TelefonErr);
            this.groupBox1.Controls.Add(this.lbl_NazivErr);
            this.groupBox1.Controls.Add(this.tb_Opis);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tb_Email);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tb_Telefon);
            this.groupBox1.Controls.Add(this.tb_Naziv);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(81, 193);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(471, 171);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Izmjeni informacije";
            // 
            // lbl_OpisErr
            // 
            this.lbl_OpisErr.AutoSize = true;
            this.lbl_OpisErr.ForeColor = System.Drawing.Color.Red;
            this.lbl_OpisErr.Location = new System.Drawing.Point(423, 42);
            this.lbl_OpisErr.Name = "lbl_OpisErr";
            this.lbl_OpisErr.Size = new System.Drawing.Size(41, 13);
            this.lbl_OpisErr.TabIndex = 17;
            this.lbl_OpisErr.Text = "label10";
            this.lbl_OpisErr.Visible = false;
            // 
            // lbl_EmailErr
            // 
            this.lbl_EmailErr.AutoSize = true;
            this.lbl_EmailErr.ForeColor = System.Drawing.Color.Red;
            this.lbl_EmailErr.Location = new System.Drawing.Point(115, 118);
            this.lbl_EmailErr.Name = "lbl_EmailErr";
            this.lbl_EmailErr.Size = new System.Drawing.Size(35, 13);
            this.lbl_EmailErr.TabIndex = 16;
            this.lbl_EmailErr.Text = "label9";
            this.lbl_EmailErr.Visible = false;
            // 
            // lbl_TelefonErr
            // 
            this.lbl_TelefonErr.AutoSize = true;
            this.lbl_TelefonErr.ForeColor = System.Drawing.Color.Red;
            this.lbl_TelefonErr.Location = new System.Drawing.Point(115, 75);
            this.lbl_TelefonErr.Name = "lbl_TelefonErr";
            this.lbl_TelefonErr.Size = new System.Drawing.Size(35, 13);
            this.lbl_TelefonErr.TabIndex = 15;
            this.lbl_TelefonErr.Text = "label8";
            this.lbl_TelefonErr.Visible = false;
            // 
            // lbl_NazivErr
            // 
            this.lbl_NazivErr.AutoSize = true;
            this.lbl_NazivErr.ForeColor = System.Drawing.Color.Red;
            this.lbl_NazivErr.Location = new System.Drawing.Point(115, 39);
            this.lbl_NazivErr.Name = "lbl_NazivErr";
            this.lbl_NazivErr.Size = new System.Drawing.Size(35, 13);
            this.lbl_NazivErr.TabIndex = 14;
            this.lbl_NazivErr.Text = "label6";
            this.lbl_NazivErr.Visible = false;
            // 
            // btn_Usluge
            // 
            this.btn_Usluge.Location = new System.Drawing.Point(208, 10);
            this.btn_Usluge.Name = "btn_Usluge";
            this.btn_Usluge.Size = new System.Drawing.Size(150, 50);
            this.btn_Usluge.TabIndex = 14;
            this.btn_Usluge.Text = "Upravljanje Uslugama";
            this.btn_Usluge.UseVisualStyleBackColor = true;
            this.btn_Usluge.Click += new System.EventHandler(this.btn_Usluge_Click);
            // 
            // btn_Okoline
            // 
            this.btn_Okoline.Location = new System.Drawing.Point(356, 10);
            this.btn_Okoline.Name = "btn_Okoline";
            this.btn_Okoline.Size = new System.Drawing.Size(150, 50);
            this.btn_Okoline.TabIndex = 22;
            this.btn_Okoline.Text = "Upravljanje okolinama";
            this.btn_Okoline.UseVisualStyleBackColor = true;
            this.btn_Okoline.Click += new System.EventHandler(this.btn_Okoline_Click);
            // 
            // btn_Slike
            // 
            this.btn_Slike.Location = new System.Drawing.Point(506, 10);
            this.btn_Slike.Name = "btn_Slike";
            this.btn_Slike.Size = new System.Drawing.Size(150, 50);
            this.btn_Slike.TabIndex = 23;
            this.btn_Slike.Text = "Upravljanje Slikama";
            this.btn_Slike.UseVisualStyleBackColor = true;
            // 
            // frm_UrediSmjestaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Nazad;
            this.ClientSize = new System.Drawing.Size(673, 440);
            this.Controls.Add(this.btn_Slike);
            this.Controls.Add(this.btn_Okoline);
            this.Controls.Add(this.btn_Usluge);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Nazad);
            this.Controls.Add(this.lbl_Adresa);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbl_Grad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Snimi);
            this.Controls.Add(this.btn_SmjestajSobe);
            this.Name = "frm_UrediSmjestaj";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uredi Smještaj";
            this.Load += new System.EventHandler(this.frm_UrediSmjestaj_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Usluge;
        private System.Windows.Forms.Button btn_Okoline;
        private System.Windows.Forms.Label lbl_OpisErr;
        private System.Windows.Forms.Label lbl_EmailErr;
        private System.Windows.Forms.Label lbl_TelefonErr;
        private System.Windows.Forms.Label lbl_NazivErr;
    }
}