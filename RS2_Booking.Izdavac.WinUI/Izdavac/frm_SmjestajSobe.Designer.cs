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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_Sobe = new System.Windows.Forms.DataGridView();
            this.btn_DodajSobu = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Sobe)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_Sobe);
            this.groupBox1.Location = new System.Drawing.Point(12, 155);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(688, 178);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Trenutno dostupne sobe u smještaju";
            // 
            // dgv_Sobe
            // 
            this.dgv_Sobe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Sobe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Sobe.Location = new System.Drawing.Point(3, 16);
            this.dgv_Sobe.Name = "dgv_Sobe";
            this.dgv_Sobe.Size = new System.Drawing.Size(682, 159);
            this.dgv_Sobe.TabIndex = 0;
            // 
            // btn_DodajSobu
            // 
            this.btn_DodajSobu.Location = new System.Drawing.Point(27, 13);
            this.btn_DodajSobu.Name = "btn_DodajSobu";
            this.btn_DodajSobu.Size = new System.Drawing.Size(126, 60);
            this.btn_DodajSobu.TabIndex = 1;
            this.btn_DodajSobu.Text = "Dodaj novu sobu";
            this.btn_DodajSobu.UseVisualStyleBackColor = true;
            this.btn_DodajSobu.Click += new System.EventHandler(this.btn_DodajSobu_Click);
            // 
            // frm_SmjestajSobe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_DodajSobu);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_SmjestajSobe";
            this.Text = "Uredi Sobe";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Sobe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_Sobe;
        private System.Windows.Forms.Button btn_DodajSobu;
    }
}