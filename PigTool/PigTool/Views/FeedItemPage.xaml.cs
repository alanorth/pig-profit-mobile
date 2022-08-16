using PigTool.Models;
using PigTool.ViewModels;
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
    public partial class FeedItemPage : ContentPage
    {
        FeedItemViewModel _ViewModel;

        public FeedItemPage()
        {
            BindingContext = _ViewModel = new FeedItemViewModel();

            InitializeComponent();
        }

        public FeedItemPage(FeedItem FeedId)
        {
            BindingContext = _ViewModel = new FeedItemViewModel();

            _ViewModel.PopulateSelectedFeedItem(FeedId);

            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            await _ViewModel.PopulateListOfOptions();



            base.OnAppearing();
        }


    }
}