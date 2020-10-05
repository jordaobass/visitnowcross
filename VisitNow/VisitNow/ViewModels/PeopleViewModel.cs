using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using VisitNow.Models;
using Xamarin.Forms;

namespace VisitNow.ViewModels
{
    public class PeopleViewModel : BaseViewModel
    {
        public ObservableCollection<Person> People { get; set; }
        public Command LoadPeopleCommand { get; set; }

        public PeopleViewModel(Page context)
        {
            Title = "Pessoas";
            Context = context;
            People = new ObservableCollection<Person>();
            LoadPeopleCommand = new Command(async () => await ExecuteLoadPeopleCommand());
        }

        async Task ExecuteLoadPeopleCommand()
        {
            if (IsBusy)
            {
                return;
            }

            IsBusy = true;

            try
            {
                People.Clear();
                ObservableCollection<Person> people = new ObservableCollection<Person>()
                {
                    new Person()
                    {
                        ProfileImage = "avatar",
                        Name = "Fulano de Tal",
                        IsChild = false
                    },
                    new Person()
                    {
                        ProfileImage = "avatar3",
                        Name = "Fulana de Tal",
                        IsChild = false
                    },
                    new Person()
                    {
                        ProfileImage = "avatar5",
                        Name = "Fulano de Tal Jr",
                        IsChild = true
                    }
                };

                foreach (var item in people)
                {
                    People.Add(item);
                    await Task.Delay(500);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
