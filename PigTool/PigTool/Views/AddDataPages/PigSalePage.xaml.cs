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
    public partial class PigSalePage : ContentPage
    {
        private PigSaleViewModel _viewModel;
        private bool IsRendered = false;

        public PigSalePage()
        {
            BindingContext = _viewModel = new PigSaleViewModel();
            InitializeComponent();
        }

        public PigSalePage(PigSaleItem WCI)
        {
            BindingContext = _viewModel = new PigSaleViewModel();
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


            // Pig Type
            var PigTypeCell = new ViewCell();
            var PigTypeVerticalStack = FormattedElementsHelper.TableRowStack(stackOrientation: StackOrientation.Vertical);
            PigTypeVerticalStack.Padding = 0;
            var PigTypeTypeStack = FormattedElementsHelper.TableRowStack();
            PigTypeTypeStack.Children.Add(FormattedElementsHelper.FormDataLabel(nameof(_viewModel.PigTypeTranslation)));
            PigTypeTypeStack.Children.Add(FormattedElementsHelper.FormPickerEntry(
                nameof(_viewModel.PigTypeListOfOptions),
                nameof(PickerToolHelper.TranslatedValue),
                nameof(_viewModel.SelectedPigType),
                nameof(_viewModel.IsEditMode),
                _viewModel.SelectedPigType,
                _viewModel.PickerPigTypeTranslation
                )
                );
            var OtherPigType = FormattedElementsHelper.TableRowStack(nameof(_viewModel.DisplayOtherPigType), true);
            OtherPigType.Children.Add(FormattedElementsHelper.FormDataLabel(nameof(_viewModel.OtherPigTypeTranslation)));
            OtherPigType.Children.Add(FormattedElementsHelper.FormTextEntry(nameof(_viewModel.OtherPigType), nameof(_viewModel.IsEditMode)));
            PigTypeVerticalStack.Children.Add(PigTypeTypeStack);
            PigTypeVerticalStack.Children.Add(OtherPigType);
            PigTypeCell.View = PigTypeVerticalStack;
            FullTableSection.Add(PigTypeCell);

            //NumberSold
            var NumberSoldCell = new ViewCell();
            var NumberSoldStack = FormattedElementsHelper.TableRowStack();
            NumberSoldStack.Children.Add(FormattedElementsHelper.FormDataLabel(nameof(_viewModel.NumberSoldTranslation)));
            NumberSoldStack.Children.Add(FormattedElementsHelper.FormNumericEntry(nameof(_viewModel.NumberSold), nameof(_viewModel.IsEditMode), null));
            NumberSoldCell.View = NumberSoldStack;
            FullTableSection.Add(NumberSoldCell);

            //SalePrice
            var SalePriceCell = new ViewCell();
            var SalePriceStack = FormattedElementsHelper.TableRowStack();
            SalePriceStack.Children.Add(FormattedElementsHelper.FormDataLabel(nameof(_viewModel.SalePriceTranslation)));
            SalePriceStack.Children.Add(FormattedElementsHelper.FormNumericEntry(nameof(_viewModel.SalePrice), nameof(_viewModel.IsEditMode), null));
            SalePriceCell.View = SalePriceStack;
            FullTableSection.Add(SalePriceCell);

            // SoldTo
            var SoldToCell = new ViewCell();
            var SoldToVerticalStack = FormattedElementsHelper.TableRowStack(stackOrientation: StackOrientation.Vertical);
            SoldToVerticalStack.Padding = 0;
            var SoldToTypeStack = FormattedElementsHelper.TableRowStack();
            SoldToTypeStack.Children.Add(FormattedElementsHelper.FormDataLabel(nameof(_viewModel.SoldToTranslation)));
            SoldToTypeStack.Children.Add(FormattedElementsHelper.FormPickerEntry(
                nameof(_viewModel.SoldToListOfOptions),
                nameof(PickerToolHelper.TranslatedValue),
                nameof(_viewModel.SelectedSoldTo),
                nameof(_viewModel.IsEditMode),
                _viewModel.SelectedSoldTo,
                _viewModel.PickerSoldToTranslation
                )
                );
            var OtherSoldTo = FormattedElementsHelper.TableRowStack(nameof(_viewModel.DisplayOtherSoldTo), true);
            OtherSoldTo.Children.Add(FormattedElementsHelper.FormDataLabel(nameof(_viewModel.OtherSoldToTranslation)));
            OtherSoldTo.Children.Add(FormattedElementsHelper.FormTextEntry(nameof(_viewModel.OtherSoldTo), nameof(_viewModel.IsEditMode)));
            SoldToVerticalStack.Children.Add(SoldToTypeStack);
            SoldToVerticalStack.Children.Add(OtherSoldTo);
            SoldToCell.View = SoldToVerticalStack;
            FullTableSection.Add(SoldToCell);

            //Transport Cost
            var BrokerageCell = new ViewCell();
            var BrokeragesStack = FormattedElementsHelper.TableRowStack();
            BrokeragesStack.Children.Add(FormattedElementsHelper.FormDataLabel(nameof(_viewModel.BrokerageTranslation)));
            BrokeragesStack.Children.Add(FormattedElementsHelper.FormNumericEntry(nameof(_viewModel.Brokerage), nameof(_viewModel.IsEditMode), null));
            BrokerageCell.View = BrokeragesStack;
            FullTableSection.Add(BrokerageCell);

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


            PigSaleTableView.Root.Add(FullTableSection);
        }
    }
}