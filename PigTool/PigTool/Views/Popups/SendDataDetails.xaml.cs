using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PigTool.Views.Popups
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SendDataDetails : PopupPage
    {
        public SendDataDetails(Grid grid)
        {
            InitializeComponent();

            Label label = new Label()
            {
                Text = "Data ready to upload",
                FontSize = 20,

            };

            Button button = new Button()
            {
                Text = "OK",
                Command = new Command(async () => await PopupNavigation.Instance.PopAsync())
            };
            PopupLayout.Children.Add(label);
            PopupLayout.Children.Add(grid);
            PopupLayout.Children.Add(button);
            CloseWhenBackgroundIsClicked = true;
        }
    }
}