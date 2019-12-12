using RS2_Booking.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            cb_Grad.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void ClearErrors()
        {
            lbl_AdresaErr.Visible = false;
            lbl_EmailErr.Visible = false;
            lbl_GradErr.Visible = false;
            lbl_NazivErr.Visible = false;
            lbl_OpisErr.Visible = false;
            lbl_TelefonErr.Visible = false;
            lbl_UdaljenostErr.Visible = false;
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
            ClearErrors();
            bool valid = true;
            SmjestajModel Model = new SmjestajModel();
            Model.Adresa = tb_Adresa.Text;
            Model.KontaktTelefon = tb_Telefon.Text;
            Model.Naziv = tb_Naziv.Text;
            Model.Email = tb_Email.Text;
            Model.IzdavacId = _IzdavacId;
            Model.Opis = rtb_Opis.Text;

            if (Model.Adresa.Length < 2 || String.IsNullOrEmpty(Model.Adresa))
            {
                lbl_AdresaErr.Text = "Adresa mora biti duža od 2 karaktera!";
                lbl_AdresaErr.Visible = true;
                valid = false;
            }

            if (Model.KontaktTelefon.Length < 7 || String.IsNullOrEmpty(Model.KontaktTelefon) || !Regex.Match(Model.KontaktTelefon, @"^[0-9*#+]+$").Success)
            {
                    lbl_TelefonErr.Text = "Broj telefona nije validan!";
                    lbl_TelefonErr.Visible = true;
            }

                if (Model.Naziv.Length < 2 || String.IsNullOrEmpty(Model.Naziv))
                {
                    lbl_NazivErr.Text = "Naziv mora biti duži od 2 karaktera!";
                    lbl_NazivErr.Visible = true;
                    valid = false;

                }

                if (Model.Opis.Length < 2 || String.IsNullOrEmpty(Model.Opis))
                {
                    lbl_OpisErr.Text = "Naziv mora biti duži od 2 karaktera!";
                    lbl_OpisErr.Visible = true;
                    valid = false;

                }

                if (Model.Email.Length < 2 || String.IsNullOrEmpty(Model.Email))
                {
                    lbl_EmailErr.Text = "E-mail mora biti duži od 2 karaktera!";
                    lbl_EmailErr.Visible = true;
                    valid = false;

                }
                else
                {
                string regex = @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";
                    if (!Regex.Match(Model.Email,regex).Success)
                    {
                        lbl_EmailErr.Text = "E-mail nije validan!";
                        lbl_EmailErr.Visible = true;
                        valid = false;

                    }
                }

                if ((int)(cb_Grad.SelectedValue) == 0)
                {
                    lbl_GradErr.Text = "Morate odabrati grad!";
                    lbl_GradErr.Visible = true;
                    valid = false;
                }

                if (string.IsNullOrEmpty(tb_Udaljenost.Text))
                {
                    lbl_UdaljenostErr.Text = "Morate unijeti udaljenost od centra grada!";
                    lbl_UdaljenostErr.Visible = true;
                    valid = false;
                }

                if (valid)
                {
                    Model.Distanca = Int32.Parse(tb_Udaljenost.Text);
                    Model.GradId = (int)(cb_Grad.SelectedValue);
                    await _SmjestajService.Insert<SmjestajModel>(Model);
                    Close();
                }
            }
        }
    }
