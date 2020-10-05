using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using VisitNowHoteleiro.Models;
using Xamarin.Forms;

namespace VisitNowHoteleiro.ViewModels
{
    public class HotelViewModel : BaseViewModel
    {
        public ObservableCollection<Hotel> Hotels { get; set; }
        public Command LoadHotelsCommand { get; set; }

        public HotelViewModel(Page context)
        {
            Context = context;
            Title = "Meus Hotéis";
            Hotels = new ObservableCollection<Hotel>();
            LoadHotelsCommand = new Command(async () => await ExecuteLoadHotelsCommand());

            //MessagingCenter.Subscribe<FilterItemsPage, Item>(this, "AddItem", async (obj, item) =>
            //{
            //    var newItem = item as Item;
            //    Items.Add(newItem);
            //    await DataStore.AddItemAsync(newItem);
            //});
        }

        async Task ExecuteLoadHotelsCommand()
        {
            if (IsBusy)
            {
                return;
            }

            IsBusy = true;

            try
            {
                Hotels.Clear();
                ObservableCollection<Hotel> hotels = new ObservableCollection<Hotel>()
                {
                    new Hotel()
                    {
                        Cnpj = 61179200000148,
                        PropertyName = "Xamarin e Visual Studio Tecnologia ME"
                    },
                    new Hotel()
                    {
                        Cnpj = 61179200000149,
                        PropertyName = "Xamarin e Visual Studio 2 Tecnologia ME"
                    }
                };

                foreach (var item in hotels)
                {
                    Hotels.Add(item);
                    await Task.Delay(500);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
