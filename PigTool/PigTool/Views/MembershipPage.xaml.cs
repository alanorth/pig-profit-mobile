using PigTool.Helpers;
using Shared;
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
    public partial class MembershipPage : ContentPage
    {
        private MembershipViewModel _viewModel;
        private bool IsRendered = false;

        public MembershipPage()
        {
            BindingContext = _viewModel = new MembershipViewModel();
            InitializeComponent();
        }

        public MembershipPage(MembershipItem MI)
        {
            BindingContext = _viewModel = new MembershipViewModel();
            _viewModel.populatewithData(MI);
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

            //Total Cost
            var TotalCostCell = new ViewCell();
            var TotalCostStack = FormattedElementsHelper.TableRowStack();
            TotalCostStack.Children.Add(FormattedElementsHelper.FormDataLabel(nameof(_viewModel.TotalCostTranslation)));
            TotalCostStack.Children.Add(FormattedElementsHelper.FormNumericEntry(nameof(_viewModel.TotalCosts), nameof(_viewModel.IsEditMode), null));
            TotalCostCell.View = TotalCostStack;
            FullTableSection.Add(TotalCostCell);

            //Membership
            var MembershipCell = new ViewCell();
            var MembershipVerticalStack = FormattedElementsHelper.TableRowStack(stackOrientation: StackOrientation.Vertical);
            MembershipVerticalStack.Padding = 0;
            var MembershipTypeStack = FormattedElementsHelper.TableRowStack();
            MembershipTypeStack.Children.Add(FormattedElementsHelper.FormDataLabel(nameof(_viewModel.MembershipTypeTranslation)));
            MembershipTypeStack.Children.Add(FormattedElementsHelper.FormPickerEntry(
                nameof(_viewModel.MembershipTypeListOfOptions),
                nameof(PickerToolHelper.TranslatedValue),
                nameof(_viewModel.SelectedMembershipType),
                nameof(_viewModel.IsEditMode),
                _viewModel.SelectedMembershipType
                )
                );
            var OtherMembershipType = FormattedElementsHelper.TableRowStack(nameof(_viewModel.DisplayOtherMembershipType), true);
            OtherMembershipType.Children.Add(FormattedElementsHelper.FormDataLabel(nameof(_viewModel.OtherMembershipTypeTranslation)));
            OtherMembershipType.Children.Add(FormattedElementsHelper.FormTextEntry(nameof(_viewModel.OtherMembershipType), nameof(_viewModel.IsEditMode)));
            MembershipVerticalStack.Children.Add(MembershipTypeStack);
            MembershipVerticalStack.Children.Add(OtherMembershipType);
            MembershipCell.View = MembershipVerticalStack;
            FullTableSection.Add(MembershipCell);

            //Time Period

            var TimePeriodCell = new ViewCell();

            var UnitVerticalStack = FormattedElementsHelper.TableRowStack(stackOrientation: StackOrientation.Vertical);
            UnitVerticalStack.Padding = 0;

            var TimePeriodUnitTypeStack = FormattedElementsHelper.TableRowStack();
            TimePeriodUnitTypeStack.Children.Add(FormattedElementsHelper.FormDataLabel(nameof(_viewModel.TimePeriodTranslation)));

            var InputContainer = FormattedElementsHelper.TableRowStack();
            InputContainer.Padding = 0;
            InputContainer.Children.Add(FormattedElementsHelper.FormNumericEntry(nameof(_viewModel.TimePeriod), nameof(_viewModel.IsEditMode), null));
            InputContainer.Children.Add(FormattedElementsHelper.FormPickerEntry(
                nameof(_viewModel.TimePeriodUnitListOfOptions),
                nameof(PickerToolHelper.TranslatedValue),
                nameof(_viewModel.SelectedTimePeriodUnit),
                nameof(_viewModel.IsEditMode),
                _viewModel.SelectedTimePeriodUnit
                )
                );

            TimePeriodUnitTypeStack.Children.Add(InputContainer);
            
            UnitVerticalStack.Children.Add(TimePeriodUnitTypeStack);
            TimePeriodCell.View = UnitVerticalStack;
            FullTableSection.Add(TimePeriodCell);

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


            MembershipTableView.Root.Add(FullTableSection);
            
        }
    }
}