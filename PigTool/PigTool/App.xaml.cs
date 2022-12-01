using PigTool.Services;
using PigTool.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLLiteDbContext;
using System.Threading.Tasks;
using Shared;
using Microsoft.EntityFrameworkCore;

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
            //DependencyService.Register<MockDataStore>();
            DependencyService.Register<IDataRepo, DataRepo>();
            //MainPage = new NavigationPage(new LoginPage());
            InitializeDatabase();

            var IsAppInitialized = Task.Run(() => App.IsAppInitialized()).GetAwaiter().GetResult();

            if (IsAppInitialized)
            {
                DisplayMainPage();
            }
            else
            {
                DisplayLoginPage();
            }
        }


        public static async Task<bool> IsAppInitialized()
        {
#if DEBUG
            //return true;
#endif

            var repo = DependencyService.Get<IDataRepo>();

            var user = await repo.GetUserInfoAsync();

            if(user == null)
            {
                return false;
            }
            else
            {
                return true;
            }
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

        public void DisplayLoginPage()
        {
            MainPage = new NavigationPage(new LanguageSelectPage());
        }

        private void InitializeDatabase()
        {
            SQLitePCL.Batteries_V2.Init();
            using (var context = new DbSQLLiteContext())
            {
                context.Database.Migrate();
            }
        }
    }
}
