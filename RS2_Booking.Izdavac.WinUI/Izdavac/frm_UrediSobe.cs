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
    public partial class frm_UrediSobe : Form
    {
        private readonly APIService _SobaService = new APIService("soba");
        private readonly APIService _InventarService = new APIService("inventar");
        private readonly int _SobaId;
        private readonly int _SmjestajId;
        public frm_UrediSobe(int SobaId, int SmjestajId)
        {
            _SobaId = SobaId;
            _SmjestajId = SmjestajId;
            InitializeComponent();
        }

        private async void frm_UrediSobe_Load(object sender, EventArgs e)
        {
            var result = await _SobaService.GetById<SobaModel>(_SobaId);

            tb_BrojKreveta.Text = result.BrojKreveta.ToString();
            tb_Cijena.Text = result.Cijena.ToString();
            tb_Opis.Text = result.Opis;
            tb_Velicina.Text = result.VelicinaSobe.ToString();
            tb_VrstaSmjestaja.Text = result.VrstaSmjestaja;
            cb_Kupaonica.Checked = result.VlastitaKupoanica;

            InventarSearchRequest request = new InventarSearchRequest
            {
                SobaId = _SobaId
            };
            var lista = await _InventarService.Get<List<InventarModel>>(request);

            dgv_Inventar.AutoGenerateColumns = false;
            dgv_Inventar.DataSource = lista;
        }

        private void btn_Nazad_Click(object sender, EventArgs e)
        {
            frm_SmjestajSobe Form = new frm_SmjestajSobe(_SmjestajId);
            Form.Show();
            this.Close();
        }

        private void btn_Snimi_Click(object sender, EventArgs e)
        {

        }

        private void tb_BrojKreveta_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_BrojKreveta.Text) || int.Parse(tb_BrojKreveta.Text) <= 0)
            {
                errorProvider.SetError(tb_BrojKreveta, Properties.Resources.Validation_Required);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(tb_BrojKreveta, null);
            }
        }

        private void tb_Cijena_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_Cijena.Text) || float.Parse(tb_Cijena.Text) <= 0)
            {
                errorProvider.SetError(tb_Cijena, Properties.Resources.Validation_Required);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(tb_Cijena, null);
            }
        }

        private void tb_VrstaSmjestaja_Validating(object sender, CancelEventArgs e)
        {
            if (tb_VrstaSmjestaja.Text.Length < 2 || string.IsNullOrWhiteSpace(tb_VrstaSmjestaja.Text))
            {
                errorProvider.SetError(tb_VrstaSmjestaja, Properties.Resources.Validation_Required);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(tb_VrstaSmjestaja, null);
            }
        }

        private void tb_Velicina_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_Velicina.Text) || int.Parse(tb_Velicina.Text) <= 0)
            {
                errorProvider.SetError(tb_Velicina, Properties.Resources.Validation_Required);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(tb_Velicina, null);
            }
        }

        private void tb_Opis_Validating(object sender, CancelEventArgs e)
        {
            if (tb_Opis.Text.Length < 2 || string.IsNullOrWhiteSpace(tb_Opis.Text))
            {
                errorProvider.SetError(tb_Opis, Properties.Resources.Validation_Required);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(tb_Opis, null);
            }
        }

        private void tb_Inventar_Validating(object sender, CancelEventArgs e)
        {
            if (tb_Inventar.Text.Length < 2 || string.IsNullOrWhiteSpace(tb_Inventar.Text))
            {
                errorProvider.SetError(tb_Inventar, Properties.Resources.Validation_Required);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(tb_Inventar, null);
            }
        }

        private async void btn_Inventar_Click(object sender, EventArgs e)
        {
            InventarModel request = new InventarModel();
            request.Naziv = tb_Inventar.Text;
            request.SobaId = _SobaId;

            await _InventarService.Insert<InventarInsertRequest>(request);

            InventarSearchRequest request2 = new InventarSearchRequest
            {
                SobaId = _SobaId
            };
            var lista = await _InventarService.Get<List<InventarModel>>(request2);

            dgv_Inventar.DataSource = lista;

        }
    }
}
