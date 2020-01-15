using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RS2_Booking.Izdavac.WinUI.Administrator;
using RS2_Booking.Izdavac.WinUI.Smjestaj;
using RS2_Booking.Model;
using RS2_Booking.Model.Requests;

namespace RS2_Booking.Izdavac.WinUI
{
    public partial class frm_Login : Form
    {
        APIService _service = new APIService("korisnik/Login");

        public frm_Login()
        {
            InitializeComponent();
            List<GradModel> lista = new List<GradModel>();
            GradModel item = new GradModel
            {
                GradId = 1,
                Naziv = "Izdavač"
            };
            lista.Add(item);
            item = new GradModel
            {
                GradId = 2,
                Naziv = "Administrator"
            };
            lista.Add(item);

            cb_Uloga.DataSource = lista;
            cb_Uloga.ValueMember = "GradId";
            cb_Uloga.DisplayMember = "Naziv";
            cb_Uloga.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private async void btn_Login_Click(object sender, EventArgs e)
        {
            APIService.Username = tb_KorisnickoIme.Text;
            APIService.Password = tb_Lozinka.Text;
            try
            {
                LoginRequest request = new LoginRequest
                {
                    KorisnickoIme = tb_KorisnickoIme.Text,
                    Lozinka = tb_Lozinka.Text,
                    Uloga = Int32.Parse(cb_Uloga.SelectedValue.ToString()) - 1
                };

                var k = await _service.Get<KorisnikModel>(request);
                if (k.OK)
                {
                    if (k.Uloga == 1)
                    {
                        frm_AdminIndex form = new frm_AdminIndex(k.KorisnikId);
                        form.Show();
                        Hide();
                    }
                    else if (k.Uloga == 0)
                    {
                        frm_Smjestaj form = new frm_Smjestaj(k.KorisnikId, k.IzdavacId);
                        form.Show();
                        Hide();
                    }
                }
                else
                {
                    MessageBox.Show(k.Poruka);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Registracija_Click(object sender, EventArgs e)
        {
            frm_Korisnik form = new frm_Korisnik(0, 0);
            form.Show();
        }
    }
}
