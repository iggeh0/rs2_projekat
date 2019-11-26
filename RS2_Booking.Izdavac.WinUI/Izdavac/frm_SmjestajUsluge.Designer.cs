namespace RS2_Booking.Izdavac.WinUI.Smjestaj
{
    partial class frm_SmjestajUsluge
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_Usluge = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Dodaj_Novu = new System.Windows.Forms.Button();
            this.tb_Naziv_Nova = new System.Windows.Forms.TextBox();
            this.tb_Opis_Nova = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Usluge)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.groupBox1.Controls.Add(this.dgv_Usluge);
            this.groupBox1.Location = new System.Drawing.Point(90, 153);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(540, 147);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Trenutne usluge u ponudi";
            // 
            // dgv_Usluge
            // 
            this.dgv_Usluge.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Usluge.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Usluge.Location = new System.Drawing.Point(3, 16);
            this.dgv_Usluge.Name = "dgv_Usluge";
            this.dgv_Usluge.Size = new System.Drawing.Size(534, 128);
            this.dgv_Usluge.TabIndex = 0;
            this.dgv_Usluge.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Usluge_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tb_Opis_Nova);
            this.groupBox2.Controls.Add(this.tb_Naziv_Nova);
            this.groupBox2.Controls.Add(this.btn_Dodaj_Novu);
            this.groupBox2.Location = new System.Drawing.Point(93, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(293, 135);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dodaj novu uslugu";
            // 
            // btn_Dodaj_Novu
            // 
            this.btn_Dodaj_Novu.Location = new System.Drawing.Point(6, 106);
            this.btn_Dodaj_Novu.Name = "btn_Dodaj_Novu";
            this.btn_Dodaj_Novu.Size = new System.Drawing.Size(75, 23);
            this.btn_Dodaj_Novu.TabIndex = 1;
            this.btn_Dodaj_Novu.Text = "Dodaj";
            this.btn_Dodaj_Novu.UseVisualStyleBackColor = true;
            this.btn_Dodaj_Novu.Click += new System.EventHandler(this.btn_Dodaj_Novu_Click);
            // 
            // tb_Naziv_Nova
            // 
            this.tb_Naziv_Nova.Location = new System.Drawing.Point(6, 40);
            this.tb_Naziv_Nova.Name = "tb_Naziv_Nova";
            this.tb_Naziv_Nova.Size = new System.Drawing.Size(100, 20);
            this.tb_Naziv_Nova.TabIndex = 2;
            // 
            // tb_Opis_Nova
            // 
            this.tb_Opis_Nova.Location = new System.Drawing.Point(6, 78);
            this.tb_Opis_Nova.Name = "tb_Opis_Nova";
            this.tb_Opis_Nova.Size = new System.Drawing.Size(100, 20);
            this.tb_Opis_Nova.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Naziv usluge:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Opis usluge:";
            // 
            // frm_SmjestajUsluge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_SmjestajUsluge";
            this.Text = "Uredi Usluge";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Usluge)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_Usluge;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Dodaj_Novu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Opis_Nova;
        private System.Windows.Forms.TextBox tb_Naziv_Nova;
    }
}