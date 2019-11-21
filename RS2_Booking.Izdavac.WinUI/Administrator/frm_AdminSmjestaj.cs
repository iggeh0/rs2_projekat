using RS2_Booking.Izdavac.WinUI.Smjestaj;
using RS2_Booking.Model;
using RS2_Booking.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RS2_Booking.Izdavac.WinUI.Administrator
{
    public partial class frm_AdminSmjestaj : Form
    {
        private readonly APIService _SmjestajService = new APIService("smjestaj");
        private readonly APIService _GradService = new APIService("grad");
        private readonly APIService _KorisnikService = new APIService("korisnik/getizdavaci");
        private int _IzdavacId;

        public frm_AdminSmjestaj()
        {
            InitializeComponent();
        }

        private async void btn_PretragaKorisnika_Click(object sender, EventArgs e)
        {
            var search = new KorisnikSearchRequest
            {
                Ime = tb_IzdavacIme.Text,
                KorisnickoIme = tb_KorisnickoIme.Text
            };

            var result = await _KorisnikService.Get<List<KorisnikModel>>(search);
            dgv_Izdavac.AutoGenerateColumns = false;
            dgv_Izdavac.DataSource = result;
        }

        private async void dgv_Izdavac_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Int32.Parse((dgv_Izdavac.Rows[e.RowIndex].Cells[0].Value.ToString()));
            SmjestajSearchRequest request = new SmjestajSearchRequest();
            request.IzdavacId = id;
            _IzdavacId = id;
            var result = await _SmjestajService.Get<List<SmjestajModel>>(request);
            dgv_Smjestaj.AutoGenerateColumns = false;
            dgv_Smjestaj.DataSource = result;
        }

        private void btn_Nazad_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void frm_AdminSmjestaj_Load(object sender, EventArgs e)
        {
            var lista = await _GradService.Get<List<GradModel>>(null);
            GradModel prazan = new GradModel
            {
                GradId = 0,
                Naziv = "Odaberite grad...."
            };
            lista.Insert(0, prazan);

            cb_Grad.DataSource = lista;
            cb_Grad.DisplayMember = "Naziv";
            cb_Grad.ValueMember = "GradId";

            _IzdavacId = 0;
        }

        private async void dgv_Smjestaj_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Smjestaj.CurrentCell.ColumnIndex.Equals(4))
            {
                var id = int.Parse(dgv_Smjestaj[e.ColumnIndex - 4, e.RowIndex].Value.ToString());
                frm_UrediSmjestaj Form = new frm_UrediSmjestaj(id, _IzdavacId);
                Form.Show();
            }


            else if (dgv_Smjestaj.CurrentCell.ColumnIndex.Equals(5))
            {
                var id = int.Parse(dgv_Smjestaj[e.ColumnIndex - 5, e.RowIndex].Value.ToString());
                await _SmjestajService.Delete<SmjestajModel>(id);
            }
        }

        private async void btn_PretragaSmjestaja_Click(object sender, EventArgs e)
        {
            var search = new SmjestajSearchRequest
            {
                GradId = cb_Grad.SelectedIndex,
                Naziv = tb_SmjestajNaziv.Text,
                IzdavacId = _IzdavacId
            };

            var result = await _SmjestajService.Get<List<SmjestajModel>>(search);
            dgv_Smjestaj.AutoGenerateColumns = false;
            dgv_Smjestaj.DataSource = result;

        }
    }
}