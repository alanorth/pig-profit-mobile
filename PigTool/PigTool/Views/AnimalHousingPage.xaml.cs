using PigTool.Helpers;
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
    public partial class AnimalHousingPage : ContentPage
    {
        private AnimalHousingViewModel _viewModel;

        public AnimalHousingPage()
        {

            BindingContext = _viewModel = new AnimalHousingViewModel();
            InitializeComponent();
        }

        public AnimalHousingPage(AnimalHouseItem AHI)
        {
            BindingContext = _viewModel = new AnimalHousingViewModel();
            _viewModel.populatewithData(AHI);
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            await _viewModel.PopulateDataDowns();

            PopulateTheTable();

            _viewModel.SetPickers();

            base.OnAppearing();
        }

        private void PopulateTheTable()
        {
            var FullTableSection = new TableSection();

            //Date
            var DateCell = new ViewCell();
            var stack = FormattedElementsHelper.TableRowStack();
            stack.Children.Add(FormattedElementsHelper.FormDataLabel(nameof(_viewModel.DateTranslation)));
            stack.Children.Add(FormattedElementsHelper.FormDatePicker(nameof(_viewModel.Date), nameof(_viewModel.IsEditMode)));
            DateCell.View = stack;
            FullTableSection.Add(DateCell);

            //Housing Expense
            var HousingCell = new ViewCell();
            var housingVerticalStack = FormattedElementsHelper.TableRowStack(stackOrientation: StackOrientation.Vertical);
            housingVerticalStack.Padding = 0;
            var housingTypeStack = FormattedElementsHelper.TableRowStack();
            housingTypeStack.Children.Add(FormattedElementsHelper.FormDataLabel(nameof(_viewModel.HousingExpenseTranslation)));
            housingTypeStack.Children.Add(FormattedElementsHelper.FormPickerEntry(
                nameof(_viewModel.HousingTypeListOfOptions),
                nameof(PickerToolHelper.TranslatedValue),
                nameof(_viewModel.SelectedHousingType),
                nameof(_viewModel.IsEditMode),
                _viewModel.SelectedHousingType
                )
                );
            var OtherHousingType = FormattedElementsHelper.TableRowStack(nameof(_viewModel.DisplayOtherHouseType), true);
            OtherHousingType.Children.Add(FormattedElementsHelper.FormDataLabel(nameof(_viewModel.OtherHousingExpenseTranslation)));
            OtherHousingType.Children.Add(FormattedElementsHelper.FormTextEntry(nameof(_viewModel.OtherHousingExpense), nameof(_viewModel.IsEditMode)));
            housingVerticalStack.Children.Add(housingTypeStack);
            housingVerticalStack.Children.Add(OtherHousingType);
            HousingCell.View = housingVerticalStack;
            FullTableSection.Add(HousingCell);


            //Total Cost
            var TotalCostCell = new ViewCell();
            var TotalCostStack = FormattedElementsHelper.TableRowStack();
            TotalCostStack.Children.Add(FormattedElementsHelper.FormDataLabel(nameof(_viewModel.TotalCostTranslation)));
            TotalCostStack.Children.Add(FormattedElementsHelper.FormNumericEntry(nameof(_viewModel.TotalCosts), nameof(_viewModel.IsEditMode), null));
            TotalCostCell.View = TotalCostStack;
            FullTableSection.Add(TotalCostCell);

            //Transport Cost
            var TransportCostCell = new ViewCell();
            var TransportCostsStack = FormattedElementsHelper.TableRowStack();
            TransportCostsStack.Children.Add(FormattedElementsHelper.FormDataLabel(nameof(_viewModel.TransportationCostTranslation)));
            TransportCostsStack.Children.Add(FormattedElementsHelper.FormNumericEntry(nameof(_viewModel.TransportationCost), nameof(_viewModel.IsEditMode), null));
            TransportCostCell.View = TransportCostsStack;
            FullTableSection.Add(TransportCostCell);

            //Any Other Cost
            var OtherCostCell = new ViewCell();
            var OtherCostsStack = FormattedElementsHelper.TableRowStack();
            OtherCostsStack.Children.Add(FormattedElementsHelper.FormDataLabel(nameof(_viewModel.OtherCostTranslation)));
            OtherCostsStack.Children.Add(FormattedElementsHelper.FormNumericEntry(nameof(_viewModel.OtherCosts), nameof(_viewModel.IsEditMode), null));
            OtherCostCell.View = OtherCostsStack;
            FullTableSection.Add(OtherCostCell);

            //Comment
            var commentCell = new ViewCell();
            var CommentStack = FormattedElementsHelper.TableRowStack();
            CommentStack.Children.Add(FormattedElementsHelper.FormDataLabel(nameof(_viewModel.CommentTranslation)));
            CommentStack.Children.Add(FormattedElementsHelper.FormEditorEntry(nameof(_viewModel.Comment), nameof(_viewModel.IsEditMode), heightRequest: 100));
            commentCell.View = CommentStack;
            FullTableSection.Add(commentCell);


            //Button Commands
            var buttonCell = new ViewCell();
            var buttonStack = FormattedElementsHelper.ButtonCommandStack(
                ResetCommandBinding: nameof(_viewModel.ResetButtonClicked),
                EditCommandBinding: nameof(_viewModel.EditButtonClicked),
                DeleteCommandBinding: nameof(_viewModel.DeleteButtonClicked),
                SaveCommandBinding: nameof(_viewModel.SaveButtonClicked),
                EditModeBinding: nameof(_viewModel.IsEditMode),
                ExistingModeBinding: nameof(_viewModel.EditExistingMode),
                ResetText: _viewModel.ResetTranslation,
                SaveText: _viewModel.SaveTranslation,
                EditText: _viewModel.EditTranslation,
                DeleteText: _viewModel.DeleteTranslation
                );
            buttonCell.View = buttonStack;
            FullTableSection.Add(buttonCell);


            HousingTableView.Root.Add(FullTableSection);
        }
    }
}