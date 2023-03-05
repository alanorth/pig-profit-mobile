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
    public partial class BreedingServiceSalePage : ContentPage
    {
        private BreedingServiceSaleViewModel _viewModel;
        private bool IsRendered = false;

        public BreedingServiceSalePage()
        {
            BindingContext = _viewModel = new BreedingServiceSaleViewModel();
            InitializeComponent();
        }

        public BreedingServiceSalePage(BreedingServiceSaleItem WCI)
        {
            BindingContext = _viewModel = new BreedingServiceSaleViewModel();
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

            // Service Type
            var ServiceTypeCell = new ViewCell();
            var ServiceTypeVerticalStack = FormattedElementsHelper.TableRowStack(stackOrientation: StackOrientation.Vertical);
            ServiceTypeVerticalStack.Padding = 0;
            var ServiceTypeTypeStack = FormattedElementsHelper.TableRowGrid();
            FormattedElementsHelper.AddGridValue(
                ServiceTypeTypeStack,
                FormattedElementsHelper.FormDataLabel(nameof(_viewModel.ServiceTypeTranslation)),
                GridPostion.TwoLeft);
            FormattedElementsHelper.AddGridValue(
                ServiceTypeTypeStack,
                FormattedElementsHelper.FormPickerEntry(
                nameof(_viewModel.ServiceTypeListOfOptions),
                nameof(PickerToolHelper.TranslatedValue),
                nameof(_viewModel.SelectedServiceType),
                nameof(_viewModel.IsEditMode),
                _viewModel.SelectedServiceType,
                _viewModel.PickerServiceTypeTranslation
                ),
                GridPostion.TwoRight);
            var OtherServiceType = FormattedElementsHelper.TableRowGrid(nameof(_viewModel.DisplayOtherServiceType), true);
            FormattedElementsHelper.AddGridValue(
                OtherServiceType,
                FormattedElementsHelper.FormDataLabel(nameof(_viewModel.OtherServiceTypeTranslation)),
                GridPostion.TwoLeft);
            FormattedElementsHelper.AddGridValue(
                OtherServiceType,
                FormattedElementsHelper.FormTextEntry(nameof(_viewModel.OtherServiceType), nameof(_viewModel.IsEditMode)),
                GridPostion.TwoRight);
            ServiceTypeVerticalStack.Children.Add(ServiceTypeTypeStack);
            ServiceTypeVerticalStack.Children.Add(OtherServiceType);
            ServiceTypeCell.View = ServiceTypeVerticalStack;
            FullTableSection.Add(ServiceTypeCell);

            //NumberServices
            var NumberServicesCell = new ViewCell();
            var NumberServicesStack = FormattedElementsHelper.TableRowStack();
            NumberServicesStack.Children.Add(FormattedElementsHelper.FormDataLabel(nameof(_viewModel.NumberServicesTranslation)));
            NumberServicesStack.Children.Add(FormattedElementsHelper.FormNumericEntry(nameof(_viewModel.NumberServices), nameof(_viewModel.IsEditMode), null));
            NumberServicesCell.View = NumberServicesStack;
            FullTableSection.Add(NumberServicesCell);

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

            var PaymentTypeTypeStack = FormattedElementsHelper.TableRowGrid();
            FormattedElementsHelper.AddGridValue(
                PaymentTypeTypeStack,
                FormattedElementsHelper.FormDataLabel(nameof(_viewModel.PaymentTypeTranslation)),
                GridPostion.TwoLeft);
            FormattedElementsHelper.AddGridValue(
                PaymentTypeTypeStack,
                FormattedElementsHelper.FormPickerEntry(
                    nameof(_viewModel.PaymentTypeListOfOptions),
                    nameof(PickerToolHelper.TranslatedValue),
                    nameof(_viewModel.SelectedPaymentType),
                    nameof(_viewModel.IsEditMode),
                    _viewModel.SelectedPaymentType,
                    _viewModel.PickerPaymentTypeTranslation
                    ),
                GridPostion.TwoRight);

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

           

            // Client
            var ClientCell = new ViewCell();
            var ClientVerticalStack = FormattedElementsHelper.TableRowStack(stackOrientation: StackOrientation.Vertical);
            ClientVerticalStack.Padding = 0;
            var ClientTypeStack = FormattedElementsHelper.TableRowGrid();
            FormattedElementsHelper.AddGridValue(
                ClientTypeStack,
                FormattedElementsHelper.FormDataLabel(nameof(_viewModel.ClientTranslation)),
                GridPostion.TwoLeft);
            FormattedElementsHelper.AddGridValue(
                ClientTypeStack,
                FormattedElementsHelper.FormPickerEntry(
                    nameof(_viewModel.ClientListOfOptions),
                    nameof(PickerToolHelper.TranslatedValue),
                    nameof(_viewModel.SelectedClient),
                    nameof(_viewModel.IsEditMode),
                    _viewModel.SelectedClient,
                    _viewModel.PickerClientTranslation
                    ),
                GridPostion.TwoRight);          
            var OtherClient = FormattedElementsHelper.TableRowGrid(nameof(_viewModel.DisplayOtherClient), true);
            FormattedElementsHelper.AddGridValue(
                OtherClient,
                FormattedElementsHelper.FormDataLabel(nameof(_viewModel.OtherClientTranslation)),
                GridPostion.TwoLeft);
            FormattedElementsHelper.AddGridValue(
                OtherClient,
                FormattedElementsHelper.FormTextEntry(nameof(_viewModel.OtherClient), nameof(_viewModel.IsEditMode)),
                GridPostion.TwoRight);
            ClientVerticalStack.Children.Add(ClientTypeStack);
            ClientVerticalStack.Children.Add(OtherClient);
            ClientCell.View = ClientVerticalStack;
            FullTableSection.Add(ClientCell);

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


            BreedingServiceSaleTableView.Root.Add(FullTableSection);
        }
    }
}