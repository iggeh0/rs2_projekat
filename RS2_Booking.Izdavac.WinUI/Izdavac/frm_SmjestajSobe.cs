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
    public partial class frm_SmjestajSobe : Form
    {
        private readonly APIService _SobaService = new APIService("soba");

        private int _SmjestajId = 0;

        public frm_SmjestajSobe(int SmjestajId)
        {
            _SmjestajId = SmjestajId;
            InitializeComponent();
        }

        private void btn_DodajSobu_Click(object sender, EventArgs e)
        {
            frm_DodajSobe Form = new frm_DodajSobe(_SmjestajId);
            Form.Show();

            this.Close();
        }

        private async void frm_SmjestajSobe_Load(object sender, EventArgs e)
        {
            SobaSearchRequest request = new SobaSearchRequest();
            request.SmjestajId = _SmjestajId;
            var result = await _SobaService.Get<List<SobaModel>>(request);

            dgv_Sobe.AutoGenerateColumns = false;
            dgv_Sobe.DataSource = result;
        }

        private void btn_Nazad_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_Sobe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Sobe.CurrentCell.ColumnIndex.Equals(6) && e.RowIndex != -1)
            {
                if (dgv_Sobe.CurrentCell != null)
                {
                    var id = int.Parse(dgv_Sobe[e.ColumnIndex - 6, e.RowIndex].Value.ToString());
                    frm_UrediSobe Form = new frm_UrediSobe(id, _SmjestajId);
                    Form.Show();
                    this.Close();
                }

            }
            else if (dgv_Sobe.CurrentCell.ColumnIndex.Equals(7))
            {
                var id = int.Parse(dgv_Sobe[e.ColumnIndex - 7, e.RowIndex].Value.ToString());
         
            }
        }
    }
}
