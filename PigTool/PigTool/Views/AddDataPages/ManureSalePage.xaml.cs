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
    public partial class ManureSalePage : ContentPage
    {
        private ManureSaleViewModel _viewModel;
        private bool IsRendered = false;

        public ManureSalePage()
        {
            BindingContext = _viewModel = new ManureSaleViewModel();
            InitializeComponent();
        }

        public ManureSalePage(ManureSaleItem WCI)
        {
            BindingContext = _viewModel = new ManureSaleViewModel();
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

            //Water Purchased

            var VolumeSoldUnitCell = new ViewCell();

            var UnitVerticalStack = FormattedElementsHelper.TableRowStack(stackOrientation: StackOrientation.Vertical);
            UnitVerticalStack.Padding = 0;

            var VolumeSoldUnitTypeStack = FormattedElementsHelper.TableRowStack();
            VolumeSoldUnitTypeStack.Children.Add(FormattedElementsHelper.FormDataLabel(nameof(_viewModel.VolumeSoldTranslation)));

            var InputContainer = FormattedElementsHelper.TableRowStack();
            InputContainer.Padding = 0;
            InputContainer.Children.Add(FormattedElementsHelper.FormNumericEntry(nameof(_viewModel.VolumeSold), nameof(_viewModel.IsEditMode), null));
            InputContainer.Children.Add(FormattedElementsHelper.FormPickerEntry(
                nameof(_viewModel.VolumeUnitTypeListOfOptions),
                nameof(PickerToolHelper.TranslatedValue),
                nameof(_viewModel.SelectedVolumeUnitType),
                nameof(_viewModel.IsEditMode),
                _viewModel.SelectedVolumeUnitType,
                _viewModel.PickerUnitTranslation
                )
                );

            VolumeSoldUnitTypeStack.Children.Add(InputContainer);

            UnitVerticalStack.Children.Add(VolumeSoldUnitTypeStack);
            VolumeSoldUnitCell.View = UnitVerticalStack;
            FullTableSection.Add(VolumeSoldUnitCell);


            //AmountRecieved
            var AmountRecievedCell = new ViewCell();
            var AmountRecievedStack = FormattedElementsHelper.TableRowStack();
            AmountRecievedStack.Children.Add(FormattedElementsHelper.FormDataLabel(nameof(_viewModel.AmountRecievedTranslation)));
            AmountRecievedStack.Children.Add(FormattedElementsHelper.FormNumericEntry(nameof(_viewModel.AmountRecieved), nameof(_viewModel.IsEditMode), null));
            AmountRecievedCell.View = AmountRecievedStack;
            FullTableSection.Add(AmountRecievedCell);

            // PaymentType
            var PaymentTypeCell = new ViewCell();
            var PaymentTypeVerticalStack = FormattedElementsHelper.TableRowStack(stackOrientation: StackOrientation.Vertical);

            var OtherPaymentLabel = FormattedElementsHelper.DataLabel(nameof(_viewModel.AnyOtherPaymentTranslation));
            PaymentTypeVerticalStack.Children.Add(OtherPaymentLabel);

            var PaymentTypeTypeStack = FormattedElementsHelper.TableRowStack();
            PaymentTypeTypeStack.Children.Add(FormattedElementsHelper.FormDataLabel(nameof(_viewModel.PaymentTypeTranslation)));
            PaymentTypeTypeStack.Children.Add(FormattedElementsHelper.FormPickerEntry(
                nameof(_viewModel.PaymentTypeListOfOptions),
                nameof(PickerToolHelper.TranslatedValue),
                nameof(_viewModel.SelectedPaymentType),
                nameof(_viewModel.IsEditMode),
                _viewModel.SelectedPaymentType,
                _viewModel.PickerPaymentTypeTranslation
                )
                );

            //PaymentValue
            var PaymentValueCell = new ViewCell();
            var PaymentValueStack = FormattedElementsHelper.TableRowStack();
            PaymentValueStack.Children.Add(FormattedElementsHelper.FormDataLabel(nameof(_viewModel.PaymentValueTranslation)));
            PaymentValueStack.Children.Add(FormattedElementsHelper.FormNumericEntry(nameof(_viewModel.PaymentValue), nameof(_viewModel.IsEditMode), null));
            PaymentValueCell.View = PaymentValueStack;

            PaymentTypeVerticalStack.Children.Add(PaymentTypeTypeStack);
            PaymentTypeVerticalStack.Children.Add(PaymentValueStack);
            PaymentTypeCell.View = PaymentTypeVerticalStack;
            FullTableSection.Add(PaymentTypeCell);

           

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


            ManureSaleTableView.Root.Add(FullTableSection);
        }
    }
}