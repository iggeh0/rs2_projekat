using RS2_Booking.MobileApp.Models;
using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RS2_Booking.MobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {
        MainPage RootPage { get => Application.Current.MainPage as MainPage; }
        List<HomeMenuItem> menuItems;
        public MenuPage()
        {
            InitializeComponent();

            menuItems = new List<HomeMenuItem>
            {
                new HomeMenuItem {Id = MenuItemType.PretragaSmjestaja, Title="Pretraga smještaja" },
                new HomeMenuItem {Id = MenuItemType.Rezervacije, Title="Rezervacije" },
                new HomeMenuItem {Id = MenuItemType.Profil, Title="Uredi profil" },
                new HomeMenuItem {Id = MenuItemType.Odjava, Title="Odjavi se" }
            };

            ListViewMenu.ItemsSource = menuItems;

            ListViewMenu.SelectedItem = menuItems[0];
            ListViewMenu.ItemSelected += async (sender, e) =>
            {
                if (e.SelectedItem == null)
                    return;

                var id = (int)((HomeMenuItem)e.SelectedItem).Id;
                if ( id == 3 )
                {
                    Application.Current.MainPage = new LoginPage();
                }
                else
                await RootPage.NavigateFromMenu(id);
            };
        }
    }
}