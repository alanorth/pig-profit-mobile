using Android.Content.PM;
using PigTool.Droid;
using PigTool.Interfaces;
using Xamarin.Forms;

[assembly: Dependency(typeof(AppVersionService))]
namespace PigTool.Droid
{
    public class AppVersionService : IAppVersionService
    {
        public string GetVersionNumber()
        {
            PackageManager manager = Android.App.Application.Context.PackageManager;
            PackageInfo info = manager.GetPackageInfo(Android.App.Application.Context.PackageName, 0);
            return info.VersionName;
        }

        public int GetVersionCode()
        {
            PackageManager manager = Android.App.Application.Context.PackageManager;
            PackageInfo info = manager.GetPackageInfo(Android.App.Application.Context.PackageName, 0);
            return info.VersionCode;
        }
    }
}