using System.Collections.ObjectModel;
using VisitNow.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VisitNow.ViewTemplates
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddressView : ContentView
    {
        public AddressView()
        {
            InitializeComponent();

            LoadPickerStatesData();
        }

        private void LoadPickerStatesData()
        {
            ObservableCollection<State> states = new ObservableCollection<State>()
            {
                new State() {
                    Id = 1,
	                ShortName = "AC",
	                Name = "Acre"
                },
                new State() {
	                Id = 2,
	                ShortName = "AL",
	                Name = "Alagoas"
                },
                new State() {
	                Id = 3,
	                ShortName = "AM",
	                Name = "Amazonas"
                },
                new State() {
	                Id = 4,
	                ShortName = "AP",
	                Name = "Amapá"
                },
                new State() {
	                Id = 5,
	                ShortName = "BA",
	                Name = "Bahia"
                },
                new State() {
	                Id = 6,
	                ShortName = "CE",
	                Name = "Ceará"
                },
                new State() {
	                Id = 7,
	                ShortName = "DF",
	                Name = "Distrito Federal"
                },
                new State() {
	                Id = 8,
	                ShortName = "ES",
	                Name = "Espírito Santo"
                },
                new State() {
	                Id = 9,
	                ShortName = "GO",
	                Name = "Goiás"
                },
                new State() {
	                Id = 10,
	                ShortName = "MA",
	                Name = "Maranhão"
                },
                new State() {
	                Id = 11,
	                ShortName = "MG",
	                Name = "Minas Gerais"
                },
                new State() {
	                Id = 12,
	                ShortName = "MS",
	                Name = "Mato Grosso do Sul"
                },
                new State() {
	                Id = 13,
	                ShortName = "MT",
	                Name = "Mato Grosso"
                },
                new State() {
	                Id = 14,
	                ShortName = "PA",
	                Name = "Pará"
                },
                new State() {
	                Id = 15,
	                ShortName = "PB",
	                Name = "Paraíba"
                },
                new State() {
	                Id = 16,
	                ShortName = "PE",
	                Name = "Pernambuco"
                },
                new State() {
	                Id = 17,
	                ShortName = "PI",
	                Name = "Piauí"
                },
                new State() {
	                Id = 18,
	                ShortName = "PR",
	                Name = "Paraná"
                },
                new State() {
	                Id = 19,
	                ShortName = "RJ",
	                Name = "Rio de Janeiro"
                },
                new State() {
	                Id = 20,
	                ShortName = "RN",
	                Name = "Rio Grande do Norte"
                },
                new State() {
	                Id = 21,
	                ShortName = "RO",
	                Name = "Rondônia"
                },
                new State() {
	                Id = 22,
	                ShortName = "RR",
	                Name = "Roraima"
                },
                new State() {
	                Id = 23,
	                ShortName = "RS",
	                Name = "Rio Grande do Sul"
                },
                new State() {
	                Id = 24,
	                ShortName = "SC",
	                Name = "Santa Catarina"
                },
                new State() {
	                Id = 25,
	                ShortName = "SE",
	                Name = "Sergipe"
                },
                new State() {
	                Id = 26,
	                ShortName = "SP",
	                Name = "São Paulo"
                },
                new State() {
	                Id = 27,
	                ShortName = "TO",
	                Name = "Tocantins"
                }
            };

            PickerStates.ItemsSource = states;
            PickerStates.ItemDisplayBinding = new Binding("Name");
        }
    }
}