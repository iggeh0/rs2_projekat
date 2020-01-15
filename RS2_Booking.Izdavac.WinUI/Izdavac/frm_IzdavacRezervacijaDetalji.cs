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
    public partial class frm_IzdavacRezervacijaDetalji : Form
    {
        private readonly APIService _rezervacijaService = new APIService("rezervacija");
        private readonly APIService _uplataService = new APIService("rezervacija/DodajUplatu");
        private readonly APIService _rezervacijaStatusService = new APIService("rezervacija/PromjeniStatus");


        private int _RezervacijaId;
        private int _StatusRezervacijeId;
        private double _Ukupno;
        public frm_IzdavacRezervacijaDetalji(int RezervacijaId)
        {
            InitializeComponent();
            _RezervacijaId = RezervacijaId;
            dgv_Uplate.AutoGenerateColumns = false;
            dgv_Sobe.AutoGenerateColumns = false;
        }

        private async void frm_IzdavacRezervacijaDetalji_Load(object sender, EventArgs e)
        {

            var Rezervacija = await _rezervacijaService.GetById<RezervacijaModel>(_RezervacijaId);
            _StatusRezervacijeId = Rezervacija.StatusRezervacijeId;

            if ( _StatusRezervacijeId == 1 )
            {
                btn_Prihvati.Visible = true;

            }
            else if ( _StatusRezervacijeId == 2 )
            {
                btn_Otkazi.Visible = true;
            }
            else
            {
                btn_Otkazi.Visible = false;
                btn_Prihvati.Visible = false;
            }

            dgv_Sobe.DataSource = Rezervacija.Sobe;

            lbl_DatumDo.Text = Rezervacija.RezervacijaOdShort;
            lbl_DatumOd.Text = Rezervacija.RezervacijaDoShort;

            if ( DateTime.Now >= Convert.ToDateTime(Rezervacija.RezervacijaDoShort) )
            {
                btn_Otkazi.Visible = false;
                btn_Prihvati.Visible = false;
                btn_Zavrsi.Visible = true;
            }

            lbl_DatumKreiranja.Text = Rezervacija.DatumRezervacijeShort;
            lbl_Djeca.Text = Rezervacija.BrojDjece.ToString();
            lbl_Odrasli.Text = Rezervacija.BrojOdraslih.ToString();
            lbl_SmjestajNaziv.Text = Rezervacija.NazivSmjestaja;
            lbl_Status.Text = Rezervacija.StatusRezervacijeNaziv;
            lbl_ImePrezime.Text = Rezervacija.ImeKlijenta + " " + Rezervacija.PrezimeKlijenta;
            if ( Rezervacija.Uplate != null && Rezervacija.Uplate.Count > 0 )
            {
                _Ukupno = 0;
                double ukupno = 0;
                foreach ( UplataModel u in Rezervacija.Uplate )
                {
                    ukupno += u.Iznos;
                }

                dgv_Uplate.DataSource = Rezervacija.Uplate;
                _Ukupno = ukupno;
                lbl_Ukupno.Text = _Ukupno.ToString();
               
            }
            else
            {
                _Ukupno = 0;
                lbl_Ukupno.Text = _Ukupno.ToString();
            }

        }

        private async void btn_Prihvati_Click(object sender, EventArgs e)
        {
            RezervacijaChangeStatusRequest request = new RezervacijaChangeStatusRequest();
            request.RezervacijaId = _RezervacijaId;
            request.StatusId = 2;
            await _rezervacijaStatusService.Insert<RezervacijaChangeStatusRequest>(request);
            btn_Prihvati.Visible = false;
            lbl_Status.Text = "Aktivna";
        }

        private async void btn_Otkazi_Click(object sender, EventArgs e)
        {
            RezervacijaChangeStatusRequest request = new RezervacijaChangeStatusRequest();
            request.RezervacijaId = _RezervacijaId;
            request.StatusId = 4;
            await _rezervacijaStatusService.Insert<RezervacijaChangeStatusRequest>(request);
            btn_Otkazi.Visible = false;
        }

        private async void btn_DodajUplatu_Click(object sender, EventArgs e)
        {
            if ( (Convert.ToDouble(tb_UplataIznos.Text) > 0 ))
            {
                UplataInsertRequest request = new UplataInsertRequest();
                request.DatumUplate = DateTime.Now;
                request.Iznos = Convert.ToDouble(tb_UplataIznos.Text);
                request.RezervacijaId = _RezervacijaId;
                List<UplataModel> lista = await _uplataService.Insert<List<UplataModel>>(request);
                dgv_Uplate.DataSource = lista;

                _Ukupno = 0;
                double ukupno = 0;
                foreach (UplataModel u in lista)
                {
                    ukupno += u.Iznos;
                }
                _Ukupno = ukupno;
                lbl_Ukupno.Text = _Ukupno.ToString();

            }
        }

        private async void btn_Zavrsi_Click(object sender, EventArgs e)
        {
            RezervacijaChangeStatusRequest request = new RezervacijaChangeStatusRequest();
            request.RezervacijaId = _RezervacijaId;
            request.StatusId = 1002;
            await _rezervacijaStatusService.Insert<RezervacijaChangeStatusRequest>(request);
            btn_Zavrsi.Visible = false;
        }
    }
}
