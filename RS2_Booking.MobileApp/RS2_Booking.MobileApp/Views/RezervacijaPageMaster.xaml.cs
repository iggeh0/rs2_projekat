using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RS2_Booking.MobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RezervacijaPageMaster : ContentPage
    {
        public ListView ListView;

        public RezervacijaPageMaster()
        {
            InitializeComponent();

            BindingContext = new RezervacijaPageMasterViewModel();
            ListView = MenuItemsListView;
        }

        class RezervacijaPageMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<RezervacijaPageMasterMenuItem> MenuItems { get; set; }

            public RezervacijaPageMasterViewModel()
            {
                MenuItems = new ObservableCollection<RezervacijaPageMasterMenuItem>(new[]
                {
                    new RezervacijaPageMasterMenuItem { Id = 0, Title = "Page 1" },
                    new RezervacijaPageMasterMenuItem { Id = 1, Title = "Page 2" },
                    new RezervacijaPageMasterMenuItem { Id = 2, Title = "Page 3" },
                    new RezervacijaPageMasterMenuItem { Id = 3, Title = "Page 4" },
                    new RezervacijaPageMasterMenuItem { Id = 4, Title = "Page 5" },
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}