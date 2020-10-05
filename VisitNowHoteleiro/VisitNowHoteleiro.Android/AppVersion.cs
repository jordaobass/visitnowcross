using Android.Content.PM;

[assembly: Xamarin.Forms.Dependency(typeof(VisitNowHoteleiro.Droid.AppVersion))]
namespace VisitNowHoteleiro.Droid
{
    class AppVersion : IAppVersion
    {
        public string GetBuild()
        {
            var context = global::Android.App.Application.Context;

            PackageManager manager = context.PackageManager;
            PackageInfo info = manager.GetPackageInfo(context.PackageName, 0);

            return info.VersionCode.ToString();
        }
        public string GetVersion()
        {
            var context = global::Android.App.Application.Context;

            PackageManager manager = context.PackageManager;
            PackageInfo info = manager.GetPackageInfo(context.PackageName, 0);

            return info.VersionName;
        }
    }
}