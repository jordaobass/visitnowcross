using System;

namespace VisitNowHoteleiro.Models
{
    public class Hotel
    {
        public int Id { get; set; }
        public long Cnpj { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string ProfileImage { get; set; }
        public string PropertyName { get; set; }
        public string ShortPropertyName
        {
            get
            {
                if (!String.IsNullOrEmpty(PropertyName))
                {
                    string[] arrayName = PropertyName.Split(' ');
                    return arrayName[0];
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
