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
    public partial class LoanRepaymentPage : ContentPage
    {
        private LoanRepaymentViewModel _viewModel;
        private bool IsRendered = false;

        public LoanRepaymentPage()
        {
            BindingContext = _viewModel = new LoanRepaymentViewModel();
            InitializeComponent();
        }

        public LoanRepaymentPage(LoanRepaymentItem WCI)
        {
            BindingContext = _viewModel = new LoanRepaymentViewModel();
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

            //Total Amount Paid
            var TotalAmountRepaidCell = new ViewCell();
            var TotalAmountRepaidStack = FormattedElementsHelper.TableRowStack();
            TotalAmountRepaidStack.Children.Add(FormattedElementsHelper.FormDataLabel(nameof(_viewModel.TotalAmountRepaidTranslation)));
            TotalAmountRepaidStack.Children.Add(FormattedElementsHelper.FormNumericEntry(nameof(_viewModel.TotalAmountRepaid), nameof(_viewModel.IsEditMode), null));
            TotalAmountRepaidCell.View = TotalAmountRepaidStack;
            FullTableSection.Add(TotalAmountRepaidCell);

            //Water Purchased From
            var LoanProviderFromCell = new ViewCell();
            var LoanProviderVerticalStack = FormattedElementsHelper.TableRowStack(stackOrientation: StackOrientation.Vertical);
            LoanProviderVerticalStack.Padding = 0;
            var LoanProviderTypeStack = FormattedElementsHelper.TableRowGrid();
            FormattedElementsHelper.AddGridValue(
                LoanProviderTypeStack,
                FormattedElementsHelper.FormDataLabel(nameof(_viewModel.LoanProviderTranslation)),
                GridPostion.TwoLeft);
            FormattedElementsHelper.AddGridValue(
                LoanProviderTypeStack,
                FormattedElementsHelper.FormPickerEntry(
                nameof(_viewModel.LoanProviderListOfOptions),
                nameof(PickerToolHelper.TranslatedValue),
                nameof(_viewModel.SelectedLoanProvider),
                nameof(_viewModel.IsEditMode),
                _viewModel.SelectedLoanProvider,
                _viewModel.PickerProviderTranslation
                ),
                GridPostion.TwoRight);
            var OtherLoanProviderType = FormattedElementsHelper.TableRowGrid(nameof(_viewModel.DisplayOtherLoanProvider), true);
            FormattedElementsHelper.AddGridValue(
                OtherLoanProviderType,
                FormattedElementsHelper.FormDataLabel(nameof(_viewModel.OtherLoanProviderTranslation)),
                GridPostion.TwoLeft);
            FormattedElementsHelper.AddGridValue(
                OtherLoanProviderType,
                FormattedElementsHelper.FormTextEntry(nameof(_viewModel.OtherLoanProvider), nameof(_viewModel.IsEditMode)),
                GridPostion.TwoRight);
            LoanProviderVerticalStack.Children.Add(LoanProviderTypeStack);
            LoanProviderVerticalStack.Children.Add(OtherLoanProviderType);
            LoanProviderFromCell.View = LoanProviderVerticalStack;
            FullTableSection.Add(LoanProviderFromCell);

            //Any Transport Cost
            var TransportCostCell = new ViewCell();
            var TransportCostStack = FormattedElementsHelper.TableRowStack();
            TransportCostStack.Children.Add(FormattedElementsHelper.FormDataLabel(nameof(_viewModel.TransportCostTrans)));
            TransportCostStack.Children.Add(FormattedElementsHelper.FormNumericEntry(nameof(_viewModel.TransportCosts), nameof(_viewModel.IsEditMode), null));
            TransportCostCell.View = TransportCostStack;
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


            LoanRepaymentTableView.Root.Add(FullTableSection);
        }
    }
}