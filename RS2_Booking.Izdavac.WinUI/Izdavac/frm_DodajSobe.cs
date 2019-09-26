using RS2_Booking.Model;
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
    public partial class frm_DodajSobe : Form
    {
        private readonly APIService _SmjestajService = new APIService("soba");
        private readonly int _SmjestajId;
        public frm_DodajSobe(int SmjestajId)
        {
            _SmjestajId = SmjestajId;
            InitializeComponent();
        }

        private void btn_Nazad_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Dodaj_Click(object sender, EventArgs e)
        {

        }

        private void btn_Snimi_Click(object sender, EventArgs e)
        {

        }
    }
}
