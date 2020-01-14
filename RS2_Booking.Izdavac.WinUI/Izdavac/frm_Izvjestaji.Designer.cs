namespace RS2_Booking.Izdavac.WinUI.Izdavac
{
    partial class frm_Izvjestaji
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
            this.dgv_Smjestaji = new System.Windows.Forms.DataGridView();
            this.dgv_Klijenti = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Smjestaji)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Klijenti)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Smjestaji
            // 
            this.dgv_Smjestaji.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Smjestaji.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Smjestaji.Location = new System.Drawing.Point(3, 16);
            this.dgv_Smjestaji.Name = "dgv_Smjestaji";
            this.dgv_Smjestaji.Size = new System.Drawing.Size(289, 298);
            this.dgv_Smjestaji.TabIndex = 0;
            // 
            // dgv_Klijenti
            // 
            this.dgv_Klijenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Klijenti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Klijenti.Location = new System.Drawing.Point(3, 16);
            this.dgv_Klijenti.Name = "dgv_Klijenti";
            this.dgv_Klijenti.Size = new System.Drawing.Size(328, 295);
            this.dgv_Klijenti.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_Smjestaji);
            this.groupBox1.Location = new System.Drawing.Point(30, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 317);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Najaktivniji smještaji";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_Klijenti);
            this.groupBox2.Location = new System.Drawing.Point(399, 72);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(334, 314);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Najaktivniji klijenti";
            // 
            // frm_Izvjestaji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_Izvjestaji";
            this.Text = "frm_Izvjestaji";
            this.Load += new System.EventHandler(this.frm_Izvjestaji_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Smjestaji)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Klijenti)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Smjestaji;
        private System.Windows.Forms.DataGridView dgv_Klijenti;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}