using System;
using VisitNowHoteleiro.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VisitNowHoteleiro.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HotelPage : ContentPage
    {
        HotelViewModel viewModel;

        public HotelPage()
        {
            InitializeComponent();
            BindingContext = viewModel = new HotelViewModel(this);
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (viewModel.Hotels.Count == 0)
            {
                viewModel.LoadHotelsCommand.Execute(null);
            }
        }

        async void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            await Navigation.PushAsync(new HotelCrudPage());
        }

        async void AddItems_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HotelCrudPage());
        }
    }
}