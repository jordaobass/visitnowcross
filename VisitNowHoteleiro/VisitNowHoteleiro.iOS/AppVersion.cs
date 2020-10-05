using Foundation;

[assembly: Xamarin.Forms.Dependency(typeof(VisitNowHoteleiro.iOS.AppVersion))]
namespace VisitNowHoteleiro.iOS
{
    public class AppVersion : IAppVersion
    {
        public string GetBuild()
        {
            return NSBundle.MainBundle.ObjectForInfoDictionary("CFBundleVersion").ToString();
        }

        public string GetVersion()
        {
            return NSBundle.MainBundle.ObjectForInfoDictionary("CFBundleShortVersionString").ToString();
        }
    }
}