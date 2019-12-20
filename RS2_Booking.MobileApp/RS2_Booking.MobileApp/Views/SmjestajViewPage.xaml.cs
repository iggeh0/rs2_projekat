using RS2_Booking.MobileApp.ViewModels;
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
    public partial class SmjestajViewPage : ContentPage
    {
        private int _Id;
        SmjestajVM viewmodel = null;
        public SmjestajViewPage()
        {
            InitializeComponent();
        }

        public SmjestajViewPage(int id)
        {
            InitializeComponent();
            _Id = id;
            BindingContext = viewmodel = new SmjestajVM(id);           
        }
    }
}