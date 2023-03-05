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

namespace PigTool.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AnimalHousingPage : ContentPage
    {
        private AnimalHousingViewModel _viewModel;
        private bool IsRendered = false;

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
            if (!IsRendered)
            {
                await _viewModel.PopulateDataDowns();

                PopulateTheTable();

                _viewModel.SetPickers();

                base.OnAppearing();

                IsRendered = true;
            }
        }

        private void PopulateTheTable()
        {
            var FullTableSection = new TableSection();


            if (_viewModel.EditExistingMode)
            {
                var buttonCellTop = new ViewCell();
                var buttonStackTop = FormattedElementsHelper.ButtonCommandStack(
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
                buttonCellTop.View = buttonStackTop;
                FullTableSection.Add(buttonCellTop);
            }

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
            var housingTypeStack = FormattedElementsHelper.TableRowGrid();
            FormattedElementsHelper.AddGridValue(
                housingTypeStack,
                FormattedElementsHelper.FormDataLabel(nameof(_viewModel.HousingExpenseTranslation)),
                GridPostion.TwoLeft);
            FormattedElementsHelper.AddGridValue(
                housingTypeStack,
                FormattedElementsHelper.FormPickerEntry(
                nameof(_viewModel.HousingTypeListOfOptions),
                nameof(PickerToolHelper.TranslatedValue),
                nameof(_viewModel.SelectedHousingType),
                nameof(_viewModel.IsEditMode),
                _viewModel.SelectedHousingType,
                _viewModel.PickerHousingExpenseTranslation
                ),
                GridPostion.TwoRight);
            var OtherHousingType = FormattedElementsHelper.TableRowGrid(nameof(_viewModel.DisplayOtherHouseType), true);
            FormattedElementsHelper.AddGridValue(
                OtherHousingType,
                FormattedElementsHelper.FormDataLabel(nameof(_viewModel.OtherHousingExpenseTranslation)),
                GridPostion.TwoLeft);
            FormattedElementsHelper.AddGridValue(
                OtherHousingType,
                FormattedElementsHelper.FormTextEntry(nameof(_viewModel.OtherHousingExpense), nameof(_viewModel.IsEditMode)),
                GridPostion.TwoRight);
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

            // Housing Lifespan
            var HousingLifespanCell = new ViewCell();
            var HousingLifespanStack = FormattedElementsHelper.TableRowStack();
            HousingLifespanStack.Children.Add(FormattedElementsHelper.FormDataLabel(nameof(_viewModel.YearsExpectedTranslation)));
            HousingLifespanStack.Children.Add(FormattedElementsHelper.FormSliderInput(nameof(_viewModel.YearsExpected), nameof(_viewModel.IsEditMode), null, true, upperValue: 10));
            HousingLifespanCell.View = HousingLifespanStack;
            FullTableSection.Add(HousingLifespanCell);

            //Comment
            var commentCell = new ViewCell();
            var CommentStack = FormattedElementsHelper.TableRowGrid();
            FormattedElementsHelper.AddGridValue(
                CommentStack,
                FormattedElementsHelper.FormDataLabel(nameof(_viewModel.CommentTranslation)),
                GridPostion.TwoLeft);
            FormattedElementsHelper.AddGridValue(
                CommentStack,
                FormattedElementsHelper.FormEditorEntry(nameof(_viewModel.Comment), nameof(_viewModel.IsEditMode)),
                GridPostion.TwoRight);
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