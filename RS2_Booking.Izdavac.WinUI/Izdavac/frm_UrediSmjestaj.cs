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
    public partial class frm_UrediSmjestaj : Form
    {
        private int _SmjestajId = 0;
        private int _IzdavacId;
        private readonly APIService _APIService = new APIService("smjestaj");
        SmjestajModel Model = new SmjestajModel();

        public frm_UrediSmjestaj(int SmjestajId, int IzdavacId)
        {
            _SmjestajId = SmjestajId;
            _IzdavacId = IzdavacId;
            InitializeComponent();         
        }

        private async void frm_UrediSmjestaj_Load(object sender, EventArgs e)
        {
            if ( _SmjestajId > 0 )
            {
                var S = await _APIService.GetById<SmjestajModel>(_SmjestajId);

                tb_Naziv.Text = S.Naziv;
                lbl_Adresa.Text = S.Adresa;
                lbl_Grad.Text = S.GradNaziv;
                tb_Email.Text = S.Email;
                tb_Telefon.Text = S.KontaktTelefon;
                tb_Opis.Text = S.Opis;

                Model = S;
            }
        }

        private async void btn_Snimi_Click(object sender, EventArgs e)
        {
            SmjestajModel request = new SmjestajModel();
            request.Email = tb_Email.Text;
            request.Naziv = tb_Naziv.Text;
            request.Opis = tb_Opis.Text;
            request.KontaktTelefon = tb_Telefon.Text;
            request.SmjestajId = _SmjestajId;
            request.Adresa = Model.Adresa;
            request.Distanca = Model.Distanca;
            request.GradId = Model.GradId;
            request.IzdavacId = _IzdavacId;

            await _APIService.Update<SmjestajModel>(_SmjestajId, request);
        }

        private void btn_SmjestajSobe_Click(object sender, EventArgs e)
        {
            frm_SmjestajSobe Form = new frm_SmjestajSobe(_SmjestajId);
            Form.Show();
        }

        private void btn_Nazad_Click(object sender, EventArgs e)
        {
            frm_Smjestaj Form = new frm_Smjestaj(_IzdavacId);
            Form.Show();
            Close();
        }
    }
}
