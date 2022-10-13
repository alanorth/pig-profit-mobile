using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PigTool.Helpers;
using Shared;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using PigTool.ViewModels.DataViewModels;

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


            //Labour Type
            var LabourCell = new ViewCell();
            var labourVerticalStack = FormattedElementsHelper.TableRowStack(stackOrientation: StackOrientation.Vertical);
            labourVerticalStack.Padding = 0;
            var labourTypeStack = FormattedElementsHelper.TableRowStack();
            labourTypeStack.Children.Add(FormattedElementsHelper.FormDataLabel(nameof(_viewModel.LabourTypeTranslation)));
            labourTypeStack.Children.Add(FormattedElementsHelper.FormPickerEntry(
                nameof(_viewModel.LabourTypeOptions), 
                nameof(PickerToolHelper.TranslatedValue), 
                nameof(_viewModel.SelectedLabourType),
                nameof(_viewModel.IsEditMode),
                _viewModel.SelectedLabourType,
                _viewModel.PickerLabourTypeTranslation
                ));
            var OtherLabourType = FormattedElementsHelper.TableRowStack(nameof(_viewModel.DisplayOtherLabourType), true);
            OtherLabourType.Children.Add(FormattedElementsHelper.FormDataLabel(nameof(_viewModel.OtherLaboutTypeTranslation)));
            OtherLabourType.Children.Add(FormattedElementsHelper.FormTextEntry(nameof(_viewModel.OtherLaboutType), nameof(_viewModel.IsEditMode)));
            labourVerticalStack.Children.Add(labourTypeStack);
            labourVerticalStack.Children.Add(OtherLabourType);
            LabourCell.View = labourVerticalStack;
            FullTableSection.Add(LabourCell);


            //Amount Paid
            var AmountPaidCell = new ViewCell();
            var AmountPaidStack = FormattedElementsHelper.TableRowStack();
            AmountPaidStack.Children.Add(FormattedElementsHelper.FormDataLabel(nameof(_viewModel.AmountPaidTranslation)));
            AmountPaidStack.Children.Add(FormattedElementsHelper.FormNumericEntry(nameof(_viewModel.AmountPaid), nameof(_viewModel.IsEditMode),null));
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
            var CommentStack = FormattedElementsHelper.TableRowStack();
            CommentStack.Children.Add(FormattedElementsHelper.FormDataLabel(nameof(_viewModel.CommentTranslation)));
            CommentStack.Children.Add(FormattedElementsHelper.FormEditorEntry(nameof(_viewModel.Comment), nameof(_viewModel.IsEditMode)));
            commentCell.View = CommentStack;
            FullTableSection.Add(commentCell);

            //Button Commands
            var buttonCell = new ViewCell();
            var buttonStack = FormattedElementsHelper.ButtonCommandStack(
                ResetCommandBinding: nameof(_viewModel.ResetButtonClicked),
                EditCommandBinding: nameof(_viewModel.EditButtonClicked),
                DeleteCommandBinding: nameof(_viewModel.DeleteButtonClicked),
                SaveCommandBinding: nameof(_viewModel.SaveButtonClicked),
                EditModeBinding : nameof(_viewModel.IsEditMode),
                ExistingModeBinding : nameof(_viewModel.EditExistingMode),
                ResetText : _viewModel.ResetTranslation,
                SaveText : _viewModel.SaveTranslation,
                EditText : _viewModel.EditTranslation,
                DeleteText : _viewModel.DeleteTranslation
                );
            buttonCell.View = buttonStack;
            FullTableSection.Add(buttonCell);

            LabourTableView.Root.Add(FullTableSection); 

        }


    }
}