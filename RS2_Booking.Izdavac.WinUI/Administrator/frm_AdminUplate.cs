using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RS2_Booking.Model;

namespace RS2_Booking.Izdavac.WinUI.Administrator
{
    public partial class frm_AdminUplate : Form
    {
        private readonly APIService _uplataService = new APIService("rezervacija/getuplate");

        public frm_AdminUplate()
        {
            InitializeComponent();
        }

        private async void btn_Pretrazi_Click(object sender, EventArgs e)
        {
            UplataModel searchrequest = new UplataModel();
            if (!string.IsNullOrEmpty(tb_Pretraga.Text) && tb_Pretraga.Text.Length > 2)
            {
                List<UplataModel> Lista = await _uplataService.Get<List<UplataModel>>(searchrequest);
                dgv_Uplate.DataSource = Lista;
            }


        }

        private void btn_Nazad_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
