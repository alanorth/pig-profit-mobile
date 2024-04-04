using PigTool.Droid;
using PigTool.Interfaces;

[assembly: Xamarin.Forms.Dependency(typeof(FileService))]
namespace PigTool.Droid
{
    public class FileService : IFileService
    {
        public string GetDownloadFolderPath()
        {
            return Android.OS.Environment.GetExternalStoragePublicDirectory(Android.OS.Environment.DirectoryDownloads).AbsolutePath;
        }
    }
}
