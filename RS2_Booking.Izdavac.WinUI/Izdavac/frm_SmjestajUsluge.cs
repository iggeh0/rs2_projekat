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
                Opis = tb_Opis_Nova.Text
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
                if (dgv_Usluge.CurrentCell.ColumnIndex.Equals(3) && e.RowIndex != -1)
                { //TODO: DataGridView menjati
                    if (dgv_Usluge.CurrentCell != null)
                    {
                        var id = int.Parse(dgv_Usluge[e.ColumnIndex - 3, e.RowIndex].Value.ToString());
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
        }
    }

