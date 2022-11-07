using PigTool.Helpers;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using PigTool.ViewModels.DataViewModels;
using System.Windows.Input;

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

        public class LanguageDisplay {
            public string text;
            public UserLangSettings lang;
        }

        private void PopulateTheTable()
        {
            /*
            List<string> langs = new List<string>() { 
                "English", 
                "lang2", 
                "lang3", 
                "lang4", 
                "lang5",

            };*/

            List<LanguageDisplay> langs = new List<LanguageDisplay>() {
                new LanguageDisplay(){ text = "English", lang = UserLangSettings.Eng },
                new LanguageDisplay(){ text = "Lang1", lang = UserLangSettings.Lang1 },
                new LanguageDisplay(){ text = "Lang2", lang = UserLangSettings.Lang2 },
                new LanguageDisplay(){ text = "Lang3", lang = UserLangSettings.Eng },
                new LanguageDisplay(){ text = "Lang4", lang = UserLangSettings.Eng },
            };

            ViewCell buttonCell = new ViewCell();
            StackLayout buttonStack = new StackLayout();
            Button button = new Button();

            foreach (var lan in langs)
            {
                buttonStack = new StackLayout() { VerticalOptions = LayoutOptions.CenterAndExpand};
                button = new Button() { StyleClass= new List<string> { "LangButton" } };
                button.Text = lan.text;
                button.Clicked += async (sender, args) => await Navigation.PushAsync(new CountrySelectPage(lan.lang));
                buttonStack.Children.Add(button);
                LanguageSelectTableView.Children.Add(buttonStack);
            }
        }
    }
}