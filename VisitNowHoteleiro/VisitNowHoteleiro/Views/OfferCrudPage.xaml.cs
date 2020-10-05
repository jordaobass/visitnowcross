using System;
using System.IO;
using VisitNowHoteleiro.Infra.Services;
using VisitNowHoteleiro.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VisitNowHoteleiro.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OfferCrudPage : ContentPage
    {
        public OfferCrudPage()
        {
            InitializeComponent();
            BindingContext = new OfferCrudViewModel(this);
        }

        async void OnPickImageClicked(object sender, EventArgs e)
        {
            (sender as Image).IsEnabled = false;

            Stream stream = await DependencyService.Get<IPhotoPickerService>().GetImageStreamAsync();
            if (stream != null)
            {
                offerImage1.Source = ImageSource.FromStream(() => stream);
            }

            (sender as Image).IsEnabled = true;
        }
    }
}