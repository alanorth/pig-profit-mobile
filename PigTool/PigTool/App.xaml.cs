using PigTool.Services;
using PigTool.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLLiteDbContext;
using System.Threading.Tasks;
using Shared;
using Microsoft.EntityFrameworkCore;
using System.Globalization;

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
            try
            {
                DependencyService.Register<IDataRepo, DataRepo>();
                var databaseMessage = InitializeDatabase();

                if (!string.IsNullOrWhiteSpace(databaseMessage))
                {
                    DisplayedFailedloadupPage(databaseMessage);
                }
                else
                {
                    var IsAppInitialized = Task.Run(() => App.IsAppInitialized()).GetAwaiter().GetResult();

                    if (IsAppInitialized !=  null)
                    {
                        DisplayMainPage(IsAppInitialized.UserLang);
                    }
                    else
                    {
                        DisplayLoginPage();
                    }
                }
            }
            catch (Exception ex)
            {
                DisplayedFailedloadupPage(ex.InnerException?.Message);
            }
        }


        public static async Task<MobileUser> IsAppInitialized()
        {
#if DEBUG
            //return true;
#endif

            var repo = DependencyService.Get<IDataRepo>();

            try
            {
                var user = await repo.GetUserInfoAsync();



                if (user != null)
                {
                    return user;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                return null;
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

        public void DisplayMainPage(UserLangSettings userLang)
        {
            MainPage = new AppShell(userLang);
        }

        public void DisplayedFailedloadupPage(string Message)
        {
            MainPage = new FailedLoadUpPage(Message);
        }

        public void DisplayLoginPage()
        {
            MainPage = new NavigationPage(new LanguageSelectPage());
        }

        private string InitializeDatabase()
        {
            try
            {
                SQLitePCL.Batteries_V2.Init();
                using (var context = new DbSQLLiteContext())
                {
                    context.Database.Migrate();
                }

                return "";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private string DeleteDatabase()
        {
            try
            {
                SQLitePCL.Batteries_V2.Init();
                using (var context = new DbSQLLiteContext())
                {
                    context.Database.EnsureDeleted();
                }

                return "";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
