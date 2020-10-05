using VisitNowHoteleiro.Models;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;

namespace VisitNowHoteleiro.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MenuPage : ContentPage
    {
        MainPage RootPage { get => Application.Current.MainPage as MainPage; }
        List<HomeMenuItem> menuItems;
        public MenuPage()
        {
            InitializeComponent();

            menuItems = new List<HomeMenuItem>
            {
                new HomeMenuItem { Id = MenuItemType.Browse, Icon="\uf015", Title="Home" },
                new HomeMenuItem { Id = MenuItemType.Hotel, Icon="\uf594", Title="Hotel" },
                new HomeMenuItem { Id = MenuItemType.About, Icon="\uf05a", Title="Sobre" },
                new HomeMenuItem { Id = MenuItemType.Exit, Icon="\uf2f5", Title="Sair" }
            };

            ListViewMenu.ItemsSource = menuItems;

            ListViewMenu.SelectedItem = menuItems[0];
            ListViewMenu.ItemSelected += async (sender, e) =>
            {
                if (e.SelectedItem == null)
                    return;

                var id = (int)((HomeMenuItem)e.SelectedItem).Id;
                await RootPage.NavigateFromMenu(id);
            };
        }
    }
}