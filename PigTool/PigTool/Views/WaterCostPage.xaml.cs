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
    public partial class WaterCostPage : ContentPage
    {
        private WaterCostViewModel _viewModel;

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

            //Water Purchased
            var WaterPurchasedCell = new ViewCell();
            var WaterPurchasedStack = FormattedElementsHelper.TableRowStack();
            WaterPurchasedStack.Children.Add(FormattedElementsHelper.FormDataLabel(nameof(_viewModel.WaterPurchasedTranslation)));
            WaterPurchasedStack.Children.Add(FormattedElementsHelper.FormNumericEntry(nameof(_viewModel.WaterPurchased), nameof(_viewModel.IsEditMode), null));
            WaterPurchasedCell.View = WaterPurchasedStack;
            FullTableSection.Add(WaterPurchasedCell);

            //Water Purchased Unit
            var WaterPurchasedUnitCell = new ViewCell();
            var UnitVerticalStack = FormattedElementsHelper.TableRowStack(stackOrientation: StackOrientation.Vertical);
            UnitVerticalStack.Padding = 0;
            var waterPurchasedUnitTypeStack = FormattedElementsHelper.TableRowStack();
            waterPurchasedUnitTypeStack.Children.Add(FormattedElementsHelper.FormDataLabel(nameof(_viewModel.WaterPurchasedTranslation)));
            waterPurchasedUnitTypeStack.Children.Add(FormattedElementsHelper.FormPickerEntry(
                nameof(_viewModel.WaterPurchasedUnitListOfOptions),
                nameof(PickerToolHelper.TranslatedValue),
                nameof(_viewModel.SelectedWaterPurchasedUnit),
                nameof(_viewModel.IsEditMode),
                _viewModel.SelectedWaterPurchasedUnit
                )
                );
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
                _viewModel.SelectedPurchasedWaterFrom
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