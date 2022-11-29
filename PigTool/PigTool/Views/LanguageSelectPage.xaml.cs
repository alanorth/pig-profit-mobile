using PigTool.ViewModels.DataViewModels;
using Shared;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PigTool.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LanguageSelectPage : ContentPage
    {
        private LanguageSelectViewModel _viewModel;
        private bool IsRendered = false;

        public LanguageSelectPage()
        {
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            if (!IsRendered)
            {
                base.OnAppearing();
                PopulateTheTable();
                IsRendered = true;
            }
        }

        public class LanguageDisplay
        {
            public string text;
            public UserLangSettings lang;
        }

        private void PopulateTheTable()
        {
            List<LanguageDisplay> langs = new List<LanguageDisplay>() {
                new LanguageDisplay(){ text = "English", lang = UserLangSettings.Eng },
                new LanguageDisplay(){ text = "Swahili", lang = UserLangSettings.Lang1 },
                new LanguageDisplay(){ text = "Vietnamese", lang = UserLangSettings.Lang2 },
                new LanguageDisplay(){ text = "Kinyarwanda", lang = UserLangSettings.Eng },
            };

            ViewCell buttonCell = new ViewCell();
            StackLayout buttonStack = new StackLayout();
            Button button = new Button();

            foreach (var lan in langs)
            {
                buttonStack = new StackLayout() { VerticalOptions = LayoutOptions.CenterAndExpand };
                button = new Button() { StyleClass = new List<string> { "LangButton" } };
                button.Text = lan.text;
                button.Clicked += async (sender, args) => await Navigation.PushAsync(new CountrySelectPage(lan.lang));
                buttonStack.Children.Add(button);
                LanguageSelectTableView.Children.Add(buttonStack);
            }
        }
    }
}