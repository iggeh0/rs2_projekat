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

namespace RS2_Booking.Izdavac.WinUI.Smjestaj
{
    public partial class frm_UrediSmjestaj : Form
    {
        private int _SmjestajId = 0;
        private int _IzdavacId;
        private readonly APIService _SmjestajService = new APIService("smjestaj");
        private readonly APIService _OkolinaService = new APIService("okolina");
        private readonly APIService _UslugaService = new APIService("usluga");
        private readonly APIService _NoviService = new APIService("smjestaj/getgrad");
        SmjestajModel Model = new SmjestajModel();

        public frm_UrediSmjestaj(int SmjestajId, int IzdavacId)
        {
            _SmjestajId = SmjestajId;
            _IzdavacId = IzdavacId;
            InitializeComponent();
            dgv_Okolina.AutoGenerateColumns = false;
            dgv_Usluge.AutoGenerateColumns = false;
        }

        private async void frm_UrediSmjestaj_Load(object sender, EventArgs e)
        {
            if ( _SmjestajId > 0 )
            {
                var S = await _SmjestajService.GetById<SmjestajModel>(_SmjestajId);

                tb_Naziv.Text = S.Naziv;
                lbl_Adresa.Text = S.Adresa;
                lbl_Grad.Text = S.GradNaziv;
                tb_Email.Text = S.Email;
                tb_Telefon.Text = S.KontaktTelefon;
                tb_Opis.Text = S.Opis;

                Model = S;

                OkolinaSearchRequest OkolinaRequest = new OkolinaSearchRequest
                {
                    SmjestajId = _SmjestajId
                };
                var lista = await _OkolinaService.Get<List<OkolinaModel>>(OkolinaRequest);
                if (lista != null)
                {
                    dgv_Okolina.DataSource = lista;
                }


                UslugaSearchRequest UslugaRequest = new UslugaSearchRequest
                {
                    SmjestajId = _SmjestajId
                };
                var lista2 = await _UslugaService.Get<List<UslugaModel>>(UslugaRequest);
                if (lista2 != null)
                {
                    dgv_Usluge.DataSource = lista2;
                }   
            }

        }

        private async void btn_Snimi_Click(object sender, EventArgs e)
        {
            SmjestajModel request = new SmjestajModel
            {
                Email = tb_Email.Text,
                Naziv = tb_Naziv.Text,
                Opis = tb_Opis.Text,
                KontaktTelefon = tb_Telefon.Text,
                SmjestajId = _SmjestajId,
                Adresa = Model.Adresa,
                Distanca = Model.Distanca,
                GradId = Model.GradId,
                IzdavacId = _IzdavacId
            };

            await _SmjestajService.Update<SmjestajModel>(_SmjestajId, request);
        }

        private void btn_SmjestajSobe_Click(object sender, EventArgs e)
        {
            frm_SmjestajSobe Form = new frm_SmjestajSobe(_SmjestajId);
            Form.Show();
        }

        private void btn_Nazad_Click(object sender, EventArgs e)
        {
            //frm_Smjestaj Form = new frm_Smjestaj(_IzdavacId);
            //Form.Show();
            Close();
        }

        private async void btn_OkolinaDodaj_Click(object sender, EventArgs e)
        {
            OkolinaInsertRequest request = new OkolinaInsertRequest
            {
                Naziv = tb_OkolinaDodaj.Text,
                OkolinaId = 0,
                SmjestajId = _SmjestajId
            };

            await _OkolinaService.Insert<OkolinaInsertRequest>(request);

            OkolinaSearchRequest request2 = new OkolinaSearchRequest
            {
                SmjestajId = _SmjestajId
            };
            var lista = await _OkolinaService.Get<List<OkolinaModel>>(request2);

            dgv_Okolina.DataSource = lista;
        }

        private async void btn_UslugaDodaj_Click(object sender, EventArgs e)
        {
            UslugaInsertRequest request = new UslugaInsertRequest
            {
                Naziv = tb_UslugaNaziv.Text,
                SmjestajId = _SmjestajId,
                Opis = tb_UslugaOpis.Text
            };
            await _UslugaService.Insert<UslugaInsertRequest>(request);

            UslugaSearchRequest UslugaRequest = new UslugaSearchRequest
            {
                SmjestajId = _SmjestajId
            };
            var lista = await _UslugaService.Get<List<UslugaModel>>(UslugaRequest);
            if (lista != null)
            {
                dgv_Usluge.DataSource = lista;
            }
        }

        private async void dgv_Okolina_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Okolina.CurrentCell.ColumnIndex.Equals(2) && e.RowIndex != -1)
            {
                if (dgv_Okolina.CurrentCell != null)
                {
                    var id = int.Parse(dgv_Okolina[e.ColumnIndex - 2, e.RowIndex].Value.ToString());
                    await _OkolinaService.Delete<OkolinaModel>(id);

                    OkolinaSearchRequest OkolinaRequest = new OkolinaSearchRequest
                    {
                        SmjestajId = _SmjestajId
                    };
                    var lista = await _OkolinaService.Get<List<OkolinaModel>>(OkolinaRequest);
                    if (lista != null)
                    {
                        dgv_Okolina.DataSource = lista;
                    }

                }
            }
        }

        private async void dgv_Usluge_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Usluge.CurrentCell.ColumnIndex.Equals(3) && e.RowIndex != -1)
            {
                if (dgv_Usluge.CurrentCell != null)
                {
                    var id = int.Parse(dgv_Usluge[e.ColumnIndex - 3, e.RowIndex].Value.ToString());
                    await _UslugaService.Delete<UslugaModel>(id);

                    UslugaSearchRequest UslugaRequest = new UslugaSearchRequest
                    {
                        SmjestajId = _SmjestajId
                    };
                    var lista = await _UslugaService.Get<List<UslugaModel>>(UslugaRequest);
                    if (lista != null)
                    {
                        dgv_Usluge.DataSource = lista;
                    }

                }
            }
        }
    }
}
