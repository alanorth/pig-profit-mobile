using PigTool.Helpers;
using PigTool.ViewModels.DataViewModels;
using Shared;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PigTool.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WaterCostPage : ContentPage
    {
        private WaterCostViewModel _viewModel;
        private bool IsRendered = false;

        public WaterCostPage()
        {
            BindingContext = _viewModel = new WaterCostViewModel();
            InitializeComponent();
        }

        public WaterCostPage(WaterCostItem WCI)
        {
            BindingContext = _viewModel = new WaterCostViewModel();
            _viewModel.populatewithData(WCI);
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

            // Duration
            var DurationCell = new ViewCell();
            var DurationVerticalStack = FormattedElementsHelper.TableRowStack(stackOrientation: StackOrientation.Vertical);

            var DurationLabel = FormattedElementsHelper.DataLabel(nameof(_viewModel.WaterDurationTranslation));
            DurationVerticalStack.Children.Add(DurationLabel);

            //DurationStart
            var DurationStartCell = new ViewCell();
            var DurationStartStack = FormattedElementsHelper.TableRowStack();
            DurationStartStack.Children.Add(FormattedElementsHelper.FormDataLabel(nameof(_viewModel.StartTranslation)));
            DurationStartStack.Children.Add(FormattedElementsHelper.FormDatePicker(nameof(_viewModel.DurationStart), nameof(_viewModel.IsEditMode)));
            DurationStartCell.View = DurationStartStack;

            //DurationFinish
            var DurationFinishCell = new ViewCell();
            var DurationFinishStack = FormattedElementsHelper.TableRowStack();
            DurationFinishStack.Children.Add(FormattedElementsHelper.FormDataLabel(nameof(_viewModel.FinishTranslation)));
            DurationFinishStack.Children.Add(FormattedElementsHelper.FormDatePicker(nameof(_viewModel.DurationFinish), nameof(_viewModel.IsEditMode)));
            DurationFinishCell.View = DurationFinishStack;

            DurationVerticalStack.Children.Add(DurationStartStack);
            DurationVerticalStack.Children.Add(DurationFinishStack);
            DurationCell.View = DurationVerticalStack;
            FullTableSection.Add(DurationCell);

            //Water Purchased

            var WaterPurchasedUnitCell = new ViewCell();

            var UnitVerticalStack = FormattedElementsHelper.TableRowStack(stackOrientation: StackOrientation.Vertical);
            UnitVerticalStack.Padding = 0;

            var waterPurchasedUnitTypeStack = FormattedElementsHelper.TableRowGrid(fields: GridFields.Three);
            FormattedElementsHelper.AddGridValue(
                waterPurchasedUnitTypeStack,
                FormattedElementsHelper.FormDataLabel(nameof(_viewModel.WaterPurchasedTranslation)),
                GridPostion.ThreeLeft);
            FormattedElementsHelper.AddGridValue(
                waterPurchasedUnitTypeStack,
                FormattedElementsHelper.FormNumericEntry(nameof(_viewModel.WaterPurchased), nameof(_viewModel.IsEditMode), null),
                GridPostion.ThreeCenter);
            FormattedElementsHelper.AddGridValue(
                waterPurchasedUnitTypeStack,
                FormattedElementsHelper.FormPickerEntry(
                nameof(_viewModel.WaterPurchasedUnitListOfOptions),
                nameof(PickerToolHelper.TranslatedValue),
                nameof(_viewModel.SelectedWaterPurchasedUnit),
                nameof(_viewModel.IsEditMode),
                _viewModel.SelectedWaterPurchasedUnit,
                _viewModel.PickerUnitTranslation
                ),
                GridPostion.ThreeRight);
            var OtherWaterUnitType = FormattedElementsHelper.TableRowGrid(nameof(_viewModel.DisplayOtherWaterUnit), true);
            FormattedElementsHelper.AddGridValue(
                OtherWaterUnitType,
                FormattedElementsHelper.FormDataLabel(nameof(_viewModel.OtherWaterPurchasedTranslation)),
                GridPostion.TwoLeft);
            FormattedElementsHelper.AddGridValue(
                OtherWaterUnitType,
                FormattedElementsHelper.FormTextEntry(nameof(_viewModel.OtherWaterPurchasedUnit), nameof(_viewModel.IsEditMode)),
                GridPostion.TwoRight);
            UnitVerticalStack.Children.Add(waterPurchasedUnitTypeStack);
            UnitVerticalStack.Children.Add(OtherWaterUnitType);
            WaterPurchasedUnitCell.View = UnitVerticalStack;
            FullTableSection.Add(WaterPurchasedUnitCell);

            //Total Cost
            var TotalCostCell = new ViewCell();
            var TotalCostStack = FormattedElementsHelper.TableRowStack();
            TotalCostStack.Children.Add(FormattedElementsHelper.FormDataLabel(nameof(_viewModel.TotalCostTranslation)));
            TotalCostStack.Children.Add(FormattedElementsHelper.FormNumericEntry(nameof(_viewModel.TotalCosts), nameof(_viewModel.IsEditMode), null));
            TotalCostCell.View = TotalCostStack;
            FullTableSection.Add(TotalCostCell);

            //Water Purchased From
            var WaterPurchasedFromCell = new ViewCell();
            var FromVerticalStack = FormattedElementsHelper.TableRowStack(stackOrientation: StackOrientation.Vertical);
            FromVerticalStack.Padding = 0;
            var waterPurchasedFromTypeStack = FormattedElementsHelper.TableRowGrid();
            FormattedElementsHelper.AddGridValue(
                waterPurchasedFromTypeStack,
                FormattedElementsHelper.FormDataLabel(nameof(_viewModel.PurchasedWaterFromTranslation)),
                GridPostion.TwoLeft);
            FormattedElementsHelper.AddGridValue(
                waterPurchasedFromTypeStack,
                FormattedElementsHelper.FormPickerEntry(
                nameof(_viewModel.PurchasedWaterFromListOfOptions),
                nameof(PickerToolHelper.TranslatedValue),
                nameof(_viewModel.SelectedPurchasedWaterFrom),
                nameof(_viewModel.IsEditMode),
                _viewModel.SelectedPurchasedWaterFrom,
                _viewModel.PickerPurchasedFromTranslation
                ),
                GridPostion.TwoRight);
            var OtherWaterFromType = FormattedElementsHelper.TableRowGrid(nameof(_viewModel.DisplayOtherPurchasedFrom), true);
            FormattedElementsHelper.AddGridValue(
                OtherWaterFromType,
                FormattedElementsHelper.FormDataLabel(nameof(_viewModel.OtherPurchasedWaterFromTranslation)),
                GridPostion.TwoLeft);
            FormattedElementsHelper.AddGridValue(
                OtherWaterFromType,
                FormattedElementsHelper.FormTextEntry(nameof(_viewModel.OtherPurchasedWaterFrom), nameof(_viewModel.IsEditMode)),
                GridPostion.TwoRight);
            FromVerticalStack.Children.Add(waterPurchasedFromTypeStack);
            FromVerticalStack.Children.Add(OtherWaterFromType);
            WaterPurchasedFromCell.View = FromVerticalStack;
            FullTableSection.Add(WaterPurchasedFromCell);

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


            WaterCostTableView.Root.Add(FullTableSection);
        }
    }
}