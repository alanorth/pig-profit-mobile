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

            var waterPurchasedUnitTypeStack = FormattedElementsHelper.TableRowStack();
            waterPurchasedUnitTypeStack.Children.Add(FormattedElementsHelper.FormDataLabel(nameof(_viewModel.WaterPurchasedTranslation)));

            var InputContainer = FormattedElementsHelper.TableRowStack();
            InputContainer.Padding = 0;
            InputContainer.Children.Add(FormattedElementsHelper.FormNumericEntry(nameof(_viewModel.WaterPurchased), nameof(_viewModel.IsEditMode), null));
            InputContainer.Children.Add(FormattedElementsHelper.FormPickerEntry(
                nameof(_viewModel.WaterPurchasedUnitListOfOptions),
                nameof(PickerToolHelper.TranslatedValue),
                nameof(_viewModel.SelectedWaterPurchasedUnit),
                nameof(_viewModel.IsEditMode),
                _viewModel.SelectedWaterPurchasedUnit,
                _viewModel.PickerUnitTranslation
                )
                );

            waterPurchasedUnitTypeStack.Children.Add(InputContainer);

            var OtherWaterUnitType = FormattedElementsHelper.TableRowStack(nameof(_viewModel.DisplayOtherWaterUnit), true);
            OtherWaterUnitType.Children.Add(FormattedElementsHelper.FormDataLabel(nameof(_viewModel.OtherWaterPurchasedTranslation)));
            OtherWaterUnitType.Children.Add(FormattedElementsHelper.FormTextEntry(nameof(_viewModel.OtherWaterPurchasedUnit), nameof(_viewModel.IsEditMode)));
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
            var waterPurchasedFromTypeStack = FormattedElementsHelper.TableRowStack();
            waterPurchasedFromTypeStack.Children.Add(FormattedElementsHelper.FormDataLabel(nameof(_viewModel.PurchasedWaterFromTranslation)));
            waterPurchasedFromTypeStack.Children.Add(FormattedElementsHelper.FormPickerEntry(
                nameof(_viewModel.PurchasedWaterFromListOfOptions),
                nameof(PickerToolHelper.TranslatedValue),
                nameof(_viewModel.SelectedPurchasedWaterFrom),
                nameof(_viewModel.IsEditMode),
                _viewModel.SelectedPurchasedWaterFrom,
                _viewModel.PickerPurchasedFromTranslation
                )
                );
            var OtherWaterFromType = FormattedElementsHelper.TableRowStack(nameof(_viewModel.DisplayOtherPurchasedFrom), true);
            OtherWaterFromType.Children.Add(FormattedElementsHelper.FormDataLabel(nameof(_viewModel.OtherPurchasedWaterFromTranslation)));
            OtherWaterFromType.Children.Add(FormattedElementsHelper.FormTextEntry(nameof(_viewModel.OtherPurchasedWaterFrom), nameof(_viewModel.IsEditMode)));
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


            WaterCostTableView.Root.Add(FullTableSection);
        }
    }
}