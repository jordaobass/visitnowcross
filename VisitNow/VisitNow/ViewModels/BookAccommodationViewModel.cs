using System.Collections.ObjectModel;
using System.Threading.Tasks;
using VisitNow.Models;
using Xamarin.Forms;

namespace VisitNow.ViewModels
{
    public class BookAccommodationViewModel : BaseViewModel
    {
        public BookAccommodation BookAccommodationModel { get; set; }
        public Item ItemModel { get; set; }

        public BookAccommodationViewModel(Page context, Item itemModel)
        {
            Title = "Reservar";
            Context = context;
            ItemModel = itemModel;

            BookAccommodationModel = new BookAccommodation();
            BookAccommodationModel.ItemId = ItemModel.Id;

            LoadResources();
        }

        public async void LoadResources()
        {
            IsBusy = true;

            BookAccommodationModel.Guests = new ObservableCollection<Person>()
            {
                new Person()
                {
                    ProfileImage = "avatar",
                    Name = "Fulano de Tal",
                },
                new Person()
                {
                    ProfileImage = "avatar3",
                    Name = "Fulana de Tal",
                }
            };
            
            BookAccommodationModel.Children = new ObservableCollection<Person>()
            {
                new Person()
                {
                    ProfileImage = "avatar5",
                    Name = "Fulano de Tal Jr",
                }
            };
            
            BookAccommodationModel.Payments = new ObservableCollection<PaymentMethod>()
            {
                new PaymentMethod()
                {
                    CardNumber = "...****.0000",
                    Flag = "card_mastercard"
                },
                new PaymentMethod()
                {
                    CardNumber = "...****.1111",
                    Flag = "card_visa"
                }
            };

            #region Monta o layout para selecionar adultos
            StackLayout stackLayoutSectionGuests = Context.FindByName<StackLayout>("StackLayoutSectionGuests");
            foreach (var item in BookAccommodationModel.Guests)
            {
                StackLayout stackLayoutGuest = new StackLayout()
                {
                    Orientation = StackOrientation.Horizontal
                };

                Switch switchGuest = new Switch();

                Frame frameGuest = new Frame()
                {
                    Padding = 1,
                    WidthRequest = 45,
                    BorderColor = Color.LightGray,
                    HasShadow = false,
                };

                Image imageGuest = new Image()
                {
                    Source = item.ProfileImage
                };

                Label labelGuest = new Label()
                {
                    Margin = new Thickness(10, 0, 0, 0),
                    VerticalOptions = LayoutOptions.Center,
                    Text = item.Name,
                    LineBreakMode = LineBreakMode.NoWrap,
                    FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label))
                };

                frameGuest.Content = imageGuest;
                stackLayoutGuest.Children.Add(switchGuest);
                stackLayoutGuest.Children.Add(frameGuest);
                stackLayoutGuest.Children.Add(labelGuest);
                stackLayoutSectionGuests.Children.Add(stackLayoutGuest);
            }
            #endregion

            #region Monta o layout para selecionar crianças
            StackLayout stackLayoutSectionChildren = Context.FindByName<StackLayout>("StackLayoutSectionChildren");
            foreach (var item in BookAccommodationModel.Children)
            {
                StackLayout stackLayoutChildren = new StackLayout()
                {
                    Orientation = StackOrientation.Horizontal
                };

                Switch switchChildren = new Switch();

                Frame frameChildren = new Frame()
                {
                    Padding = 1,
                    WidthRequest = 45,
                    BorderColor = Color.LightGray,
                    HasShadow = false,
                };

                Image imageChildren = new Image()
                {
                    Source = item.ProfileImage
                };

                Label labelChildren = new Label()
                {
                    Margin = new Thickness(10, 0, 0, 0),
                    VerticalOptions = LayoutOptions.Center,
                    Text = item.Name,
                    LineBreakMode = LineBreakMode.NoWrap,
                    FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label))
                };

                frameChildren.Content = imageChildren;
                stackLayoutChildren.Children.Add(switchChildren);
                stackLayoutChildren.Children.Add(frameChildren);
                stackLayoutChildren.Children.Add(labelChildren);
                stackLayoutSectionChildren.Children.Add(stackLayoutChildren);
            }
            #endregion

            #region Monta o layout para selecionar pagamento
            StackLayout stackLayoutSectionPayments = Context.FindByName<StackLayout>("StackLayoutSectionPayments");
            foreach (var item in BookAccommodationModel.Payments)
            {
                StackLayout stackLayoutPayments = new StackLayout()
                {
                    Orientation = StackOrientation.Horizontal
                };

                Switch switchPayments = new Switch();

                Frame framePayments = new Frame()
                {
                    Padding = 1,
                    WidthRequest = 45,
                    BorderColor = Color.LightGray,
                    HasShadow = false,
                };

                Image imagePayments = new Image()
                {
                    Source = item.Flag
                };

                Label labelPayments = new Label()
                {
                    Margin = new Thickness(10, 0, 0, 0),
                    VerticalOptions = LayoutOptions.Center,
                    Text = item.CardNumber.ToString(),
                    LineBreakMode = LineBreakMode.NoWrap,
                    FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label))
                };

                framePayments.Content = imagePayments;
                stackLayoutPayments.Children.Add(switchPayments);
                stackLayoutPayments.Children.Add(framePayments);
                stackLayoutPayments.Children.Add(labelPayments);
                stackLayoutSectionPayments.Children.Add(stackLayoutPayments);
            }
            #endregion

            await Task.Delay(3000);
            
            IsBusy = false;
        }
    }
}
