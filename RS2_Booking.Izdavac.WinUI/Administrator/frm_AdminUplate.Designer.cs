namespace RS2_Booking.Izdavac.WinUI.Administrator
{
    partial class frm_AdminUplate
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
            this.dgv_Uplate = new System.Windows.Forms.DataGridView();
            this.btn_Nazad = new System.Windows.Forms.Button();
            this.btn_Pretrazi = new System.Windows.Forms.Button();
            this.tb_Pretraga = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Uplate)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Uplate
            // 
            this.dgv_Uplate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Uplate.Location = new System.Drawing.Point(59, 91);
            this.dgv_Uplate.Name = "dgv_Uplate";
            this.dgv_Uplate.Size = new System.Drawing.Size(611, 242);
            this.dgv_Uplate.TabIndex = 0;
            // 
            // btn_Nazad
            // 
            this.btn_Nazad.Location = new System.Drawing.Point(325, 397);
            this.btn_Nazad.Name = "btn_Nazad";
            this.btn_Nazad.Size = new System.Drawing.Size(75, 23);
            this.btn_Nazad.TabIndex = 1;
            this.btn_Nazad.Text = "Nazad";
            this.btn_Nazad.UseVisualStyleBackColor = true;
            this.btn_Nazad.Click += new System.EventHandler(this.btn_Nazad_Click);
            // 
            // btn_Pretrazi
            // 
            this.btn_Pretrazi.Location = new System.Drawing.Point(297, 62);
            this.btn_Pretrazi.Name = "btn_Pretrazi";
            this.btn_Pretrazi.Size = new System.Drawing.Size(75, 23);
            this.btn_Pretrazi.TabIndex = 2;
            this.btn_Pretrazi.Text = "Pretraži";
            this.btn_Pretrazi.UseVisualStyleBackColor = true;
            this.btn_Pretrazi.Click += new System.EventHandler(this.btn_Pretrazi_Click);
            // 
            // tb_Pretraga
            // 
            this.tb_Pretraga.Location = new System.Drawing.Point(124, 65);
            this.tb_Pretraga.Name = "tb_Pretraga";
            this.tb_Pretraga.Size = new System.Drawing.Size(155, 20);
            this.tb_Pretraga.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Sifra Uplate";
            // 
            // frm_AdminUplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_Pretraga);
            this.Controls.Add(this.btn_Pretrazi);
            this.Controls.Add(this.btn_Nazad);
            this.Controls.Add(this.dgv_Uplate);
            this.Name = "frm_AdminUplate";
            this.Text = "frm_AdminUplate";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Uplate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Uplate;
        private System.Windows.Forms.Button btn_Nazad;
        private System.Windows.Forms.Button btn_Pretrazi;
        private System.Windows.Forms.TextBox tb_Pretraga;
        private System.Windows.Forms.Label label1;
    }
}