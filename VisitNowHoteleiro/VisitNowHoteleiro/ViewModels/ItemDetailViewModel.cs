using System.Threading.Tasks;
using System.Windows.Input;
using VisitNowHoteleiro.Models;
using VisitNowHoteleiro.Views;
using Xamarin.Forms;

namespace VisitNowHoteleiro.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel
    {
        public Item Item { get; set; }
        public ICommand EditOfferCommand { private set; get; }

        public ItemDetailViewModel(Page context, Item item = null)
        {
            Context = context;
            Title = item?.Text;
            Item = item;

            EditOfferCommand = new Command(() => OpenEditOfferPage());

            LoadData();
        }

        public async void OpenEditOfferPage()
        {
            await Context.Navigation.PushAsync(new OfferCrudPage());
        }

        public async void LoadData()
        {
            IsBusy = true;
            await Task.Delay(3000);
            IsBusy = false;
        }
    }
}
