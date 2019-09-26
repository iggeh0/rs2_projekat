using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RS2_Booking.Izdavac.WinUI.Smjestaj
{
    public partial class frm_SmjestajSobe : Form
    {
        private int _SmjestajId = 0;

        public frm_SmjestajSobe(int SmjestajId)
        {
            _SmjestajId = SmjestajId;
            InitializeComponent();
        }

        private void btn_DodajSobu_Click(object sender, EventArgs e)
        {
            frm_DodajSobe Form = new frm_DodajSobe(_SmjestajId);
            Form.Show();
        }
    }
}
