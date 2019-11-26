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
    public partial class frm_SmjestajOkoline : Form
    {
        private readonly APIService _OkolinaService = new APIService("okolina");

        private int _SmjestajId;
        private int _GradId;

        public frm_SmjestajOkoline(int SmjestajId, int GradId)
        {
            InitializeComponent();
            _SmjestajId = SmjestajId;
            _GradId = GradId;
            dgv_Okolina.AutoGenerateColumns = false;
        }

        private async void btn_DodajNovo_Click(object sender, EventArgs e)
        {
                if (string.IsNullOrEmpty(tb_NovaNaziv.Text))
                {
                    MessageBox.Show("Naziv okoline ne smije biti prazan!");
                return;
                }
            if (string.IsNullOrEmpty(tb_NovaUdaljenost.Text))
            {
                MessageBox.Show("Naziv okoline ne smije biti prazan!");
                return;
            }
            OkolinaInsertRequest request = new OkolinaInsertRequest
                {
                    Naziv = tb_NovaNaziv.Text,
                    OkolinaId = 0,
                    SmjestajId = _SmjestajId,
                    Udaljenost = Convert.ToDouble(tb_NovaUdaljenost.Text)
                };

                await _OkolinaService.Insert<OkolinaInsertRequest>(request);

                OkolinaSearchRequest request2 = new OkolinaSearchRequest
                {
                    SmjestajId = _SmjestajId
                };
                var lista = await _OkolinaService.Get<List<OkolinaModel>>(request2);

                dgv_Okolina.DataSource = lista;
            
        }

        private async void frm_SmjestajOkoline_Load(object sender, EventArgs e)
        {
            OkolinaSearchRequest OkolinaRequest = new OkolinaSearchRequest
            {
                SmjestajId = _SmjestajId
            };
            var lista = await _OkolinaService.Get<List<OkolinaModel>>(OkolinaRequest);
            if (lista != null)
            {
                dgv_Okolina.DataSource = lista;
            }

            OkolinaSearchRequest OkolinaByGradRequest = new OkolinaSearchRequest
            {
                GradId = _GradId,
                SmjestajId = _SmjestajId
            };

            List<OkolinaModel> datasource = await _OkolinaService.Get <List<OkolinaModel>>(OkolinaByGradRequest);
            if (datasource != null)
            {
                OkolinaModel prazan = new OkolinaModel();
                prazan.Naziv = "Odaberite okolno mjesto iz istog grada...";
                prazan.OkolinaId = 0;
                datasource.Insert(0, prazan);

                cb_PostojecaNaziv.DataSource = datasource;
                cb_PostojecaNaziv.DisplayMember = "Naziv";
                cb_PostojecaNaziv.ValueMember = "OkolinaId";
            }
        }
    }
}
