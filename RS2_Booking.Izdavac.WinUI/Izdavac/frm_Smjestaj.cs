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
        private readonly int _KorisnikId;

        public frm_Smjestaj(int KorisnikId, int IzdavacId)
        {
            _KorisnikId = KorisnikId;
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
            dgv_Smjestaj.DataSource = result;
        }

        private async void dgv_Smjestaj_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Smjestaj.CurrentCell.ColumnIndex.Equals(3) && e.RowIndex != -1)
            {
                if (dgv_Smjestaj.CurrentCell != null)
                {
                    var id = int.Parse(dgv_Smjestaj[e.ColumnIndex + 2, e.RowIndex].Value.ToString());
                    frm_UrediSmjestaj Form = new frm_UrediSmjestaj(id, _IzdavacId);
                    Form.Show();
                    //Close();
                }
                    
                }
                else if (dgv_Smjestaj.CurrentCell.ColumnIndex.Equals(4))
                {
                   var id = int.Parse(dgv_Smjestaj[e.ColumnIndex + 1, e.RowIndex].Value.ToString());
                   await _SmjestajService.Delete<SmjestajModel>(id);
                    var search = new SmjestajSearchRequest
                    {
                        GradId = 0,
                        Naziv = null,
                        IzdavacId = _IzdavacId
                    };

                    var result = await _SmjestajService.Get<List<SmjestajModel>>(search);
                    dgv_Smjestaj.DataSource = result;
            }
        }

        private void btn_DodajSmjestaj_Click(object sender, EventArgs e)
        {
            frm_DodajSmjestaj form = new frm_DodajSmjestaj(_IzdavacId);
            form.Show();
        }

        private void btn_Report_Click(object sender, EventArgs e)
        {

        }

        private void btn_UrediProfil_Click(object sender, EventArgs e)
        {
            frm_Korisnik form = new frm_Korisnik(_KorisnikId, 1);
            form.Show();
        }

        private void btn_Rezervacije_Click(object sender, EventArgs e)
        {
            frm_IzdavacRezervacija form = new frm_IzdavacRezervacija();
            form.Show();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            APIService.Username = "";
            APIService.Password = "";
            frm_Login form = new frm_Login();
            form.FormClosed += new FormClosedEventHandler(form_FormClosed);
            form.Show();
            Hide();
        }

        private void form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }

        private async void frm_Smjestaj_Load(object sender, EventArgs e)
        {
            dgv_Smjestaj.AutoGenerateColumns = false;

            var search = new SmjestajSearchRequest
            {
                GradId = 0,
                Naziv = null,
                IzdavacId = _IzdavacId
            };

            var result = await _SmjestajService.Get<List<SmjestajModel>>(search);
            dgv_Smjestaj.DataSource = result;

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