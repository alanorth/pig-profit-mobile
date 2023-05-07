using PigTool.Views;
using Xamarin.Forms;

namespace PigTool
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
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

    }
}
