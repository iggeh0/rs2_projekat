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
    public partial class frm_SmjestajUsluge : Form
    {
        private readonly APIService _UslugaService = new APIService("usluga");
        private int _SmjestajId;
        public frm_SmjestajUsluge(int SmjestajId)
        {
            _SmjestajId = SmjestajId;
            InitializeComponent();
        }

        private async void btn_Dodaj_Novu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_Naziv_Nova.Text))
            {
                MessageBox.Show("Naziv usluge ne smije biti prazan!");
                return;
            }

            if (string.IsNullOrEmpty(tb_Opis_Nova.Text))
            {
                MessageBox.Show("Opis usluge ne smije biti prazan!");
                return;
            }

            UslugaInsertRequest request = new UslugaInsertRequest
            {
                Naziv = tb_Naziv_Nova.Text,
                SmjestajId = _SmjestajId,
                Opis = tb_Opis_Nova.Text,
                Nova = true
            };
            await _UslugaService.Insert<UslugaInsertRequest>(request);

            UslugaSearchRequest UslugaRequest = new UslugaSearchRequest
            {
                SmjestajId = _SmjestajId
            };
            var lista = await _UslugaService.Get<List<UslugaModel>>(UslugaRequest);
            if (lista != null)
            {
                dgv_Usluge.DataSource = lista;
            }
        }

        private async void dgv_Usluge_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                if (dgv_Usluge.CurrentCell.ColumnIndex.Equals(4) && e.RowIndex != -1)
                { 
                    if (dgv_Usluge.CurrentCell != null)
                    {
                        var id = int.Parse(dgv_Usluge[e.ColumnIndex - 4, e.RowIndex].Value.ToString());
                        await _UslugaService.Delete<UslugaModel>(id);

                        UslugaSearchRequest UslugaRequest = new UslugaSearchRequest
                        {
                            SmjestajId = _SmjestajId
                        };
                        var lista = await _UslugaService.Get<List<UslugaModel>>(UslugaRequest);
                        if (lista != null)
                        {
                            dgv_Usluge.DataSource = lista;
                        }

                    }
                }
            }
        }

        private async void frm_SmjestajUsluge_Load(object sender, EventArgs e)
        {
            cb_Usluge.DropDownStyle = ComboBoxStyle.DropDownList;
            UslugaSearchRequest request1 = new UslugaSearchRequest
            {
                SmjestajId = _SmjestajId,
                Preporucene = false
            };

            dgv_Usluge.AutoGenerateColumns = false;
            var lista = await _UslugaService.Get<List<UslugaModel>>(request1);

            if ( lista != null )
            {
                dgv_Usluge.DataSource = lista;
            }

            cb_Usluge.ValueMember = "UslugaId";
            cb_Usluge.DisplayMember = "Naziv";
            UslugaSearchRequest request = new UslugaSearchRequest
            {
                SmjestajId = _SmjestajId,
                Preporucene = true
            };
           var result = await _UslugaService.Get<List<UslugaModel>>(request);

            if ( result != null )
            {
                UslugaModel prazan = new UslugaModel
                {
                    Naziv = "Odaberite uslugu",
                    Opis = "",
                    UslugaId = 0,
                    UslugaSmjestajId = 0
                };
                result.Insert(0, prazan);
                cb_Usluge.DataSource = result;
            }
        }

        private async void btn_Dodaj_Postojecu_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(cb_Usluge.SelectedValue.ToString());
            if (id > 0)
            {
                UslugaInsertRequest request = new UslugaInsertRequest
                {
                    Nova = false,
                    UslugaId = id,
                    SmjestajId = _SmjestajId
                };

                await _UslugaService.Insert<UslugaInsertRequest>(request);

                UslugaSearchRequest request1 = new UslugaSearchRequest
                {
                    SmjestajId = _SmjestajId,
                    Preporucene = false
                };
                var lista = await _UslugaService.Get<List<UslugaModel>>(request1);

                if (lista != null)
                {
                    dgv_Usluge.DataSource = lista;
                }
            }
            else
                MessageBox.Show("Odaberite neku od usluga na listi");
        }

        private void btn_Nazad_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
    }

