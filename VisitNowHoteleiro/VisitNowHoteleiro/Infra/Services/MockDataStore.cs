using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using VisitNowHoteleiro.Models;

namespace VisitNowHoteleiro.Services
{
    public class MockDataStore : IDataStore<Item>
    {
        ObservableCollection<Item> items;

        public MockDataStore()
        {
            items = new ObservableCollection<Item>();
            var mockItems = new ObservableCollection<Item>
            {
                new Item
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Quality Belo Horizonte Lourdes",
                    Text = "Superior King Não Fumante",
                    Description="Quarto não fumante com cama king size; TV LCD 32” a cabo; Ar condicionado split com controle remoto; Mesa de trabalho com conexão para internet; Internet banda larga e wi-fi cortesia; Cofres eletrônicos; Secador de cabelo; Mini cozinha, microondas; Ferro e tábua de passar roupa.",
                    Location="Belo Horizonte, Lourdes",
                    Value="R$ 450,00",
                    ValueDescription = "Por Noite",
                    HomeImage="demo_1_88947",
                    Images = new ObservableCollection<string>()
                    {
                        "demo_1_88947",
                        "demo_1_75141",
                        "demo_1_88951",
                        "demo_1_88950",
                        "demo_1_75142"
                    },
                    Status="Disponível",
                    CheckIn=DateTime.Now,
                    CheckOut=DateTime.Now.AddDays(1),
                    DiscountValue=10,
                    Rate=5,
                    UserRate=80.5F
                },
                new Item
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Promenade Pancetti",
                    Text = "Suíte Executiva Cama de Casal",
                    Description="Suite com 34 metros quadrados, com quarto e sala separados em dois ambientes. Quarto com cama queen-size e varanda. Crianças serão acomodadas em cama extra, mediante disponibilidade.",
                    Location="Belo Horizonte, Savassi",
                    Value="R$ 399,80",
                    ValueDescription = "Por Noite",
                    HomeImage="demo_2_85972",
                    Images = new ObservableCollection<string>()
                    {
                        "demo_2_85976",
                        "demo_2_85979",
                        "demo_2_101588",
                        "demo_2_85980",
                        "demo_2_101634"
                    },
                    Status="Disponível",
                    CheckIn=DateTime.Now,
                    CheckOut=DateTime.Now.AddDays(1),
                    DiscountValue=10,
                    Rate=4,
                    UserRate=89.5F
                },
                new Item
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Royal Boutique Savassi Hotel",
                    Text = "Apto Standard Casal",
                    Description="Apartamentos com 23m², localizados do 1° ao 5° andar e linha básica amenities Paul colins, equipados com ar condicionado, telefone, TV a cabo LCD 42”, acesso à internet, cofre eletrônico, vedação acústica nas janelas e enxoval de banho Troussardi.",
                    Location="Belo Horizonte, Savassi",
                    Value="R$ 427,87",
                    ValueDescription = "Por Noite",
                    HomeImage="demo_3_321495",
                    Images = new ObservableCollection<string>()
                    {
                        "demo_3_321495",
                        "demo_3_321494",
                        "demo_3_96287",
                        "demo_3_321492",
                        "demo_3_321496"
                    },
                    Status="Disponível",
                    CheckIn=DateTime.Now,
                    CheckOut=DateTime.Now.AddDays(1),
                    DiscountValue=0,
                    Rate=4,
                    UserRate=82.5F
                },
                new Item
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "eSuites Sion Savassi",
                    Text = "Superior Queen Não Fumante ",
                    Description="Apartamentos com 30 metros quadrados (em média) 1 Cama Casal 4 apartamentos PNE Cama Queen Size; TV 42 Polegadas; Ar Condicionado; Estação de Trabalho; Tábua e Ferro de passar roupas; Mini Cozinha com Minibar e Cook Top.",
                    Location="Belo Horizonte, Sion",
                    Value="R$ 330,50",
                    ValueDescription = "Por Noite",
                    HomeImage="demo_4_105940",
                    Images = new ObservableCollection<string>()
                    {
                        "demo_4_105940",
                        "demo_4_105937",
                        "demo_4_105941",
                        "demo_4_111310",
                        "demo_4_111318"
                    },
                    Status="Disponível",
                    CheckIn=DateTime.Now,
                    CheckOut=DateTime.Now.AddDays(1),
                    DiscountValue=15,
                    Rate=5,
                    UserRate=95.2F
                }
            };

            foreach (var item in mockItems)
            {
                items.Add(item);
            }
        }

        public async Task<bool> AddItemAsync(Item item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Item item)
        {
            var oldItem = items.Where((Item arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = items.Where((Item arg) => arg.Id == id).FirstOrDefault();
            items.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<Item> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Item>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}