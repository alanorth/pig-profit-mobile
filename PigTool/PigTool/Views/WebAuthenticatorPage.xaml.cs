using Samples.ViewModel;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PigTool.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WebAuthenticatorPage : ContentPage
    {
        WebAuthenticatorViewModel _viewModel;

        public WebAuthenticatorPage(UserLangSettings lang, string translationRowKey)
        {
            BindingContext = _viewModel = new WebAuthenticatorViewModel(Navigation, lang, translationRowKey);
            
            InitializeComponent();

            WebAuthTitle.Text = _viewModel.WebAuthTitleTranslation;
            WebAuthDesc.Text = _viewModel.WebAuthDescTranslation;
            btnGoogle.Text = _viewModel.GoogleTranslation;
            btnFacebook.Text = _viewModel.FacebookTranslation;
        }
    }
}