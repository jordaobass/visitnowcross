using System;
using VisitNow.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VisitNow.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaymentMethodPage : ContentPage
    {
        PaymentMethodViewModel viewModel;

        public PaymentMethodPage()
        {
            InitializeComponent();
            BindingContext = viewModel = new PaymentMethodViewModel(this);
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (viewModel.PaymentMethods.Count == 0)
            {
                viewModel.LoadPaymentMethodsCommand.Execute(null);
            }
        }

        async void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            await Navigation.PushAsync(new PaymentMethodCrudPage());
        }
        async void AddNew_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PaymentMethodCrudPage());
        }

    }
}