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

namespace RS2_Booking.Izdavac.WinUI.Smjestaj
{
    public partial class frm_DodajSmjestaj : Form
    {
        private readonly APIService _SmjestajService = new APIService("smjestaj");
        private readonly APIService _GradService = new APIService("grad");
        private readonly int _IzdavacId;
        public frm_DodajSmjestaj(int IzdavacId)
        {
            InitializeComponent();
            _IzdavacId = IzdavacId;
        }

        private async void frm_DodajSmjestaj_Load(object sender, EventArgs e)
        {
            var lista = await _GradService.Get<List<GradModel>>(null);
            GradModel prazan = new GradModel
            {
                GradId = 0,
                Naziv = "Odaberite grad...."
            };
            lista.Insert(0, prazan);

            cb_Grad.DataSource = lista;
            cb_Grad.DisplayMember = "Naziv";
            cb_Grad.ValueMember = "GradId";
        }

        private void btn_Nazad_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void btn_Dodaj_Click(object sender, EventArgs e)
        {
            SmjestajModel Model = new SmjestajModel();
            Model.Adresa = tb_Adresa.Text;
            Model.Distanca = Int32.Parse(tb_Udaljenost.Text);
            Model.KontaktTelefon = tb_Telefon.Text;
            Model.Naziv = tb_Naziv.Text;
            Model.Email = tb_Email.Text;
            Model.GradId = (int)(cb_Grad.SelectedValue);
            Model.IzdavacId = _IzdavacId;
            Model.Opis = rtb_Opis.Text;

           await _SmjestajService.Insert<SmjestajModel>(Model);
            Close();
        }
    }
}
