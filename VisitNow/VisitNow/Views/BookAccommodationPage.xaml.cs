using VisitNow.Models;
using VisitNow.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VisitNow.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BookAccommodationPage : ContentPage
    {
        public BookAccommodationPage()
        {
            InitializeComponent();
            BindingContext = new BookAccommodationViewModel(this, null);
        }

        public BookAccommodationPage(Item item)
        {
            InitializeComponent();
            BindingContext = new BookAccommodationViewModel(this, item);
        }
    }
}