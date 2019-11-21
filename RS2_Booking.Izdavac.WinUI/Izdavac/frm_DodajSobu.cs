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
            if (this.ValidateChildren())
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

        //private void tb_BrojKreveta_Validating(object sender, CancelEventArgs e)
        //{
        //    if (string.IsNullOrWhiteSpace(tb_BrojKreveta.Text) || int.Parse(tb_BrojKreveta.Text) <= 0)
        //    {
        //        errorProvider.SetError(tb_BrojKreveta, Properties.Resources.Validation_Required);
        //        e.Cancel = true;
        //    }
        //    else
        //    {
        //        errorProvider.SetError(tb_BrojKreveta, null);
        //    }

        //}

        //private void tb_Cijena_Validating(object sender, CancelEventArgs e)
        //{
        //    if (string.IsNullOrWhiteSpace(tb_Cijena.Text) || float.Parse(tb_Cijena.Text) <= 0)
        //    {
        //        errorProvider.SetError(tb_Cijena, Properties.Resources.Validation_Required);
        //        e.Cancel = true;
        //    }
        //    else
        //    {
        //        errorProvider.SetError(tb_Cijena, null);
        //    }
        //}

        //private void tb_Vrsta_Validating(object sender, CancelEventArgs e)
        //{
        //    if (tb_Vrsta.Text.Length < 2 || string.IsNullOrWhiteSpace(tb_Vrsta.Text))
        //    {
        //        errorProvider.SetError(tb_Vrsta, Properties.Resources.Validation_Required);
        //        e.Cancel = true;
        //    }
        //    else
        //    {
        //        errorProvider.SetError(tb_Vrsta, null);
        //    }
        //}

        //private void tb_Velicina_Validating(object sender, CancelEventArgs e)
        //{
        //    if (string.IsNullOrWhiteSpace(tb_Velicina.Text) || int.Parse(tb_Velicina.Text) <= 0)
        //    {
        //        errorProvider.SetError(tb_Velicina, Properties.Resources.Validation_Required);
        //        e.Cancel = true;
        //    }
        //    else
        //    {
        //        errorProvider.SetError(tb_Velicina, null);
        //    }
        //}

        //private void tb_Opis_Validating(object sender, CancelEventArgs e)
        //{
        //    if (tb_Opis.Text.Length < 2 || string.IsNullOrWhiteSpace(tb_Opis.Text))
        //    {
        //        errorProvider.SetError(tb_Opis, Properties.Resources.Validation_Required);
        //        e.Cancel = true;
        //    }
        //    else
        //    {
        //        errorProvider.SetError(tb_Opis, null);
        //    }
        //}
    }
}
