using PigTool.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PigTool.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePageViewModel homePageViewModel;

        public HomePage()
        {
            InitializeComponent();
            BindingContext = homePageViewModel = new HomePageViewModel();

            // Adding three dot menu to homepage to access settings and logout
            /*
            ToolbarItem settingsItem = new ToolbarItem
            {
                Text = "Settings",
                Order = ToolbarItemOrder.Secondary,
                Priority = 0,
                Command = new Command(async () => await Application.Current.MainPage.Navigation.PushAsync(new SettingsPage()))
            };

            // "this" refers to a Page object
            this.ToolbarItems.Add(settingsItem);

            ToolbarItem logoutItem = new ToolbarItem
            {
                Text = "Logout",
                Order = ToolbarItemOrder.Secondary,
                Priority = 1,
                Command = new Command(async () => await Application.Current.MainPage.DisplayAlert("Logout", "To be added", OK))
            };

            // "this" refers to a Page object
            this.ToolbarItems.Add(logoutItem);
            */
        }

        protected async override void OnAppearing()
        {
            await homePageViewModel.GetTranslationCountAsync();
            homePageViewModel.UpdateUploadTime();

            base.OnAppearing();
        }
    }
}