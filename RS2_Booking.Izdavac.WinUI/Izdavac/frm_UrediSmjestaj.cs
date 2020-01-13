using RS2_Booking.Izdavac.WinUI.Izdavac;
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
        private readonly APIService _NoviService = new APIService("smjestaj/GetFullSmjestaj");
        SmjestajModel Model = new SmjestajModel();

        public frm_UrediSmjestaj(int SmjestajId, int IzdavacId)
        {
            _SmjestajId = SmjestajId;
            _IzdavacId = IzdavacId;
            InitializeComponent();
        }

        private void ClearErrors()
        {
            lbl_EmailErr.Visible = false;
            lbl_NazivErr.Visible = false;
            lbl_OpisErr.Visible = false;
            lbl_TelefonErr.Visible = false;
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

            }
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

        private async void btn_Snimi_Click_1(object sender, EventArgs e)
        {
            ClearErrors();
            bool valid = true;
            if (tb_Email.Text.Length < 2 || String.IsNullOrEmpty(tb_Email.Text))
            {
                lbl_EmailErr.Text = "E-mail mora biti duži od 2 karaktera!";
                lbl_EmailErr.Visible = true;
                valid = false;
            }
            else
            {
                string regex = @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";
                if (!Regex.Match(tb_Email.Text, regex).Success)
                {
                    lbl_EmailErr.Text = "E-mail nije validan!";
                    lbl_EmailErr.Visible = true;
                    valid = false;

                }
            }

            if (string.IsNullOrEmpty(tb_Naziv.Text) || tb_Naziv.Text.Length < 2)
            {
                lbl_NazivErr.Text = "Naziv mora biti duži od 2 karaktera!";
                lbl_NazivErr.Visible = true;
                valid = false;
            }

            if (tb_Telefon.Text.Length < 7 || String.IsNullOrEmpty(tb_Telefon.Text) || !Regex.Match(tb_Telefon.Text, @"^[0-9*#+]+$").Success)
            {
                lbl_TelefonErr.Text = "Broj telefona nije validan!";
                lbl_TelefonErr.Visible = true;
            }

            if (tb_Opis.Text.Length < 2 || String.IsNullOrEmpty(tb_Opis.Text))
            {
                lbl_OpisErr.Text = "Naziv mora biti duži od 2 karaktera!";
                lbl_OpisErr.Visible = true;
                valid = false;

            }

            if (valid)
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
        }

        private void btn_Nazad_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Slike_Click(object sender, EventArgs e)
        {
            frm_SmjestajSlike form = new frm_SmjestajSlike(_SmjestajId);
            form.Show();
        }
    }
}
