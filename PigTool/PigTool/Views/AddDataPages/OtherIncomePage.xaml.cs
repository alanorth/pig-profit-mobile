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
    public partial class OtherIncomePage : ContentPage
    {
        private OtherIncomeViewModel _viewModel;
        private bool IsRendered = false;

        public OtherIncomePage()
        {
            BindingContext = _viewModel = new OtherIncomeViewModel();
            InitializeComponent();
        }

        public OtherIncomePage(OtherIncomeItem OCI)
        {
            BindingContext = _viewModel = new OtherIncomeViewModel();
            _viewModel.populatewithData(OCI);
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
            var TotalIncomeCell = new ViewCell();
            var TotalIncomeStack = FormattedElementsHelper.TableRowStack();
            TotalIncomeStack.Children.Add(FormattedElementsHelper.FormDataLabel(nameof(_viewModel.TotalIncomeTranslation)));
            TotalIncomeStack.Children.Add(FormattedElementsHelper.FormNumericEntry(nameof(_viewModel.TotalIncome), nameof(_viewModel.IsEditMode), null));
            TotalIncomeCell.View = TotalIncomeStack;
            FullTableSection.Add(TotalIncomeCell);

            //Comment
            var whatForCell = new ViewCell();
            var WhatForStack = FormattedElementsHelper.TableRowStack();
            WhatForStack.Children.Add(FormattedElementsHelper.FormDataLabel(nameof(_viewModel.OtherWhatForTranslation)));
            WhatForStack.Children.Add(FormattedElementsHelper.FormEditorEntry(nameof(_viewModel.OtherWhatFor), nameof(_viewModel.IsEditMode), heightRequest: 100));
            whatForCell.View = WhatForStack;
            FullTableSection.Add(whatForCell);


            //Transport Cost
            var TransportCostCell = new ViewCell();
            var TransportCostsStack = FormattedElementsHelper.TableRowStack();
            TransportCostsStack.Children.Add(FormattedElementsHelper.FormDataLabel(nameof(_viewModel.TransportationCostTranslation)));
            TransportCostsStack.Children.Add(FormattedElementsHelper.FormNumericEntry(nameof(_viewModel.TransportationCosts), nameof(_viewModel.IsEditMode), null));
            TransportCostCell.View = TransportCostsStack;
            FullTableSection.Add(TransportCostCell);

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


            OtherIncomeTableView.Root.Add(FullTableSection);
        }
    }
}