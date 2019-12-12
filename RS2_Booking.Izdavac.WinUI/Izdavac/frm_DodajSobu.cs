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
    public partial class frm_DodajSobe : Form
    {
        private readonly APIService _SobaService = new APIService("soba");
        private readonly int _SmjestajId;
        public frm_DodajSobe(int SmjestajId)
        {
            _SmjestajId = SmjestajId;
            InitializeComponent();
        }

        private void btn_Nazad_Click(object sender, EventArgs e)
        {
            Close();
        }


        private async void btn_Snimi_Click(object sender, EventArgs e)
        {
            HideError();
            bool valid = Validacija();
            if (valid)
            {
                SobaInsertRequest nova = new SobaInsertRequest
                {
                    BrojKreveta = int.Parse(tb_BrojKreveta.Text),
                    Cijena = float.Parse(tb_Cijena.Text),
                    Opis = tb_Opis.Text,
                    VelicinaSobe = int.Parse(tb_Velicina.Text),
                    VrstaSmjestaja = tb_Vrsta.Text,
                    VlastitaKupoanica = cb_Kupaonica.Checked,
                    SmjestajId = _SmjestajId
                };
                await _SobaService.Insert<SobaInsertRequest>(nova);
                Close();
            }         
        }

        private void HideError()
        {
            lbl_brKrevetaError.Visible = false;
            lbl_cijenaErr.Visible = false;
            lbl_VrstaErr.Visible = false;
            lbl_VelicinaErr.Visible = false;
            lbl_OpisErr.Visible = false;
        }

        private bool Validacija()
        {
            bool valid = true;
            if (string.IsNullOrWhiteSpace(tb_BrojKreveta.Text) || int.Parse(tb_BrojKreveta.Text) <= 0 || int.Parse(tb_BrojKreveta.Text) > 10)
            {
                lbl_brKrevetaError.Visible = true;
                lbl_brKrevetaError.Text = "Unesen neispravan broj kreveta!";
                valid = false;
            }

            if (string.IsNullOrWhiteSpace(tb_Cijena.Text) || float.Parse(tb_Cijena.Text) <= 0)
            {
                lbl_cijenaErr.Visible = true;
                lbl_cijenaErr.Text = "Cijena mora biti veća od 0!";
                valid = false;
            }

            if (tb_Vrsta.Text.Length < 2 || string.IsNullOrWhiteSpace(tb_Vrsta.Text))
            {
                lbl_VrstaErr.Visible = true;
                lbl_VrstaErr.Text = "Neispravna vrsta unesena!";
                valid = false;
            }

            if (string.IsNullOrWhiteSpace(tb_Velicina.Text) || int.Parse(tb_Velicina.Text) <= 0)
            {
                lbl_VelicinaErr.Visible = true;
                lbl_VelicinaErr.Text = "Neispravna veličina unesena!";
                valid = false;
            }

            if (tb_Opis.Text.Length < 2 || string.IsNullOrWhiteSpace(tb_Opis.Text))
            {
                lbl_OpisErr.Visible = true;
                lbl_OpisErr.Text = "Neispravan opis unesen!";
                valid = false;
            }

            return valid;
        }

    }
}
