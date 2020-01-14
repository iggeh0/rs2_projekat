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

namespace RS2_Booking.Izdavac.WinUI.Izdavac
{
    public partial class frm_Izvjestaji : Form
    {
        private readonly APIService _service = new APIService("smjestaj/getizvjestaj");
        private int _IzdavacId;
        public frm_Izvjestaji(int IzdavacId)
        {
            InitializeComponent();
            _IzdavacId = IzdavacId;
        }

        private async void frm_Izvjestaji_Load(object sender, EventArgs e)
        {
            IzvjestajModel Model = await _service.Get<IzvjestajModel>(_IzdavacId);
            dgv_Klijenti.DataSource = Model.KorisniciDioVar;
            dgv_Smjestaji.DataSource = Model.SmjestajDioVar;
        }
    }
}
