using VisitNow.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VisitNow.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
            BindingContext = new RegisterViewModel(this);
        }
    }
}