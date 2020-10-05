using Foundation;

[assembly: Xamarin.Forms.Dependency(typeof(VisitNow.iOS.AppVersion))]
namespace VisitNow.iOS
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