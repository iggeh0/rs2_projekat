using RS2_Booking.Model;
using RS2_Booking.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RS2_Booking.Izdavac.WinUI.Smjestaj
{
    public partial class frm_UrediSmjestaj : Form
    {
        private int _SmjestajId = 0;
        private int _IzdavacId;
        private int _GradId;
        private readonly APIService _SmjestajService = new APIService("smjestaj");
        private readonly APIService _NoviService = new APIService("smjestaj/getgrad");
        SmjestajModel Model = new SmjestajModel();

        public frm_UrediSmjestaj(int SmjestajId, int IzdavacId)
        {
            _SmjestajId = SmjestajId;
            _IzdavacId = IzdavacId;
            InitializeComponent();
        }

        private async void frm_UrediSmjestaj_Load(object sender, EventArgs e)
        {
            if (_SmjestajId > 0)
            {
                var S = await _SmjestajService.GetById<SmjestajModel>(_SmjestajId);

                tb_Naziv.Text = S.Naziv;
                lbl_Adresa.Text = S.Adresa;
                lbl_Grad.Text = S.GradNaziv;
                tb_Email.Text = S.Email;
                tb_Telefon.Text = S.KontaktTelefon;
                tb_Opis.Text = S.Opis;
                _GradId = S.GradId;
                Model = S;



                //    UslugaSearchRequest UslugaRequest = new UslugaSearchRequest
                //    {
                //        SmjestajId = _SmjestajId
                //    };
                //    var lista2 = await _UslugaService.Get<List<UslugaModel>>(UslugaRequest);
                //    if (lista2 != null)
                //    {
                //        dgv_Usluge.DataSource = lista2;
                //    }   
                //}

            }
        }
        private async Task<bool> btn_Snimi_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_Email.Text))
            {
                MessageBox.Show("E-mail ne smije biti prazan!");
                return false;
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(tb_Email.Text);
            }
            catch
            {
                MessageBox.Show("E-mail je neispravan!");
                return false;
            }

            if (string.IsNullOrEmpty(tb_Naziv.Text))
            {
                MessageBox.Show("Naziv ne smije biti prazan!");
                return false;
            }
            if (string.IsNullOrEmpty(tb_Telefon.Text))
            {
                MessageBox.Show("Telefon ne smije biti prazan!");
                return false;
            }

            if (!Regex.Match(tb_Telefon.Text, @"^(\+[0-9]{9})$").Success)
            {
                MessageBox.Show("Broj telefona nije ispravan!");
                return false;
            }

            if (string.IsNullOrEmpty(tb_Opis.Text))
            {
                MessageBox.Show("Opis ne smije biti prazan!");
                return false;
            }

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
            return true;

            //private async void dgv_Okolina_CellContentClick(object sender, DataGridViewCellEventArgs e)
            //{
            //    if (dgv_Okolina.CurrentCell.ColumnIndex.Equals(2) && e.RowIndex != -1)
            //    {
            //        if (dgv_Okolina.CurrentCell != null)
            //        {
            //            var id = int.Parse(dgv_Okolina[e.ColumnIndex - 2, e.RowIndex].Value.ToString());
            //            await _OkolinaService.Delete<OkolinaModel>(id);

            //            OkolinaSearchRequest OkolinaRequest = new OkolinaSearchRequest
            //            {
            //                SmjestajId = _SmjestajId
            //            };
            //            var lista = await _OkolinaService.Get<List<OkolinaModel>>(OkolinaRequest);
            //            if (lista != null)
            //            {
            //                dgv_Okolina.DataSource = lista;
            //            }

            //        }
            //    }
            //}




        }

        private void btn_Usluge_Click(object sender, EventArgs e)
        {
            frm_SmjestajUsluge form = new frm_SmjestajUsluge(_SmjestajId);
            form.Show();
        }

        private void btn_Okoline_Click(object sender, EventArgs e)
        {
            frm_SmjestajOkoline form = new frm_SmjestajOkoline(_SmjestajId, _GradId);
            form.Show();
        }

        private void btn_SmjestajSobe_Click(object sender, EventArgs e)
        {
            frm_SmjestajSobe form = new frm_SmjestajSobe(_SmjestajId);
            form.Show();
        }
    }
}