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
            this.components = new System.ComponentModel.Container();
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
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_BrojKreveta
            // 
            this.tb_BrojKreveta.Location = new System.Drawing.Point(114, 45);
            this.tb_BrojKreveta.Name = "tb_BrojKreveta";
            this.tb_BrojKreveta.Size = new System.Drawing.Size(100, 20);
            this.tb_BrojKreveta.TabIndex = 0;
            this.tb_BrojKreveta.Validating += new System.ComponentModel.CancelEventHandler(this.tb_BrojKreveta_Validating);
            // 
            // tb_Cijena
            // 
            this.tb_Cijena.Location = new System.Drawing.Point(114, 72);
            this.tb_Cijena.Name = "tb_Cijena";
            this.tb_Cijena.Size = new System.Drawing.Size(100, 20);
            this.tb_Cijena.TabIndex = 1;
            this.tb_Cijena.Validating += new System.ComponentModel.CancelEventHandler(this.tb_Cijena_Validating);
            // 
            // tb_Vrsta
            // 
            this.tb_Vrsta.Location = new System.Drawing.Point(114, 100);
            this.tb_Vrsta.Name = "tb_Vrsta";
            this.tb_Vrsta.Size = new System.Drawing.Size(100, 20);
            this.tb_Vrsta.TabIndex = 2;
            this.tb_Vrsta.Validating += new System.ComponentModel.CancelEventHandler(this.tb_Vrsta_Validating);
            // 
            // tb_Velicina
            // 
            this.tb_Velicina.Location = new System.Drawing.Point(114, 126);
            this.tb_Velicina.Name = "tb_Velicina";
            this.tb_Velicina.Size = new System.Drawing.Size(100, 20);
            this.tb_Velicina.TabIndex = 4;
            this.tb_Velicina.Validating += new System.ComponentModel.CancelEventHandler(this.tb_Velicina_Validating);
            // 
            // cb_Kupaonica
            // 
            this.cb_Kupaonica.AutoSize = true;
            this.cb_Kupaonica.Location = new System.Drawing.Point(114, 152);
            this.cb_Kupaonica.Name = "cb_Kupaonica";
            this.cb_Kupaonica.Size = new System.Drawing.Size(113, 17);
            this.cb_Kupaonica.TabIndex = 5;
            this.cb_Kupaonica.Text = "Vlastita kupaonica";
            this.cb_Kupaonica.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Broj Kreveta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cijena";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Vrsta Smještaja";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(254, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Opis";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Veličina sobe (m²)";
            // 
            // btn_Nazad
            // 
            this.btn_Nazad.CausesValidation = false;
            this.btn_Nazad.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Nazad.Location = new System.Drawing.Point(15, 229);
            this.btn_Nazad.Name = "btn_Nazad";
            this.btn_Nazad.Size = new System.Drawing.Size(75, 23);
            this.btn_Nazad.TabIndex = 12;
            this.btn_Nazad.Text = "Nazad";
            this.btn_Nazad.UseVisualStyleBackColor = true;
            this.btn_Nazad.Click += new System.EventHandler(this.btn_Nazad_Click);
            // 
            // tb_Opis
            // 
            this.tb_Opis.Location = new System.Drawing.Point(288, 45);
            this.tb_Opis.Name = "tb_Opis";
            this.tb_Opis.Size = new System.Drawing.Size(100, 96);
            this.tb_Opis.TabIndex = 13;
            this.tb_Opis.Text = "";
            this.tb_Opis.Validating += new System.ComponentModel.CancelEventHandler(this.tb_Opis_Validating);
            // 
            // btn_Snimi
            // 
            this.btn_Snimi.Location = new System.Drawing.Point(14, 200);
            this.btn_Snimi.Name = "btn_Snimi";
            this.btn_Snimi.Size = new System.Drawing.Size(75, 23);
            this.btn_Snimi.TabIndex = 15;
            this.btn_Snimi.Text = "Snimi";
            this.btn_Snimi.UseVisualStyleBackColor = true;
            this.btn_Snimi.Click += new System.EventHandler(this.btn_Snimi_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // frm_DodajSobe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Nazad;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Text = "Dodaj Sobu";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
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
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}