using RS2_Booking.MobileApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RS2_Booking.MobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IzdavacViewPage : ContentPage
    {
        IzdavacVM Model = null;

        public IzdavacViewPage()
        {
            InitializeComponent();
        }

        public IzdavacViewPage(int izdavacId)
        {
            InitializeComponent();
            Model = new IzdavacVM
            {
                IzdavacId = izdavacId
            };
            BindingContext = Model;
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await Model.Ucitaj();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new PocetnaPage(Model.sacuvani);
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var Odabrani = e.Item;

            PropertyInfo pi = Odabrani.GetType().GetProperty("SmjestajId");
            int id = Convert.ToInt32(pi.GetValue(Odabrani, null).ToString());
            Application.Current.MainPage = new SmjestajViewPage(id, Model.KorisnikId);
        }
    }
}