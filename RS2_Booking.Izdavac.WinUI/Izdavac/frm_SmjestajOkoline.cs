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
            cb_PostojecaNaziv.DropDownStyle = ComboBoxStyle.DropDownList;
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
                    Udaljenost = Convert.ToDouble(tb_NovaUdaljenost.Text),
                    Nova = true
                };

                await _OkolinaService.Insert<OkolinaInsertRequest>(request);

            OkolinaSearchRequest OkolinaRequest2 = new OkolinaSearchRequest
            {
                SmjestajId = _SmjestajId
            };
            var lista = await _OkolinaService.Get<List<OkolinaModel>>(OkolinaRequest2);
            if (lista != null)
            {
                dgv_Okolina.DataSource = lista;
            }

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
                OkolinaModel prazan = new OkolinaModel
                {
                    Naziv = "Odaberite okolno mjesto iz istog grada...",
                    OkolinaId = 0
                };
                datasource.Insert(0, prazan);

                cb_PostojecaNaziv.DataSource = datasource;
                cb_PostojecaNaziv.DisplayMember = "Naziv";
                cb_PostojecaNaziv.ValueMember = "OkolinaId";
            }
        }

        private async void btn_DodajPostojece_Click(object sender, EventArgs e)
        {
            if ( cb_PostojecaNaziv.SelectedIndex > 0 && !string.IsNullOrEmpty(tb_PostojecaUdaljenost.Text) )
            {
                OkolinaInsertRequest request = new OkolinaInsertRequest
                {
                    Naziv = cb_PostojecaNaziv.SelectedText,
                    Nova = false,
                    Udaljenost = Convert.ToDouble(tb_PostojecaUdaljenost.Text),
                    SmjestajId = _SmjestajId,
                    OkolinaId = Convert.ToInt32(cb_PostojecaNaziv.SelectedValue)
                };
                await _OkolinaService.Insert<OkolinaInsertRequest>(request);

                OkolinaSearchRequest request2 = new OkolinaSearchRequest
                {
                    SmjestajId = _SmjestajId
                };
                var lista = await _OkolinaService.Get<List<OkolinaModel>>(request2);

                dgv_Okolina.DataSource = lista;


                OkolinaSearchRequest OkolinaByGradRequest = new OkolinaSearchRequest
                {
                    GradId = _GradId,
                    SmjestajId = _SmjestajId
                };

                List<OkolinaModel> datasource = await _OkolinaService.Get<List<OkolinaModel>>(OkolinaByGradRequest);

                cb_PostojecaNaziv.DataSource = datasource;
            }
        }

        private async void dgv_Okolina_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Okolina.CurrentCell.ColumnIndex.Equals(4) && e.RowIndex != -1)
            {
                if (dgv_Okolina.CurrentCell != null)
                {
                    var OkolinaSmjestajId = int.Parse(dgv_Okolina[e.ColumnIndex - 4, e.RowIndex].Value.ToString());
                    await _OkolinaService.Delete<OkolinaModel>(OkolinaSmjestajId);

                    OkolinaSearchRequest OkolinaRequest = new OkolinaSearchRequest
                    {
                        SmjestajId = _SmjestajId
                    };
                    var lista = await _OkolinaService.Get<List<OkolinaModel>>(OkolinaRequest);
                    if (lista != null)
                    {
                        dgv_Okolina.DataSource = lista;
                    }
                    else
                        dgv_Okolina.DataSource = null;

                }
            }
        }
    }
}
