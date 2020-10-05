using System;
using System.Collections.ObjectModel;

namespace VisitNowHoteleiro.Models
{
    public class Item
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public string Value { get; set; }
        public string ValueDescription { get; set; }
        public string Status { get; set; }
        public string HomeImage { get; set; }
        public ObservableCollection<string> Images { get; set; }
        public ObservableCollection<Person> Persons { get; set; }
        public ObservableCollection<PaymentMethod> PaymentMethods { get; set; }
        public int Rate { get; set; }
        public float UserRate { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public int DiscountValue { get; set; }

        public TimeSpan CheckInTime
        {
            get
            {
                return CheckIn.TimeOfDay;
            }
        }

        public TimeSpan CheckOutTime
        {
            get
            {
                return CheckOut.TimeOfDay;
            }
        }

        public bool Discount
        {
            get
            {
                if (DiscountValue > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}