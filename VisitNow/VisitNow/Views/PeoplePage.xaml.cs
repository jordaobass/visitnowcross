using System;
using VisitNow.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VisitNow.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PeoplePage : ContentPage
    {
        PeopleViewModel viewModel;

        public PeoplePage()
        {
            InitializeComponent();
            BindingContext = viewModel = new PeopleViewModel(this);
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (viewModel.People.Count == 0)
            {
                viewModel.LoadPeopleCommand.Execute(null);
            }
        }

        async void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            await Navigation.PushAsync(new PeopleCrudPage());
        }

        async void AddNew_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PeopleCrudPage());
        }
    }
}