namespace RS2_Booking.Izdavac.WinUI.Smjestaj
{
    partial class frm_DodajSobe
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
            this.tb_BrojKreveta = new System.Windows.Forms.TextBox();
            this.tb_Cijena = new System.Windows.Forms.TextBox();
            this.tb_Vrsta = new System.Windows.Forms.TextBox();
            this.tb_Velicina = new System.Windows.Forms.TextBox();
            this.cb_Kupaonica = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Nazad = new System.Windows.Forms.Button();
            this.tb_Opis = new System.Windows.Forms.RichTextBox();
            this.btn_Snimi = new System.Windows.Forms.Button();
            this.lbl_brKrevetaError = new System.Windows.Forms.Label();
            this.lbl_cijenaErr = new System.Windows.Forms.Label();
            this.lbl_VrstaErr = new System.Windows.Forms.Label();
            this.lbl_VelicinaErr = new System.Windows.Forms.Label();
            this.lbl_OpisErr = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_BrojKreveta
            // 
            this.tb_BrojKreveta.Location = new System.Drawing.Point(114, 40);
            this.tb_BrojKreveta.Name = "tb_BrojKreveta";
            this.tb_BrojKreveta.Size = new System.Drawing.Size(23, 20);
            this.tb_BrojKreveta.TabIndex = 0;
            // 
            // tb_Cijena
            // 
            this.tb_Cijena.Location = new System.Drawing.Point(116, 80);
            this.tb_Cijena.Name = "tb_Cijena";
            this.tb_Cijena.Size = new System.Drawing.Size(21, 20);
            this.tb_Cijena.TabIndex = 1;
            // 
            // tb_Vrsta
            // 
            this.tb_Vrsta.Location = new System.Drawing.Point(116, 166);
            this.tb_Vrsta.Name = "tb_Vrsta";
            this.tb_Vrsta.Size = new System.Drawing.Size(120, 20);
            this.tb_Vrsta.TabIndex = 2;
            // 
            // tb_Velicina
            // 
            this.tb_Velicina.Location = new System.Drawing.Point(114, 125);
            this.tb_Velicina.Name = "tb_Velicina";
            this.tb_Velicina.Size = new System.Drawing.Size(23, 20);
            this.tb_Velicina.TabIndex = 4;
            // 
            // cb_Kupaonica
            // 
            this.cb_Kupaonica.AutoSize = true;
            this.cb_Kupaonica.ForeColor = System.Drawing.Color.White;
            this.cb_Kupaonica.Location = new System.Drawing.Point(12, 196);
            this.cb_Kupaonica.Name = "cb_Kupaonica";
            this.cb_Kupaonica.Size = new System.Drawing.Size(113, 17);
            this.cb_Kupaonica.TabIndex = 5;
            this.cb_Kupaonica.Text = "Vlastita kupaonica";
            this.cb_Kupaonica.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Broj Kreveta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(10, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cijena (KM)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Vrsta Smještaja";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(170, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Opis";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(10, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Veličina sobe (m²)";
            // 
            // btn_Nazad
            // 
            this.btn_Nazad.BackColor = System.Drawing.Color.Red;
            this.btn_Nazad.CausesValidation = false;
            this.btn_Nazad.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Nazad.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_Nazad.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_Nazad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_Nazad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Nazad.ForeColor = System.Drawing.Color.White;
            this.btn_Nazad.Location = new System.Drawing.Point(233, 237);
            this.btn_Nazad.Name = "btn_Nazad";
            this.btn_Nazad.Size = new System.Drawing.Size(75, 23);
            this.btn_Nazad.TabIndex = 12;
            this.btn_Nazad.Text = "Nazad";
            this.btn_Nazad.UseVisualStyleBackColor = false;
            this.btn_Nazad.Click += new System.EventHandler(this.btn_Nazad_Click);
            // 
            // tb_Opis
            // 
            this.tb_Opis.Location = new System.Drawing.Point(212, 45);
            this.tb_Opis.Name = "tb_Opis";
            this.tb_Opis.Size = new System.Drawing.Size(100, 96);
            this.tb_Opis.TabIndex = 13;
            this.tb_Opis.Text = "";
            // 
            // btn_Snimi
            // 
            this.btn_Snimi.BackColor = System.Drawing.Color.Green;
            this.btn_Snimi.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btn_Snimi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btn_Snimi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btn_Snimi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Snimi.ForeColor = System.Drawing.Color.White;
            this.btn_Snimi.Location = new System.Drawing.Point(233, 208);
            this.btn_Snimi.Name = "btn_Snimi";
            this.btn_Snimi.Size = new System.Drawing.Size(75, 23);
            this.btn_Snimi.TabIndex = 15;
            this.btn_Snimi.Text = "Snimi";
            this.btn_Snimi.UseVisualStyleBackColor = false;
            this.btn_Snimi.Click += new System.EventHandler(this.btn_Snimi_Click);
            // 
            // lbl_brKrevetaError
            // 
            this.lbl_brKrevetaError.AutoSize = true;
            this.lbl_brKrevetaError.ForeColor = System.Drawing.Color.Red;
            this.lbl_brKrevetaError.Location = new System.Drawing.Point(114, 21);
            this.lbl_brKrevetaError.Name = "lbl_brKrevetaError";
            this.lbl_brKrevetaError.Size = new System.Drawing.Size(35, 13);
            this.lbl_brKrevetaError.TabIndex = 16;
            this.lbl_brKrevetaError.Text = "label6";
            this.lbl_brKrevetaError.Visible = false;
            // 
            // lbl_cijenaErr
            // 
            this.lbl_cijenaErr.AutoSize = true;
            this.lbl_cijenaErr.ForeColor = System.Drawing.Color.Red;
            this.lbl_cijenaErr.Location = new System.Drawing.Point(114, 65);
            this.lbl_cijenaErr.Name = "lbl_cijenaErr";
            this.lbl_cijenaErr.Size = new System.Drawing.Size(35, 13);
            this.lbl_cijenaErr.TabIndex = 17;
            this.lbl_cijenaErr.Text = "label7";
            this.lbl_cijenaErr.Visible = false;
            // 
            // lbl_VrstaErr
            // 
            this.lbl_VrstaErr.AutoSize = true;
            this.lbl_VrstaErr.ForeColor = System.Drawing.Color.Red;
            this.lbl_VrstaErr.Location = new System.Drawing.Point(114, 150);
            this.lbl_VrstaErr.Name = "lbl_VrstaErr";
            this.lbl_VrstaErr.Size = new System.Drawing.Size(35, 13);
            this.lbl_VrstaErr.TabIndex = 18;
            this.lbl_VrstaErr.Text = "label8";
            this.lbl_VrstaErr.Visible = false;
            // 
            // lbl_VelicinaErr
            // 
            this.lbl_VelicinaErr.AutoSize = true;
            this.lbl_VelicinaErr.ForeColor = System.Drawing.Color.Red;
            this.lbl_VelicinaErr.Location = new System.Drawing.Point(112, 109);
            this.lbl_VelicinaErr.Name = "lbl_VelicinaErr";
            this.lbl_VelicinaErr.Size = new System.Drawing.Size(35, 13);
            this.lbl_VelicinaErr.TabIndex = 19;
            this.lbl_VelicinaErr.Text = "label9";
            this.lbl_VelicinaErr.Visible = false;
            // 
            // lbl_OpisErr
            // 
            this.lbl_OpisErr.AutoSize = true;
            this.lbl_OpisErr.ForeColor = System.Drawing.Color.Red;
            this.lbl_OpisErr.Location = new System.Drawing.Point(209, 29);
            this.lbl_OpisErr.Name = "lbl_OpisErr";
            this.lbl_OpisErr.Size = new System.Drawing.Size(41, 13);
            this.lbl_OpisErr.TabIndex = 20;
            this.lbl_OpisErr.Text = "label10";
            this.lbl_OpisErr.Visible = false;
            // 
            // frm_DodajSobe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.CancelButton = this.btn_Nazad;
            this.ClientSize = new System.Drawing.Size(336, 268);
            this.Controls.Add(this.lbl_OpisErr);
            this.Controls.Add(this.lbl_VelicinaErr);
            this.Controls.Add(this.lbl_VrstaErr);
            this.Controls.Add(this.lbl_cijenaErr);
            this.Controls.Add(this.lbl_brKrevetaError);
            this.Controls.Add(this.btn_Snimi);
            this.Controls.Add(this.tb_Opis);
            this.Controls.Add(this.btn_Nazad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_Kupaonica);
            this.Controls.Add(this.tb_Velicina);
            this.Controls.Add(this.tb_Vrsta);
            this.Controls.Add(this.tb_Cijena);
            this.Controls.Add(this.tb_BrojKreveta);
            this.Name = "frm_DodajSobe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj Sobu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_BrojKreveta;
        private System.Windows.Forms.TextBox tb_Cijena;
        private System.Windows.Forms.TextBox tb_Vrsta;
        private System.Windows.Forms.TextBox tb_Velicina;
        private System.Windows.Forms.CheckBox cb_Kupaonica;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Nazad;
        private System.Windows.Forms.RichTextBox tb_Opis;
        private System.Windows.Forms.Button btn_Snimi;
        private System.Windows.Forms.Label lbl_brKrevetaError;
        private System.Windows.Forms.Label lbl_cijenaErr;
        private System.Windows.Forms.Label lbl_VrstaErr;
        private System.Windows.Forms.Label lbl_VelicinaErr;
        private System.Windows.Forms.Label lbl_OpisErr;
    }
}