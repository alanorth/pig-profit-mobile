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
    public partial class HealthCarePage : ContentPage
    {
        private HealthCareViewModel _viewModel;
        private bool IsRendered = false;

        public HealthCarePage()
        {
            BindingContext = _viewModel = new HealthCareViewModel();
            InitializeComponent();
        }

        public HealthCarePage(HealthCareItem HCI)
        {
            BindingContext = _viewModel = new HealthCareViewModel();
            _viewModel.populatewithData(HCI);
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

            // Health Care Type
            var HealthCareTypeCell = new ViewCell();
            var HealthCareTypeVerticalStack = FormattedElementsHelper.TableRowStack(stackOrientation: StackOrientation.Vertical);
            HealthCareTypeVerticalStack.Padding = 0;
            var HealthCareGrid = FormattedElementsHelper.TableRowGrid();
            FormattedElementsHelper.AddGridValue(
                HealthCareGrid,
                FormattedElementsHelper.FormDataLabel(nameof(_viewModel.HealthCareTypeTranslation)),
                GridPostion.TwoLeft);
            FormattedElementsHelper.AddGridValue(
                HealthCareGrid,
                FormattedElementsHelper.FormPickerEntry(
                nameof(_viewModel.HealthCareTypeListOfOptions),
                nameof(PickerToolHelper.TranslatedValue),
                nameof(_viewModel.SelectedHealthCareType),
                nameof(_viewModel.IsEditMode),
                _viewModel.SelectedHealthCareType,
                _viewModel.PickerHealthCareTypeTranslation
                ),
                GridPostion.TwoRight);
            var OtherHealthCareType = FormattedElementsHelper.TableRowGrid(nameof(_viewModel.DisplayOtherHealthCareType), true);
            FormattedElementsHelper.AddGridValue(
                OtherHealthCareType,
                FormattedElementsHelper.FormDataLabel(nameof(_viewModel.OtherHealthCareTypeTranslation)),
                GridPostion.TwoLeft);
            FormattedElementsHelper.AddGridValue(
                OtherHealthCareType,
                FormattedElementsHelper.FormTextEntry(nameof(_viewModel.OtherHealthCareType), nameof(_viewModel.IsEditMode)),
                GridPostion.TwoRight);
            HealthCareTypeVerticalStack.Children.Add(HealthCareGrid);
            HealthCareTypeVerticalStack.Children.Add(OtherHealthCareType);
            HealthCareTypeCell.View = HealthCareTypeVerticalStack;
            FullTableSection.Add(HealthCareTypeCell);

            //Care Cost
            var HealthCareCostCell = new ViewCell();
            var HealthCareCostStack = FormattedElementsHelper.TableRowStack();
            HealthCareCostStack.Children.Add(FormattedElementsHelper.FormDataLabel(nameof(_viewModel.HealthCareCostTranslation)));
            HealthCareCostStack.Children.Add(FormattedElementsHelper.FormNumericEntry(nameof(_viewModel.HealthCareCost), nameof(_viewModel.IsEditMode), null));
            HealthCareCostCell.View = HealthCareCostStack;
            FullTableSection.Add(HealthCareCostCell);

            //Provider
            var ProviderCell = new ViewCell();
            var ProviderVerticalStack = FormattedElementsHelper.TableRowStack(stackOrientation: StackOrientation.Vertical);
            ProviderVerticalStack.Padding = 0;
            var ProviderTypeGrid = FormattedElementsHelper.TableRowGrid();
            FormattedElementsHelper.AddGridValue(ProviderTypeGrid,
                FormattedElementsHelper.FormDataLabel(nameof(_viewModel.ProviderTranslation)), GridPostion.TwoLeft);
            FormattedElementsHelper.AddGridValue(ProviderTypeGrid,
                FormattedElementsHelper.FormPickerEntry(
                nameof(_viewModel.ProviderListOfOptions),
                nameof(PickerToolHelper.TranslatedValue),
                nameof(_viewModel.SelectedProvider),
                nameof(_viewModel.IsEditMode),
                _viewModel.SelectedProvider,
                _viewModel.PickerProviderTranslation
                ),
                GridPostion.TwoRight
                );

            var OtherProviderType = FormattedElementsHelper.TableRowGrid(nameof(_viewModel.DisplayOtherProvider), true);
            FormattedElementsHelper.AddGridValue(OtherProviderType,
                FormattedElementsHelper.FormDataLabel(nameof(_viewModel.OtherProviderTranslation)),
            GridPostion.TwoLeft);
            FormattedElementsHelper.AddGridValue(OtherProviderType,
                FormattedElementsHelper.FormTextEntry(nameof(_viewModel.OtherProvider), nameof(_viewModel.IsEditMode)),
                GridPostion.TwoRight
                );
            ProviderVerticalStack.Children.Add(ProviderTypeGrid);
            ProviderVerticalStack.Children.Add(OtherProviderType);
            ProviderCell.View = ProviderVerticalStack;
            FullTableSection.Add(ProviderCell);

            //Medicine Cost
            var MedicineCostCell = new ViewCell();
            var MedicineCostsStack = FormattedElementsHelper.TableRowStack();
            MedicineCostsStack.Children.Add(FormattedElementsHelper.FormDataLabel(nameof(_viewModel.MedicineCostTranslation)));
            MedicineCostsStack.Children.Add(FormattedElementsHelper.FormNumericEntry(nameof(_viewModel.MedicineCost), nameof(_viewModel.IsEditMode), null));
            MedicineCostCell.View = MedicineCostsStack;
            FullTableSection.Add(MedicineCostCell);

            //Medicine type
            var MedicineTypeCell = new ViewCell();
            var MedicineTypeVerticalStack = FormattedElementsHelper.TableRowStack(stackOrientation: StackOrientation.Vertical);
            MedicineTypeVerticalStack.Padding = 0;
            var MedicineTypeTypeStack = FormattedElementsHelper.TableRowGrid();
            FormattedElementsHelper.AddGridValue(
                MedicineTypeTypeStack,
                FormattedElementsHelper.FormDataLabel(nameof(_viewModel.MedicineTypeTranslation)),
                GridPostion.TwoLeft);
            FormattedElementsHelper.AddGridValue(
                MedicineTypeTypeStack,
                FormattedElementsHelper.FormPickerEntry(
                    nameof(_viewModel.MedicineTypeListOfOptions),
                    nameof(PickerToolHelper.TranslatedValue),
                    nameof(_viewModel.SelectedMedicineType),
                    nameof(_viewModel.IsEditMode),
                    _viewModel.SelectedMedicineType,
                    _viewModel.PickerMedicineTypeTranslation
                    ),
                GridPostion.TwoRight);
            var OtherMedicineType = FormattedElementsHelper.TableRowGrid(nameof(_viewModel.DisplayOtherMedicineType), true);
            FormattedElementsHelper.AddGridValue(
                OtherMedicineType,
                FormattedElementsHelper.FormDataLabel(nameof(_viewModel.OtherMedicineTypeTranslation)),
                GridPostion.TwoLeft);
            FormattedElementsHelper.AddGridValue(
                OtherMedicineType,
                FormattedElementsHelper.FormTextEntry(nameof(_viewModel.OtherMedicineType), nameof(_viewModel.IsEditMode)),
                GridPostion.TwoRight);
            MedicineTypeVerticalStack.Children.Add(MedicineTypeTypeStack);
            MedicineTypeVerticalStack.Children.Add(OtherMedicineType);
            MedicineTypeCell.View = MedicineTypeVerticalStack;
            FullTableSection.Add(MedicineTypeCell);

            // Purchased From
            var PurchasedFromCell = new ViewCell();
            var FromVerticalStack = FormattedElementsHelper.TableRowStack(stackOrientation: StackOrientation.Vertical);
            FromVerticalStack.Padding = 0;
            var PurchasedFromTypeStack = FormattedElementsHelper.TableRowGrid();
            FormattedElementsHelper.AddGridValue(
                PurchasedFromTypeStack,
                FormattedElementsHelper.FormDataLabel(nameof(_viewModel.PurchasedFromTranslation)),
                GridPostion.TwoLeft);
            FormattedElementsHelper.AddGridValue(
                PurchasedFromTypeStack,
                FormattedElementsHelper.FormPickerEntry(
                    nameof(_viewModel.PurchasedFromListOfOptions),
                    nameof(PickerToolHelper.TranslatedValue),
                    nameof(_viewModel.SelectedPurchasedFrom),
                    nameof(_viewModel.IsEditMode),
                    _viewModel.SelectedPurchasedFrom,
                    _viewModel.PickerPurchasedFromTranslation),
                GridPostion.TwoRight);
            var OtherPurchasedFromType = FormattedElementsHelper.TableRowGrid(nameof(_viewModel.DisplayOtherPurchasedFrom), true);
            FormattedElementsHelper.AddGridValue(
                OtherPurchasedFromType,
                FormattedElementsHelper.FormDataLabel(nameof(_viewModel.OtherPurchasedFromTranslation)),
                GridPostion.TwoLeft);
            FormattedElementsHelper.AddGridValue(
                OtherPurchasedFromType,
                FormattedElementsHelper.FormTextEntry(nameof(_viewModel.OtherPurchasedFrom), nameof(_viewModel.IsEditMode)),
                GridPostion.TwoRight);
            FromVerticalStack.Children.Add(PurchasedFromTypeStack);
            FromVerticalStack.Children.Add(OtherPurchasedFromType);
            PurchasedFromCell.View = FromVerticalStack;
            FullTableSection.Add(PurchasedFromCell);

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


            HealthCareTableView.Root.Add(FullTableSection);
        }
    }
}