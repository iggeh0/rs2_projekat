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
    public partial class frm_AdminKorisnici : Form
    {
        private readonly APIService _KorisnikService = new APIService("korisnik");

        public frm_AdminKorisnici()
        {
            InitializeComponent();
        }


        private void frm_AdminKorisnici_Load(object sender, EventArgs e)
        {
        }

        private async void btn_Pretraga_Click(object sender, EventArgs e)
        {

            var search = new KorisnikSearchRequest
            {
                Ime = tb_Ime.Text,
                Prezime = tb_Prezime.Text,
                KorisnickoIme = tb_KorisnickoIme.Text
            };

            var result = await _KorisnikService.Get<List<KorisnikModel>>(search);
            dgv_Korisnici.AutoGenerateColumns = false;
            dgv_Korisnici.DataSource = result;
        }

        private async void dgv_Korisnici_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Korisnici.CurrentCell.ColumnIndex.Equals(4) && e.RowIndex != -1)
            {
                if (dgv_Korisnici.CurrentCell != null)
                {
                    var id = int.Parse(dgv_Korisnici[e.ColumnIndex - 4, e.RowIndex].Value.ToString());
                    frm_Korisnik Form = new frm_Korisnik(id, 1);
                    Form.Show();
                }

            }
            else if (dgv_Korisnici.CurrentCell.ColumnIndex.Equals(5))
            {
                var id = int.Parse(dgv_Korisnici[e.ColumnIndex - 5, e.RowIndex].Value.ToString());
                await _KorisnikService.Delete<KorisnikModel>(id);
                btn_Pretraga_Click(this, EventArgs.Empty);
            }
        }

        private void btn_DodajKorisnika_Click(object sender, EventArgs e)
        {
            frm_Korisnik form = new frm_Korisnik(0, 0);
            form.Show();
        }

        private void btn_Nazad_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
