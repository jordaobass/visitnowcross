using System.Threading.Tasks;
using System.Windows.Input;
using VisitNow.Models;
using VisitNow.Views;
using Xamarin.Forms;

namespace VisitNow.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel
    {
        public Item Item { get; set; }
        public ICommand BookAccommmodationCommand { private set; get; }

        public ItemDetailViewModel(Page context, Item item = null)
        {
            Context = context;
            Title = item?.Text;
            Item = item;

            BookAccommmodationCommand = new Command(() => OpenBookAccommodationPage());

            LoadData();
        }

        public async void OpenBookAccommodationPage()
        {
            await Context.Navigation.PushAsync(new BookAccommodationPage(Item));
        }

        public async void LoadData()
        {
            IsBusy = true;
            await Task.Delay(3000);
            IsBusy = false;
        }
    }
}
