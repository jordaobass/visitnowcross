﻿using System;
using System.ComponentModel;
using Xamarin.Forms;
using VisitNowHoteleiro.Models;
using VisitNowHoteleiro.ViewModels;

namespace VisitNowHoteleiro.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class ItemsPage : ContentPage
    {
        ItemsViewModel viewModel;

        public ItemsPage()
        {
            InitializeComponent();

            BindingContext = viewModel = new ItemsViewModel();
        }

        async void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            var item = args.SelectedItem as Item;
            if (item == null)
                return;

            await Navigation.PushAsync(new ItemDetailPage(new ItemDetailViewModel(this, item)));

            // Manually deselect item.
            ItemsListView.SelectedItem = null;
        }

        async void SearchItems_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new SearchItemsPage()));
        }

        async void FilterItems_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new FilterItemsPage()));
        }

        async void AddItems_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new OfferCrudPage());
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (viewModel.Items.Count == 0)
                viewModel.LoadItemsCommand.Execute(null);
        }
    }
}