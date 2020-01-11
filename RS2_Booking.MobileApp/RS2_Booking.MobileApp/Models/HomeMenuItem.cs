using System;
using System.Collections.Generic;
using System.Text;

namespace RS2_Booking.MobileApp.Models
{
    public enum MenuItemType
    {
        PretragaSmjestaja,
        Rezervacije,
        Profil,
        Odjava
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
