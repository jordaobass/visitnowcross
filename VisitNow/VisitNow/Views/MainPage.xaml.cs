using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using Xamarin.Forms;
using VisitNow.Models;
using VisitNow.Infra;

namespace VisitNow.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : MasterDetailPage
    {
        Dictionary<int, NavigationPage> MenuPages = new Dictionary<int, NavigationPage>();
        public MainPage()
        {
            InitializeComponent();

            MasterBehavior = MasterBehavior.Popover;

            MenuPages.Add((int)MenuItemType.Items, (NavigationPage)Detail);
        }

        public async Task NavigateFromMenu(int id)
        {
            if (!MenuPages.ContainsKey(id))
            {
                switch (id)
                {
                    case (int)MenuItemType.Items:
                        MenuPages.Add(id, new NavigationPage(new ItemsPage()));
                        break;
                    case (int)MenuItemType.Reservations:
                        MenuPages.Add(id, new NavigationPage(new ReservationsTabbedPage()));
                        break;
                    case (int)MenuItemType.People:
                        MenuPages.Add(id, new NavigationPage(new PeoplePage()));
                        break;
                    case (int)MenuItemType.PaymentMethod:
                        MenuPages.Add(id, new NavigationPage(new PaymentMethodPage()));
                        break;
                    case (int)MenuItemType.About:
                        MenuPages.Add(id, new NavigationPage(new AboutPage()));
                        break;
                    case (int)MenuItemType.Exit:
                        var answer = await DisplayAlert("Sair", "Você quer sair do aplicativo?", "Sim", "Não");
                        if (answer)
                        {
                            SharedPreferencesManager.SaveOrUpdate("Token", null);
                            Application.Current.MainPage = new NavigationPage(new AuthPage());
                            return;
                        }
                        return;
                        //break;
                }
            }

            var newPage = MenuPages[id];

            if (newPage != null && Detail != newPage)
            {
                Detail = newPage;

                if (Device.RuntimePlatform == Device.Android)
                {
                    await Task.Delay(100);
                }

                IsPresented = false;
            }
        }
    }
}