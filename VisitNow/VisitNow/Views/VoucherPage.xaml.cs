using VisitNow.Models;
using VisitNow.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VisitNow.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VoucherPage : ContentPage
    {
        public VoucherPage()
        {
            InitializeComponent();
            BindingContext = new VoucherViewModel(this);
        }

        public VoucherPage(Item item)
        {
            InitializeComponent();
            BindingContext = new VoucherViewModel(this, item);
        }
    }
}