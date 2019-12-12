namespace RS2_Booking.Izdavac.WinUI.Administrator
{
    partial class frm_AdminIndex
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
            this.lbl_Ime = new System.Windows.Forms.Label();
            this.btn_Korisnici = new System.Windows.Forms.Button();
            this.btn_Smjestaj = new System.Windows.Forms.Button();
            this.btn_Uplate = new System.Windows.Forms.Button();
            this.btn_UrediProfil = new System.Windows.Forms.Button();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dobrodošli";
            // 
            // lbl_Ime
            // 
            this.lbl_Ime.AutoSize = true;
            this.lbl_Ime.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ime.Location = new System.Drawing.Point(281, 9);
            this.lbl_Ime.Name = "lbl_Ime";
            this.lbl_Ime.Size = new System.Drawing.Size(118, 42);
            this.lbl_Ime.TabIndex = 1;
            this.lbl_Ime.Text = "label2";
            // 
            // btn_Korisnici
            // 
            this.btn_Korisnici.Location = new System.Drawing.Point(85, 83);
            this.btn_Korisnici.Name = "btn_Korisnici";
            this.btn_Korisnici.Size = new System.Drawing.Size(598, 68);
            this.btn_Korisnici.TabIndex = 2;
            this.btn_Korisnici.Text = "Upravljanje Korisnicima";
            this.btn_Korisnici.UseVisualStyleBackColor = true;
            this.btn_Korisnici.Click += new System.EventHandler(this.btn_Korisnici_Click);
            // 
            // btn_Smjestaj
            // 
            this.btn_Smjestaj.Location = new System.Drawing.Point(85, 157);
            this.btn_Smjestaj.Name = "btn_Smjestaj";
            this.btn_Smjestaj.Size = new System.Drawing.Size(598, 68);
            this.btn_Smjestaj.TabIndex = 3;
            this.btn_Smjestaj.Text = "Upravljanje Smještajima";
            this.btn_Smjestaj.UseVisualStyleBackColor = true;
            this.btn_Smjestaj.Click += new System.EventHandler(this.btn_Smjestaj_Click);
            // 
            // btn_Uplate
            // 
            this.btn_Uplate.Location = new System.Drawing.Point(85, 231);
            this.btn_Uplate.Name = "btn_Uplate";
            this.btn_Uplate.Size = new System.Drawing.Size(598, 68);
            this.btn_Uplate.TabIndex = 4;
            this.btn_Uplate.Text = "Upravljanje Uplatama";
            this.btn_Uplate.UseVisualStyleBackColor = true;
            // 
            // btn_UrediProfil
            // 
            this.btn_UrediProfil.Location = new System.Drawing.Point(85, 361);
            this.btn_UrediProfil.Name = "btn_UrediProfil";
            this.btn_UrediProfil.Size = new System.Drawing.Size(107, 77);
            this.btn_UrediProfil.TabIndex = 5;
            this.btn_UrediProfil.Text = "Uredi profil";
            this.btn_UrediProfil.UseVisualStyleBackColor = true;
            this.btn_UrediProfil.Click += new System.EventHandler(this.btn_UrediProfil_Click);
            // 
            // btn_Logout
            // 
            this.btn_Logout.Location = new System.Drawing.Point(576, 361);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(107, 77);
            this.btn_Logout.TabIndex = 6;
            this.btn_Logout.Text = "Izloguj se";
            this.btn_Logout.UseVisualStyleBackColor = true;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // frm_AdminIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.btn_UrediProfil);
            this.Controls.Add(this.btn_Uplate);
            this.Controls.Add(this.btn_Smjestaj);
            this.Controls.Add(this.btn_Korisnici);
            this.Controls.Add(this.lbl_Ime);
            this.Controls.Add(this.label1);
            this.Name = "frm_AdminIndex";
            this.Text = "frm_AdminIndex";
            this.Load += new System.EventHandler(this.frm_AdminIndex_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Ime;
        private System.Windows.Forms.Button btn_Korisnici;
        private System.Windows.Forms.Button btn_Smjestaj;
        private System.Windows.Forms.Button btn_Uplate;
        private System.Windows.Forms.Button btn_UrediProfil;
        private System.Windows.Forms.Button btn_Logout;
    }
}