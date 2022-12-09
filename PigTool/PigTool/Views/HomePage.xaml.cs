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
        }

        protected async override void OnAppearing()
        {
            await homePageViewModel.GetTranslationCountAsync();

            base.OnAppearing();
        }
    }
}