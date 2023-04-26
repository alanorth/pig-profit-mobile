using PigTool.Helpers;
using PigTool.ViewModels.DataViewModels;
using Shared;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PigTool.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LabourCostPage : ContentPage
    {

        private LabourCostViewModel _viewModel;
        private bool IsRendered = false;

        public LabourCostPage()
        {
            BindingContext = _viewModel = new LabourCostViewModel();
            InitializeComponent();
        }

        public LabourCostPage(LabourCostItem LCI)
        {
            BindingContext = _viewModel = new LabourCostViewModel();
            _viewModel.populatewithData(LCI);
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
            var DurationLabel = FormattedElementsHelper.DataLabel(nameof(_viewModel.LabourDurationTranslation));
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
            DurationFinishStack.Children.Add(FormattedElementsHelper.FormDatePicker(
                nameof(_viewModel.DurationFinish), 
                nameof(_viewModel.IsEditMode), 
                nameof(_viewModel.DurationStart)));
            DurationFinishCell.View = DurationFinishStack;

            DurationVerticalStack.Children.Add(DurationStartStack);
            DurationVerticalStack.Children.Add(DurationFinishStack);
            DurationCell.View = DurationVerticalStack;
            FullTableSection.Add(DurationCell);


            //Labour Type
            var LabourCell = new ViewCell();
            var labourVerticalStack = FormattedElementsHelper.TableRowStack(stackOrientation: StackOrientation.Vertical);
            labourVerticalStack.Padding = 0;
            var labourTypeStack = FormattedElementsHelper.TableRowGrid();
            FormattedElementsHelper.AddGridValue(
                labourTypeStack,
                FormattedElementsHelper.FormDataLabel(nameof(_viewModel.LabourTypeTranslation)),
                GridPostion.TwoLeft);
            FormattedElementsHelper.AddGridValue(
                labourTypeStack,
                FormattedElementsHelper.FormPickerEntry(
                nameof(_viewModel.LabourTypeOptions),
                nameof(PickerToolHelper.TranslatedValue),
                nameof(_viewModel.SelectedLabourType),
                nameof(_viewModel.IsEditMode),
                _viewModel.SelectedLabourType,
                _viewModel.PickerLabourTypeTranslation
                ),
                GridPostion.TwoRight);
            var OtherLabourType = FormattedElementsHelper.TableRowGrid(nameof(_viewModel.DisplayOtherLabourType), true);
            FormattedElementsHelper.AddGridValue(
                OtherLabourType,
                FormattedElementsHelper.FormDataLabel(nameof(_viewModel.OtherLaboutTypeTranslation)),
                GridPostion.TwoLeft);
            FormattedElementsHelper.AddGridValue(
                OtherLabourType,
                FormattedElementsHelper.FormTextEntry(nameof(_viewModel.OtherLaboutType), nameof(_viewModel.IsEditMode)),
                GridPostion.TwoRight);
            labourVerticalStack.Children.Add(labourTypeStack);
            labourVerticalStack.Children.Add(OtherLabourType);
            LabourCell.View = labourVerticalStack;
            FullTableSection.Add(LabourCell);


            //Amount Paid
            var AmountPaidCell = new ViewCell();
            var AmountPaidStack = FormattedElementsHelper.TableRowStack();
            AmountPaidStack.Children.Add(FormattedElementsHelper.FormDataLabel(nameof(_viewModel.AmountPaidTranslation)));
            AmountPaidStack.Children.Add(FormattedElementsHelper.FormNumericEntry(nameof(_viewModel.AmountPaid), nameof(_viewModel.IsEditMode), null));
            AmountPaidCell.View = AmountPaidStack;
            FullTableSection.Add(AmountPaidCell);

            //Any Other Cost
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

            LabourTableView.Root.Add(FullTableSection);

        }


    }
}