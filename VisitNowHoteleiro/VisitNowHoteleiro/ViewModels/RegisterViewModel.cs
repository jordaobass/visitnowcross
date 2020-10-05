using VisitNowHoteleiro.Models;
using Xamarin.Forms;

namespace VisitNowHoteleiro.ViewModels
{
    public class RegisterViewModel : BaseViewModel
    {
        public Register RegisterModel { get; set; }

        public RegisterViewModel(Page context)
        {
            Title = "Registrar";
            Context = context;
        }
    }
}
