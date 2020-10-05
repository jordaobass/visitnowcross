using System.Windows.Input;
using VisitNowHoteleiro.Infra;
using VisitNowHoteleiro.Models;
using VisitNowHoteleiro.Views;
using Xamarin.Forms;

namespace VisitNowHoteleiro.ViewModels
{
    public class AuthViewModel : BaseViewModel
    {
        public Auth LoginModel { get; set; }
        public ICommand RegisterCommand { private set; get; }
        public ICommand LoginCommand { private set; get; }

        public  AuthViewModel(Page context)
        {
            Title = "Entrar";
            Context = context;

            RegisterCommand = new Command(() => OpenRegisterPage());
            LoginCommand = new Command(() => Login());
        }

        public async void OpenRegisterPage()
        {
            await Context.Navigation.PushAsync(new RegisterPage());
        }

        public void Login()
        {
            SharedPreferencesManager.SaveOrUpdate("Token", "123456");
            Application.Current.MainPage = new MainPage();
        }
    }
}
