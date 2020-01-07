﻿using RS2_Booking.MobileApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RS2_Booking.MobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RezervisiSmjestajPage : ContentPage
    {
        RezervisiSmjestajVM viewmodel = null;
        public RezervisiSmjestajPage(int KorisnikId, int SmjestajId)
        {
            viewmodel = new RezervisiSmjestajVM
            {
                SmjestajId = SmjestajId,
                KlijentId = KorisnikId
            };
            InitializeComponent();
            BindingContext = viewmodel;
        }
    }
}