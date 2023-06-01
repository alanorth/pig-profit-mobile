using Rg.Plugins.Popup.Pages;
using Xamarin.Forms.Xaml;

namespace PigTool.Views.Popups
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoadingOverlay : PopupPage
    {
        public LoadingOverlay(string text)
        {
            InitializeComponent();
            CloseWhenBackgroundIsClicked = false;
            LoadingText.Text = text;
        }

        protected override bool OnBackButtonPressed()
        {
            base.OnBackButtonPressed();
            return true; // Disable back button
        }
    }
}