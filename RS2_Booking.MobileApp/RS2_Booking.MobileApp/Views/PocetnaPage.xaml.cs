﻿using RS2_Booking.MobileApp.ViewModels;
using RS2_Booking.Model;
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
    public partial class PocetnaPage : ContentPage
    {
        PocetnaVM Model = null;
        
        public PocetnaPage(KorisnikModel k)
        {
            InitializeComponent();
            Model = new PocetnaVM
            {
                sacuvani = k
            };
            BindingContext = Model;
          
        }
      
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await Model.Ucitaj();
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var Odabrani = e.Item;

            PropertyInfo pi = Odabrani.GetType().GetProperty("SmjestajId");
            int id = Convert.ToInt32(pi.GetValue(Odabrani,null).ToString());
            Application.Current.MainPage = new SmjestajViewPage(id, Model.sacuvani);
        }

    }
}