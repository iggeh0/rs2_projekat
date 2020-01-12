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

            cb_Uloga.Items.Add("Izaberite ulogu");
            cb_Uloga.Items.Add("Izdavač");
            cb_Uloga.Items.Add("Korisnik");

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
            cb_Uloga.SelectedIndex = 0;
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
            bool valid = true;
            if (tb_Ime.Text == null || tb_Ime.Text.Length < 3)
            {
                MessageBox.Show("Ime nije pravilno uneseno","Greška", MessageBoxButtons.OK);
                valid = false;
            }
            if (tb_Prezime.Text == null || tb_Prezime.Text.Length < 3)
            {
                MessageBox.Show("Prezime nije pravilno uneseno", "Greška", MessageBoxButtons.OK);
                valid = false;
            }
            Regex regex = new Regex(@"^\d+$");

            if (!regex.Match(tb_JMBG.Text).Success || tb_JMBG.Text.Length != 13)
            {
                MessageBox.Show("JMBG nije pravilno unesen", "Greška", MessageBoxButtons.OK);
                valid = false;
            }

            bool isPhone = Regex.IsMatch(tb_Telefon.Text, @"\(?\d{3}\)?-? *\d{3}-? *-?\d{4}");

            if (isPhone || tb_Telefon.Text.Length < 8)
            {
                MessageBox.Show("Telefon nije pravilno unesen", "Greška", MessageBoxButtons.OK);
                valid = false;
            }

            if (tb_Datum.Text != null)
            {
                if (Convert.ToDateTime(tb_Datum.Text) > DateTime.Today)
                {
                    MessageBox.Show("Datum nije pravilno unesen", "Greška", MessageBoxButtons.OK);
                    valid = false;
                }
            }

            bool isEmail = Regex.IsMatch(tb_Email.Text, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);

            if (!isEmail || tb_Email.Text.Length < 6)
            {
                MessageBox.Show("E-Mail nije pravilno unesen", "Greška", MessageBoxButtons.OK);
                valid = false;
            }

            if (tb_Username.Text == null || tb_Username.Text.Length < 3)
            {
                MessageBox.Show("Korisničko ime nije pravilno uneseno", "Greška", MessageBoxButtons.OK);
                valid = false;
            }

            if (tb_Password.Text == null || tb_Password.Text.Length < 6)
            {
                MessageBox.Show("Šifra nije pravilno unesena", "Greška", MessageBoxButtons.OK);
                valid = false;
            }

            if ( tb_Password.Text != tb_Passwordrepeat.Text )
            {
                MessageBox.Show("Šifre se ne poklapaju", "Greška", MessageBoxButtons.OK);
                valid = false;
            }

            if (valid)
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
                            KorisnikId = _KorisnikId,
                            SifraPonovo = tb_Passwordrepeat.Text
                        };
                        request = await _KorisnikService.Update<KorisnikEditRequest>(_KorisnikId, request);
                        if (request.Response == string.Empty)
                        {
                            Close();
                        }
                        else
                        {
                            MessageBox.Show(request.Response);
                        }
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
                    request = await _KorisnikService.Register<KorisnikInsertRequest>(request);
                    if (request.Response == null)
                    {
                        Close();
                    }
                    else
                        MessageBox.Show(request.Response);
                }
            }
        }

        private void btn_Nazad_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
