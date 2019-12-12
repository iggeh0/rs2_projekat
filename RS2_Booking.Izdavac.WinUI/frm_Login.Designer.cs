namespace RS2_Booking.Izdavac.WinUI
{
    partial class frm_Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_KorisnickoIme = new System.Windows.Forms.TextBox();
            this.tb_Lozinka = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_Uloga = new System.Windows.Forms.ComboBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.btn_Registracija = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Korisničko Ime:";
            // 
            // tb_KorisnickoIme
            // 
            this.tb_KorisnickoIme.Location = new System.Drawing.Point(115, 19);
            this.tb_KorisnickoIme.Name = "tb_KorisnickoIme";
            this.tb_KorisnickoIme.Size = new System.Drawing.Size(100, 20);
            this.tb_KorisnickoIme.TabIndex = 1;
            // 
            // tb_Lozinka
            // 
            this.tb_Lozinka.Location = new System.Drawing.Point(115, 42);
            this.tb_Lozinka.Name = "tb_Lozinka";
            this.tb_Lozinka.PasswordChar = '*';
            this.tb_Lozinka.Size = new System.Drawing.Size(100, 20);
            this.tb_Lozinka.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lozinka:";
            // 
            // cb_Uloga
            // 
            this.cb_Uloga.FormattingEnabled = true;
            this.cb_Uloga.Location = new System.Drawing.Point(115, 68);
            this.cb_Uloga.Name = "cb_Uloga";
            this.cb_Uloga.Size = new System.Drawing.Size(121, 21);
            this.cb_Uloga.TabIndex = 4;
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(115, 106);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(75, 23);
            this.btn_Login.TabIndex = 5;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // btn_Registracija
            // 
            this.btn_Registracija.Location = new System.Drawing.Point(115, 136);
            this.btn_Registracija.Name = "btn_Registracija";
            this.btn_Registracija.Size = new System.Drawing.Size(75, 23);
            this.btn_Registracija.TabIndex = 6;
            this.btn_Registracija.Text = "Registracija";
            this.btn_Registracija.UseVisualStyleBackColor = true;
            this.btn_Registracija.Click += new System.EventHandler(this.btn_Registracija_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Uloga:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 176);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Registracija);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.cb_Uloga);
            this.Controls.Add(this.tb_Lozinka);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_KorisnickoIme);
            this.Controls.Add(this.label1);
            this.Name = "frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_KorisnickoIme;
        private System.Windows.Forms.TextBox tb_Lozinka;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_Uloga;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Button btn_Registracija;
        private System.Windows.Forms.Label label3;
    }
}