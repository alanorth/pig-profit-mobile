using PigTool.Services;
using PigTool.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLLiteDbContext;
using System.Threading.Tasks;

//fontawesome
[assembly: ExportFont("fa-regular-400.ttf", Alias = "FA-R")]
[assembly: ExportFont("fa-solid-900.ttf", Alias = "FA-S")]
[assembly: ExportFont("fa-brands-400.ttf", Alias = "FA-B")]
namespace PigTool
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();
            //DependencyService.Register<DbSQLLiteContext>();
            DependencyService.Register<MockDataStore>();
            DependencyService.Register<IDataRepo, DataRepo>();
            //MainPage = new NavigationPage(new LoginPage());
            DisplayMainPage();
        }


        public static async Task<bool> IsAppInitialized()
        {
            return false;
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }

        public void DisplayMainPage()
        {
            MainPage = new AppShell();
        }
    }
}
