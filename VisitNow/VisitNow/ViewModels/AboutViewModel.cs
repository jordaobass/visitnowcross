using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace VisitNow.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        private Models.AboutModel aboutModel;
        public Models.AboutModel AboutModel
        {
            get { return aboutModel; }
            set
            {
                aboutModel = value;
                OnPropertyChanged("AboutModel");
            }
        }

        public AboutViewModel()
        {
            Title = "Sobre";
            OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://xamarin.com/platform")));

            AboutModel = new Models.AboutModel();
            GetAppVersion();
        }

        public ICommand OpenWebCommand { get; }

        private void GetAppVersion()
        {
            aboutModel.VersionNumber = DependencyService.Get<IAppVersion>().GetBuild();
            aboutModel.VersionName = DependencyService.Get<IAppVersion>().GetVersion();
        }
    }
}