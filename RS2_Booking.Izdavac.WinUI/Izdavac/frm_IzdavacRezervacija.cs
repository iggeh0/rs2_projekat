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
    
    public partial class frm_IzdavacRezervacija : Form
    {
        private readonly int _KorisnikId;
        private readonly APIService _SmjestajService = new APIService("rezervacija/GetAllForIzdavac");

        public frm_IzdavacRezervacija(int KorisnikId)
        {
            InitializeComponent();
            _KorisnikId = KorisnikId;
            dgv_Aktivne.AutoGenerateColumns = false;
            dgv_Cekanje.AutoGenerateColumns = false;
            dgv_Zavrsene.AutoGenerateColumns = false;
        }

        private async void frm_IzdavacRezervacija_Load(object sender, EventArgs e)
        {
            RezervacijaSearchRequest request = new RezervacijaSearchRequest();
            request.KlijentId = _KorisnikId;
            List<RezervacijaModel> lista = await _SmjestajService.Get<List<RezervacijaModel>>(request);

            if (lista.Count > 0)
            {
                List<RezervacijaModel> ListaCekanje = new List<RezervacijaModel>();
                List<RezervacijaModel> ListaAktivno = new List<RezervacijaModel>();
                List<RezervacijaModel> ListaZavrseno = new List<RezervacijaModel>();

                foreach (RezervacijaModel r in lista )
                {
                    if (r.StatusRezervacijeId == 1)
                    {
                        ListaCekanje.Add(r);
                    }
                    else if (r.StatusRezervacijeId == 2)
                    {
                        ListaAktivno.Add(r);
                    }
                    else
                        ListaZavrseno.Add(r);
                }
                dgv_Cekanje.DataSource = ListaCekanje;
                dgv_Aktivne.DataSource = ListaAktivno;
                dgv_Zavrsene.DataSource = ListaZavrseno;
            }

        }

        private void dgv_Cekanje_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Cekanje.CurrentCell.ColumnIndex.Equals(8) && e.RowIndex != -1)
            {
                if (dgv_Cekanje.CurrentCell != null)
                {
                    var id = int.Parse(dgv_Cekanje[e.ColumnIndex - 8, e.RowIndex].Value.ToString());
                    frm_IzdavacRezervacijaDetalji Form = new frm_IzdavacRezervacijaDetalji(id);
                    Form.Show();
                    //Close();
                }

            }
        }

        private void dgv_Aktivne_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Aktivne.CurrentCell.ColumnIndex.Equals(8) && e.RowIndex != -1)
            {
                if (dgv_Aktivne.CurrentCell != null)
                {
                    var id = int.Parse(dgv_Aktivne[e.ColumnIndex - 8, e.RowIndex].Value.ToString());
                    frm_IzdavacRezervacijaDetalji Form = new frm_IzdavacRezervacijaDetalji(id);
                    Form.Show();
                    //Close();
                }

            }
        }

        private void dgv_Zavrsene_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Zavrsene.CurrentCell.ColumnIndex.Equals(8) && e.RowIndex != -1)
            {
                if (dgv_Zavrsene.CurrentCell != null)
                {
                    var id = int.Parse(dgv_Zavrsene[e.ColumnIndex - 8, e.RowIndex].Value.ToString());
                    frm_IzdavacRezervacijaDetalji Form = new frm_IzdavacRezervacijaDetalji(id);
                    Form.Show();
                    //Close();
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
