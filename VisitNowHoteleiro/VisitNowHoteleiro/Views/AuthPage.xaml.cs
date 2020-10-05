using VisitNowHoteleiro.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VisitNowHoteleiro.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AuthPage : ContentPage
    {
        public AuthPage()
        {
            InitializeComponent();
            BindingContext = new AuthViewModel(this);
        }
    }
}