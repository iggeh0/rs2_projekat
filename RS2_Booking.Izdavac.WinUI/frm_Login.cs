using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RS2_Booking.Izdavac.WinUI.Smjestaj;
namespace RS2_Booking.Izdavac.WinUI
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_Smjestaj form = new frm_Smjestaj(1);
            form.Show();
            this.Close();
        }
    }
}
