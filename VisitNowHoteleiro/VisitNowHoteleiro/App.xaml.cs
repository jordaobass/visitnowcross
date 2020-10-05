using Xamarin.Forms;
using VisitNowHoteleiro.Services;
using VisitNowHoteleiro.Views;
using VisitNowHoteleiro.Infra;

namespace VisitNowHoteleiro
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();

            object token = SharedPreferencesManager.GetByKey("Token");
            if (token == null)
            {
                MainPage = new NavigationPage(new AuthPage());
            }
            else if (string.IsNullOrEmpty(token.ToString()))
            {
                MainPage = new NavigationPage(new AuthPage());
            }
            else
            {
                MainPage = new MainPage();
            }
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
