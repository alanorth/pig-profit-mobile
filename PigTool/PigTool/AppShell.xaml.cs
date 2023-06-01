using PigTool.Services;
using PigTool.Views;
using Shared;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PigTool
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            registerRoutes();
        }

        private void registerRoutes()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(HomePage), typeof(HomePage));
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
            Routing.RegisterRoute(nameof(AddDataPage), typeof(AddDataPage));
            Routing.RegisterRoute(nameof(ManageDataPage), typeof(ManageDataPage));
            Routing.RegisterRoute(nameof(ReportsPage), typeof(ReportsPage));

            Routing.RegisterRoute(nameof(SettingsPage), typeof(SettingsPage));
            Routing.RegisterRoute(nameof(SettingsPage) + "/" + nameof(EditUserPage), typeof(EditUserPage));
        }

        public  AppShell(UserLangSettings u)
        {
            registerRoutes();

            PopulateTitles(u);
        }

        private async Task PopulateTitles(UserLangSettings u)
        {
            var repo = DependencyService.Get<IDataRepo>();

            var home = await repo.GetTranslationAsync(nameof(HomeTile));
            var addData = await repo.GetTranslationAsync(nameof(AddDataTile));
            var manageData = await repo.GetTranslationAsync(nameof(ManageDataTile));
            var reports = await repo.GetTranslationAsync(nameof(ReportsTile));
            var settings = await repo.GetTranslationAsync(nameof(SettingsTile));
            var upload = await repo.GetTranslationAsync(nameof(UploadTile));

            HomeTile.Title = home.getTranslation(u);
            AddDataTile.Title = addData.getTranslation(u);
            ManageDataTile.Title = manageData.getTranslation(u);
            ReportsTile.Title = reports.getTranslation(u);
            SettingsTile.Title = settings.getTranslation(u);
            UploadTile.Title = upload.getTranslation(u);

        }

    }
}
