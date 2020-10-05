using System;
using System.Collections.ObjectModel;

namespace VisitNow.Models
{
    public class BookAccommodation
    {
        public string ItemId { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public ObservableCollection<Person> Guests { get; set; }
        public ObservableCollection<Person> Children { get; set; }
        public ObservableCollection<PaymentMethod> Payments { get; set; }
    }
}
