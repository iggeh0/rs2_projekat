using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Flurl.Http;
using Flurl;
using RS2_Booking.Model;
using RS2_Booking.Model.Requests;
using Newtonsoft.Json;

namespace RS2_Booking.Izdavac.WinUI.Smjestaj
{
    public partial class frm_Smjestaj : Form
    {
        private readonly APIService _SmjestajService = new APIService("smjestaj");
        private readonly APIService _GradService = new APIService("grad");
        private readonly int _IzdavacId;
        public frm_Smjestaj(int IzdavacId)
        {
            _IzdavacId = IzdavacId;
            InitializeComponent();
        }

        private async void btn_Filtriraj_Click(object sender, EventArgs e)
        {
            var search = new SmjestajSearchRequest
            {
                GradId = cb_GradPretraga.SelectedIndex,
                Naziv = tb_NazivPretraga.Text,
                IzdavacId = _IzdavacId
            };
          
            var result = await _SmjestajService.Get<List<SmjestajModel>>(search);          
            dgv_Smjestaj.AutoGenerateColumns = false;
            dgv_Smjestaj.DataSource = result;
        }

        private void dgv_Smjestaj_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Smjestaj.CurrentCell.ColumnIndex.Equals(3) && e.RowIndex != -1)
            {
                if (dgv_Smjestaj.CurrentCell != null)
                {
                    var id = int.Parse(dgv_Smjestaj[e.ColumnIndex + 2, e.RowIndex].Value.ToString());
                    frm_UrediSmjestaj Form = new frm_UrediSmjestaj(id);
                    Form.Show();
                }
                    
                }
                else if (dgv_Smjestaj.CurrentCell.ColumnIndex.Equals(4))
                {
                    MessageBox.Show("Kliknut je izbriši");
                }
        }

        private void btn_DodajSmjestaj_Click(object sender, EventArgs e)
        {

        }

        private void btn_Uredi_Click(object sender, EventArgs e)
        {

        }

        private void btn_Report_Click(object sender, EventArgs e)
        {

        }

        private void btn_UrediProfil_Click(object sender, EventArgs e)
        {

        }

        private void btn_Rezervacije_Click(object sender, EventArgs e)
        {

        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {

        }

        private async void frm_Smjestaj_Load(object sender, EventArgs e)
        {
            var lista = await _GradService.Get<List<GradModel>>(null);
            GradModel prazan = new GradModel
            {
                GradId = 0,
                Naziv = "Odaberite grad...."
            };
            lista.Insert(0, prazan);

            cb_GradPretraga.DataSource = lista;
            cb_GradPretraga.DisplayMember = "Naziv";
            cb_GradPretraga.ValueMember = "GradId";
        }
    }
}