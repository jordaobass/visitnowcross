using VisitNowHoteleiro.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VisitNowHoteleiro.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HotelCrudPage : ContentPage
    {
        public HotelCrudPage()
        {
            InitializeComponent();
            BindingContext = new HotelCrudViewModel(this);
        }
    }
}