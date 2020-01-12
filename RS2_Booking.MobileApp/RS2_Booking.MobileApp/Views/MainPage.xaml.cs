using RS2_Booking.MobileApp.Models;
using RS2_Booking.Model;
using RS2_Booking.Model.Requests;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RS2_Booking.MobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : MasterDetailPage
    {
        Dictionary<int, NavigationPage> MenuPages = new Dictionary<int, NavigationPage>();
        KorisnikModel Model = null;
        public MainPage(KorisnikModel k)
        {
            InitializeComponent();
            Model = k;
            MasterBehavior = MasterBehavior.Popover;

            this.NavigateFromMenu(0);

            //MenuPages.Add((int)MenuItemType.Browse, (NavigationPage)Detail);
        }

        public async Task NavigateFromMenu(int id)
        {
            if (!MenuPages.ContainsKey(id))
            {
                switch (id)
                {
                    case (int)MenuItemType.PretragaSmjestaja:
                        MenuPages.Add(id, new NavigationPage(new PocetnaPage(Model)));
                        break;
                    case (int)MenuItemType.Rezervacije:
                        MenuPages.Add(id, new NavigationPage(new RezervacijeViewPage(Model)));
                        break;
                    case (int)MenuItemType.Profil:
                        KorisnikInsertRequest request = new KorisnikInsertRequest();
                        MenuPages.Add(id, new NavigationPage(new RegisterPage(Model)));
                        break;
                    case (int)MenuItemType.Odjava:
                        Application.Current.MainPage = new LoginPage();
                        break;
                }
            }

            var newPage = MenuPages[id];

            if (newPage != null && Detail != newPage)
            {
                Detail = newPage;

                if (Device.RuntimePlatform == Device.Android)
                    await Task.Delay(100);

                IsPresented = false;
            }
        }
    }
}