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
    public partial class CountrySelectPage : ContentPage
    {
        private CountrySelectViewModel _viewModel;
        private bool IsRendered = false;
        UserLangSettings lang;

        public CountrySelectPage(UserLangSettings lang)
        {
            InitializeComponent();
            BindingContext = _viewModel = new CountrySelectViewModel(lang);
            this.lang = lang;
        }

        protected async override void OnAppearing()
        {
            if (!IsRendered)
            {

                await _viewModel.PopulateDataDowns();

                PopulateTheTable();

                base.OnAppearing();

                IsRendered = true;

                _viewModel.ShowSuccess = (async (obj) =>
                {
                    await Shell.Current.GoToAsync("//CountrySelectSuccessful");
                });
            }
        }

        private void PopulateTheTable()
        {
            var ContinueBtn = new Button();
            ContinueBtn.IsEnabled = false;
            ContinueBtn.Clicked += async (sender, args) => await Navigation.PushAsync(new LegalDisclaimer(lang, _viewModel.SelectedCountry.TranslationRowKey));
            ContinueBtn.Text = "Continue";

            //Country
            var CountryVerticalStack = FormattedElementsHelper.TableRowStack(stackOrientation: StackOrientation.Vertical);
            CountryVerticalStack.Padding = 0;
            var CountryStack = FormattedElementsHelper.TableRowStack();
            CountryStack.Children.Add(FormattedElementsHelper.FormDataLabel(nameof(_viewModel.CountryTranslation)));

            Picker picker = new Picker()
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
            };

            picker.SetBinding(Picker.SelectedItemProperty, new Binding(nameof(_viewModel.SelectedCountry)));
            picker.SetBinding(Picker.ItemsSourceProperty, new Binding(nameof(_viewModel.CountryListOfOptions)));
            picker.SetBinding(Picker.TitleProperty, new Binding(nameof(_viewModel.PickerCountryTranslation)));
            picker.ItemDisplayBinding = new Binding(nameof(PickerToolHelper.TranslatedValue));

            picker.SelectedIndexChanged += (sender, e) =>
            {
                if (picker.SelectedItem == null)
                {
                    picker.SelectedIndex = -1;
                }

                ContinueBtn.IsEnabled = true;
            };

            CountryStack.Children.Add(picker);
            CountryVerticalStack.Children.Add(CountryStack);
            CountrySelectTableView.Children.Add(CountryVerticalStack);

            //Button Commands
            CountrySelectTableView.Children.Add(ContinueBtn);

            PageTitle.Text = _viewModel.WhereAreYouLocatedTranslation;

        }
    }
}