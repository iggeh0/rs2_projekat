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

namespace RS2_Booking.Izdavac.WinUI
{
    public partial class frm_Korisnik : Form
    {
        private readonly APIService _KorisnikService = new APIService("korisnik");
        private readonly int _KorisnikId;
        private readonly int _Role;
        public frm_Korisnik(int KorisnikId = 0, int role = 0)
        {
            if (KorisnikId > 0)
            {
                _KorisnikId = KorisnikId;
            }

            _Role = role;
            InitializeComponent();

            cb_Uloga.Items.Add("Izaberite ulogu:");
            cb_Uloga.Items.Add("Korisnik");
            cb_Uloga.Items.Add("Izdavač");
            #region layout
            lbl_Ime.Left = (this.ClientSize.Width - lbl_Ime.Width) / 2;
            tb_Ime.Left = (this.ClientSize.Width - tb_Ime.Width) / 2;
            lbl_Prezime.Left = (this.ClientSize.Width - lbl_Prezime.Width) / 2;
            tb_Prezime.Left = (this.ClientSize.Width - tb_Prezime.Width) / 2;
            lbl_JMBG.Left = (this.ClientSize.Width - lbl_JMBG.Width) / 2;
            tb_JMBG.Left = (this.ClientSize.Width - tb_JMBG.Width) / 2;
            lbl_Telefon.Left = (this.ClientSize.Width - lbl_Telefon.Width) / 2;
            tb_Telefon.Left = (this.ClientSize.Width - tb_Telefon.Width) / 2;
            lbl_Datum.Left = (this.ClientSize.Width - lbl_Datum.Width) / 2;
            tb_Datum.Left = (this.ClientSize.Width - tb_Datum.Width) / 2;
            lbl_Email.Left = (this.ClientSize.Width - lbl_Email.Width) / 2;
            tb_Email.Left = (this.ClientSize.Width - tb_Email.Width) / 2;
            lbl_Username.Left = (this.ClientSize.Width - lbl_Username.Width) / 2;
            tb_Username.Left = (this.ClientSize.Width - tb_Username.Width) / 2;
            lbl_Password.Left = (this.ClientSize.Width - lbl_Password.Width) / 2;
            tb_Password.Left = (this.ClientSize.Width - tb_Password.Width) / 2;
            lbl_Passwordrepeat.Left = (this.ClientSize.Width - lbl_Passwordrepeat.Width) / 2;
            tb_Passwordrepeat.Left = (this.ClientSize.Width - tb_Passwordrepeat.Width) / 2;
            btn_Nazad.Left = (this.ClientSize.Width - btn_Nazad.Width) / 2;
            btn_Save.Left = (this.ClientSize.Width - btn_Save.Width) / 2;

            #endregion
        }


        private async void frm_Korisnik_Load(object sender, EventArgs e)
        {
            if (_KorisnikId > 0)
            {
                var k = await _KorisnikService.GetById<KorisnikEditRequest>(_KorisnikId);

                if (k.KorisnikId == _KorisnikId)
                {
                    tb_Ime.Text = k.Ime;
                    tb_Prezime.Text = k.Prezime;
                    tb_JMBG.Text = k.Jmbg;
                    tb_Password.Text = k.Sifra;
                    tb_Email.Text = k.Email;
                    tb_Telefon.Text = k.BrojTelefona;
                    tb_Datum.Text = k.DatumRodjenja.ToShortDateString();
                    tb_Username.Text = k.KorisnickoIme;
                }
            }
            if ( _Role > 0 )
            {
                cb_Uloga.Visible = false;
                lbl_Uloga.Visible = false;
            }
        }

        private async void btn_Save_Click(object sender, EventArgs e)
        {
            if (cb_Uloga.Visible == false)
            {
                if (_KorisnikId > 0 && _Role > 0)
                {
                    KorisnikEditRequest request = new KorisnikEditRequest
                    {
                        Ime = tb_Ime.Text,
                        Prezime = tb_Prezime.Text,
                        Jmbg = tb_JMBG.Text,
                        Sifra = tb_Password.Text,
                        Email = tb_Email.Text,
                        BrojTelefona = tb_Telefon.Text,
                        DatumRodjenja = Convert.ToDateTime(tb_Datum.Text),
                        KorisnickoIme = tb_Username.Text,
                        KorisnikId = _KorisnikId
                    };
                    await _KorisnikService.Update<KorisnikEditRequest>(_KorisnikId, request);
                    Close();
                }
               
            }
            else if (_Role == 0 && cb_Uloga.SelectedIndex > 0)
            {
                KorisnikInsertRequest request = new KorisnikInsertRequest
                {
                    Ime = tb_Ime.Text,
                    Prezime = tb_Prezime.Text,
                    Jmbg = tb_JMBG.Text,
                    Sifra = tb_Password.Text,
                    Email = tb_Email.Text,
                    BrojTelefona = tb_Telefon.Text,
                    DatumRodjenja = Convert.ToDateTime(tb_Datum.Text),
                    KorisnickoIme = tb_Username.Text,
                    Role = cb_Uloga.SelectedIndex
                };
                await _KorisnikService.Insert<KorisnikInsertRequest>(request);
                Close();
            }
        }
    }
}
