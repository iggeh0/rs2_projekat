using RS2_Booking.Model;
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
    public partial class frm_AdminIndex : Form
    {
        private readonly APIService _KorisnikService = new APIService("korisnik");
        private readonly int _KorisnikId;
        public frm_AdminIndex(int KorisnikId)
        {
            InitializeComponent();
            _KorisnikId = KorisnikId;
        }

        private async void frm_AdminIndex_Load(object sender, EventArgs e)
        {
            KorisnikModel Korisnik = await _KorisnikService.GetById<KorisnikModel>(_KorisnikId);
            lbl_Ime.Text = Korisnik.Ime + " " + Korisnik.Prezime;
        }

        private void btn_UrediProfil_Click(object sender, EventArgs e)
        {
            frm_Korisnik form = new frm_Korisnik(_KorisnikId, 2);
            form.Show();
        }

        private void btn_Korisnici_Click(object sender, EventArgs e)
        {
            frm_AdminKorisnici form = new frm_AdminKorisnici();
            form.Show();
        }

        private void btn_Smjestaj_Click(object sender, EventArgs e)
        {
            frm_AdminSmjestaj form = new frm_AdminSmjestaj();
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

        private void btn_Uplate_Click(object sender, EventArgs e)
        {
            frm_AdminUplate form = new frm_AdminUplate();
            form.Show();
        }
    }
}
