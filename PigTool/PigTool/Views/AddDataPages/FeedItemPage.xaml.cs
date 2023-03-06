using PigTool.Helpers;
using PigTool.ViewModels.DataViewModels;
using Shared;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PigTool.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FeedItemPage : ContentPage
    {
        private FeedItemViewModel _viewModel;
        private bool IsRendered = false;

        public FeedItemPage()
        {
            BindingContext = _viewModel = new FeedItemViewModel();
            InitializeComponent();
        }

        public FeedItemPage(FeedItem FI)
        {
            BindingContext = _viewModel = new FeedItemViewModel();
            _viewModel.populatewithData(FI);
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
            var stack = FormattedElementsHelper.TableRowGrid();
            FormattedElementsHelper.AddGridValue(
                stack,
                FormattedElementsHelper.FormDataLabel(nameof(_viewModel.DateTranslation)),
                GridPostion.TwoLeft);
            FormattedElementsHelper.AddGridValue(
                stack,
                FormattedElementsHelper.FormDatePicker(nameof(_viewModel.Date), nameof(_viewModel.IsEditMode)),
                GridPostion.TwoRight);
            DateCell.View = stack;
            FullTableSection.Add(DateCell);


            // Duration
            var DurationCell = new ViewCell();
            var DurationVerticalStack = FormattedElementsHelper.TableRowStack(stackOrientation: StackOrientation.Vertical);

            var DurationLabel = FormattedElementsHelper.DataLabel(nameof(_viewModel.FeedDurationTranslation));
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



            //Feed type
            var FeedTypeCell = new ViewCell();
            var FeedVerticalStack = FormattedElementsHelper.TableRowStack(stackOrientation: StackOrientation.Vertical);
            FeedVerticalStack.Padding = 0;
            var FeedTypeGrid = FormattedElementsHelper.TableRowGrid();
            FormattedElementsHelper.AddGridValue(
                FeedTypeGrid,
                FormattedElementsHelper.FormDataLabel(nameof(_viewModel.FeedTypeTranslation)),
                GridPostion.TwoLeft);
            FormattedElementsHelper.AddGridValue(
                FeedTypeGrid,
                FormattedElementsHelper.FormPickerEntry(
                nameof(_viewModel.FeedTypeListOfOptions),
                nameof(PickerToolHelper.TranslatedValue),
                nameof(_viewModel.SelectedFeedType),
                nameof(_viewModel.IsEditMode),
                _viewModel.SelectedFeedType,
                _viewModel.PickerFeedTypeTranslation
                ),
                GridPostion.TwoRight);
            var OtherFeedType = FormattedElementsHelper.TableRowGrid(nameof(_viewModel.DisplayOtherFeedType), true);
            FormattedElementsHelper.AddGridValue(
                OtherFeedType,
                FormattedElementsHelper.FormDataLabel(nameof(_viewModel.OtherFeedTypeTranslation)),
                GridPostion.TwoLeft);
            FormattedElementsHelper.AddGridValue(
                OtherFeedType,
                FormattedElementsHelper.FormTextEntry(
                    nameof(_viewModel.OtherFeedType),
                    nameof(_viewModel.IsEditMode)),
                GridPostion.TwoRight);
            FeedVerticalStack.Children.Add(FeedTypeGrid);
            FeedVerticalStack.Children.Add(OtherFeedType);
            FeedTypeCell.View = FeedVerticalStack;
            FullTableSection.Add(FeedTypeCell);


            //Amount Purchased

            var AmountPurchasedCell = new ViewCell();

            var AmountPurchasedVerticalStack = FormattedElementsHelper.TableRowStack(stackOrientation: StackOrientation.Vertical);
            AmountPurchasedVerticalStack.Padding = 0;

            var AmountPurchasedUnitTypeStack = FormattedElementsHelper.TableRowGrid(fields: GridFields.Three);
            FormattedElementsHelper.AddGridValue(
                AmountPurchasedUnitTypeStack,
                FormattedElementsHelper.FormDataLabel(nameof(_viewModel.AmountPurchasedTranslation)),
                GridPostion.ThreeLeft);
            FormattedElementsHelper.AddGridValue(
                AmountPurchasedUnitTypeStack,
                FormattedElementsHelper.FormNumericEntry(nameof(_viewModel.AmountPurchased), nameof(_viewModel.IsEditMode), null),
                GridPostion.ThreeCenter);
            FormattedElementsHelper.AddGridValue(
                AmountPurchasedUnitTypeStack,
                FormattedElementsHelper.FormPickerEntry(
                nameof(_viewModel.AmountPurchasedUnitListOfOptions),
                nameof(PickerToolHelper.TranslatedValue),
                nameof(_viewModel.SelectedAmountPurchasedUnit),
                nameof(_viewModel.IsEditMode),
                _viewModel.SelectedAmountPurchasedUnit,
                _viewModel.PickerUnitTranslation
                ),
                GridPostion.ThreeRight);

            var OtherAmountPurchasedUnitType = FormattedElementsHelper.TableRowGrid(nameof(_viewModel.DisplayOtherAmountPurchasedUnit), true);
            FormattedElementsHelper.AddGridValue(
                OtherAmountPurchasedUnitType,
                FormattedElementsHelper.FormDataLabel(nameof(_viewModel.AmountPurchasedTranslation)),
                GridPostion.TwoLeft);
            FormattedElementsHelper.AddGridValue(
                OtherAmountPurchasedUnitType,
                FormattedElementsHelper.FormTextEntry(nameof(_viewModel.OtherAmountPurchasedUnit), nameof(_viewModel.IsEditMode)),
                GridPostion.TwoRight);

            AmountPurchasedVerticalStack.Children.Add(AmountPurchasedUnitTypeStack);
            AmountPurchasedVerticalStack.Children.Add(OtherAmountPurchasedUnitType);
            AmountPurchasedCell.View = AmountPurchasedVerticalStack;
            FullTableSection.Add(AmountPurchasedCell);

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

            //Purchased From
            var PurchasedFromCell = new ViewCell();
            var PurchasedFromVerticalStack = FormattedElementsHelper.TableRowStack(stackOrientation: StackOrientation.Vertical);
            PurchasedFromVerticalStack.Padding = 0;
            var PurchasedFromTypeGrid = FormattedElementsHelper.TableRowGrid();
            FormattedElementsHelper.AddGridValue(
                PurchasedFromTypeGrid,
                FormattedElementsHelper.FormDataLabel(nameof(_viewModel.PurchasedFromTranslation)),
                GridPostion.TwoLeft);
            FormattedElementsHelper.AddGridValue(
               PurchasedFromTypeGrid,
              FormattedElementsHelper.FormPickerEntry(
                nameof(_viewModel.PurchasedFromListOfOptions),
                nameof(PickerToolHelper.TranslatedValue),
                nameof(_viewModel.SelectedPurchasedFrom),
                nameof(_viewModel.IsEditMode),
                _viewModel.SelectedPurchasedFrom,
                _viewModel.PickerPurchasedFromTranslation
                ),
               GridPostion.TwoRight);

            var OtherPurchasedFrom = FormattedElementsHelper.TableRowGrid(nameof(_viewModel.DisplayOtherPurchasedFrom), true);
            FormattedElementsHelper.AddGridValue(
                OtherPurchasedFrom,
                FormattedElementsHelper.FormDataLabel(nameof(_viewModel.OtherPurchasedFromTranslation)),
                GridPostion.TwoLeft);
            FormattedElementsHelper.AddGridValue(
                OtherPurchasedFrom,
                FormattedElementsHelper.FormTextEntry(nameof(_viewModel.OtherPurchasedFrom), nameof(_viewModel.IsEditMode)),
                GridPostion.TwoRight);
            PurchasedFromVerticalStack.Children.Add(PurchasedFromTypeGrid);
            PurchasedFromVerticalStack.Children.Add(OtherPurchasedFrom);
            PurchasedFromCell.View = PurchasedFromVerticalStack;
            FullTableSection.Add(PurchasedFromCell);


            //Other costs
            var OtherCostCell = new ViewCell();
            var OtherCostsStack = FormattedElementsHelper.TableRowStack();
            OtherCostsStack.Children.Add(FormattedElementsHelper.FormDataLabel(nameof(_viewModel.OtherCostsTranslation)));
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
                FormattedElementsHelper.FormEditorEntry(nameof(_viewModel.Comment), nameof(_viewModel.IsEditMode), heightRequest: 100),
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


            FeedItemTableView.Root.Add(FullTableSection);
        }
    }
}