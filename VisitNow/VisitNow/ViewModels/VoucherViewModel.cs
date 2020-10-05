using System.Collections.ObjectModel;
using System.Threading.Tasks;
using VisitNow.Models;
using Xamarin.Forms;

namespace VisitNow.ViewModels
{
    public class VoucherViewModel : BaseViewModel
    {
        public Item Item { get; set; }

        public VoucherViewModel(Page context, Item item = null)
        {
            Title = "Voucher";
            Context = context;
            Item = item;

            LoadData();
        }
        public async void LoadData()
        {
            IsBusy = true;
            
            await Task.Delay(3000);

            Item.Persons = new ObservableCollection<Person>()
            {
                new Person()
                {
                    ProfileImage = "avatar",
                    Name = "Fulano de Tal"
                },
                new Person()
                {
                    ProfileImage = "avatar3",
                    Name = "Fulana de Tal"
                },
                new Person()
                {
                    ProfileImage = "avatar5",
                    Name = "Fulano de Tal Jr",
                    IsChild = true
                }
            };

            StackLayout stackLayoutSectionGuests = Context.FindByName<StackLayout>("StackLayoutSectionGuests");
            foreach (var person in Item.Persons)
            {
                StackLayout stackLayoutGuest = new StackLayout()
                {
                    Orientation = StackOrientation.Horizontal
                };

                Image imageGuest = new Image()
                {
                    Source = person.ProfileImage,
                    HeightRequest = 40
                };

                Label labelGuest = new Label()
                {
                    VerticalOptions = LayoutOptions.Center,
                    Text = person.Name
                };

                Label labelGuestIsChild = new Label()
                {
                    HorizontalOptions = LayoutOptions.EndAndExpand,
                    VerticalOptions = LayoutOptions.Center,
                    Text = "\uf1ae",
                    FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                    TextColor = Color.SteelBlue,
                    IsVisible = person.IsChild,
                    FontFamily = Device.RuntimePlatform == Device.iOS ? "Font Awesome 5 Free" : "fa-solid-900.ttf#Font Awesome 5 Free Solid"
                };

                stackLayoutGuest.Children.Add(imageGuest);
                stackLayoutGuest.Children.Add(labelGuest);
                stackLayoutGuest.Children.Add(labelGuestIsChild);

                stackLayoutSectionGuests.Children.Add(stackLayoutGuest);
            }

            Item.PaymentMethods = new ObservableCollection<PaymentMethod>()
            {
                new PaymentMethod()
                {
                    CardNumber = "...****.0000",
                    Name = "Fulano de Tal",
                    Flag = "card_mastercard"
                }
            };

            StackLayout stackLayoutSectionPayments = Context.FindByName<StackLayout>("StackLayoutSectionPayments");
            foreach (var paymentMethod in Item.PaymentMethods)
            {
                StackLayout stackLayoutPaymentMethod = new StackLayout()
                {
                    Orientation = StackOrientation.Horizontal
                };

                Image imagePaymentMethod = new Image()
                {
                    Source = paymentMethod.Flag,
                    HeightRequest = 40
                };

                Label labelPaymentMethod = new Label()
                {
                    VerticalOptions = LayoutOptions.Center,
                    Text = paymentMethod.CardNumber + " / " + paymentMethod.Name
                };

                stackLayoutPaymentMethod.Children.Add(imagePaymentMethod);
                stackLayoutPaymentMethod.Children.Add(labelPaymentMethod);

                stackLayoutSectionPayments.Children.Add(stackLayoutPaymentMethod);
            }

            IsBusy = false;
        }
    }
}
