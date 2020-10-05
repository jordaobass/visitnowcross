using VisitNow.Models;
using VisitNow.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VisitNow.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ReservationsTabbedPage : TabbedPage
    {
        ReservationsViewModel viewModel;

        public ReservationsTabbedPage()
        {
            InitializeComponent();
            BindingContext = viewModel = new ReservationsViewModel(this);
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (viewModel.Items.Count == 0)
            {
                viewModel.LoadItemsCommand.Execute(null);
            }
        }

        async void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            var item = args.SelectedItem as Item;
            if (item == null)
            {
                return;
            }

            await Navigation.PushAsync(new VoucherPage(item));

            // Manually deselect item.
            ItemsListViewTab1.SelectedItem = null;
            ItemsListViewTab2.SelectedItem = null;
        }
    }
}