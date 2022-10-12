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
            var HealthCareTypeStack = FormattedElementsHelper.TableRowStack();
            HealthCareTypeStack.Children.Add(FormattedElementsHelper.FormDataLabel(nameof(_viewModel.HealthCareTypeTranslation)));
            HealthCareTypeStack.Children.Add(FormattedElementsHelper.FormPickerEntry(
                nameof(_viewModel.HealthCareTypeListOfOptions),
                nameof(PickerToolHelper.TranslatedValue),
                nameof(_viewModel.SelectedHealthCareType),
                nameof(_viewModel.IsEditMode),
                _viewModel.SelectedHealthCareType,
                _viewModel.PickerHealthCareTypeTranslation
                )
                );
            var OtherHealthCareType = FormattedElementsHelper.TableRowStack(nameof(_viewModel.DisplayOtherHealthCareType), true);
            OtherHealthCareType.Children.Add(FormattedElementsHelper.FormDataLabel(nameof(_viewModel.OtherHealthCareTypeTranslation)));
            OtherHealthCareType.Children.Add(FormattedElementsHelper.FormTextEntry(nameof(_viewModel.OtherHealthCareType), nameof(_viewModel.IsEditMode)));
            HealthCareTypeVerticalStack.Children.Add(HealthCareTypeStack);
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
            var ProviderTypeStack = FormattedElementsHelper.TableRowStack();
            ProviderTypeStack.Children.Add(FormattedElementsHelper.FormDataLabel(nameof(_viewModel.ProviderTranslation)));
            ProviderTypeStack.Children.Add(FormattedElementsHelper.FormPickerEntry(
                nameof(_viewModel.ProviderListOfOptions),
                nameof(PickerToolHelper.TranslatedValue),
                nameof(_viewModel.SelectedProvider),
                nameof(_viewModel.IsEditMode),
                _viewModel.SelectedProvider,
                _viewModel.PickerProviderTranslation
                )
                );
            var OtherProviderType = FormattedElementsHelper.TableRowStack(nameof(_viewModel.DisplayOtherProvider), true);
            OtherProviderType.Children.Add(FormattedElementsHelper.FormDataLabel(nameof(_viewModel.OtherProviderTranslation)));
            OtherProviderType.Children.Add(FormattedElementsHelper.FormTextEntry(nameof(_viewModel.OtherProvider), nameof(_viewModel.IsEditMode)));
            ProviderVerticalStack.Children.Add(ProviderTypeStack);
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
            var MedicineTypeTypeStack = FormattedElementsHelper.TableRowStack();
            MedicineTypeTypeStack.Children.Add(FormattedElementsHelper.FormDataLabel(nameof(_viewModel.MedicineTypeTranslation)));
            MedicineTypeTypeStack.Children.Add(FormattedElementsHelper.FormPickerEntry(
                nameof(_viewModel.MedicineTypeListOfOptions),
                nameof(PickerToolHelper.TranslatedValue),
                nameof(_viewModel.SelectedMedicineType),
                nameof(_viewModel.IsEditMode),
                _viewModel.SelectedMedicineType,
                _viewModel.PickerMedicineTypeTranslation
                )
                );
            var OtherMedicineType = FormattedElementsHelper.TableRowStack(nameof(_viewModel.DisplayOtherMedicineType), true);
            OtherMedicineType.Children.Add(FormattedElementsHelper.FormDataLabel(nameof(_viewModel.OtherMedicineTypeTranslation)));
            OtherMedicineType.Children.Add(FormattedElementsHelper.FormTextEntry(nameof(_viewModel.OtherMedicineType), nameof(_viewModel.IsEditMode)));
            MedicineTypeVerticalStack.Children.Add(MedicineTypeTypeStack);
            MedicineTypeVerticalStack.Children.Add(OtherMedicineType);
            MedicineTypeCell.View = MedicineTypeVerticalStack;
            FullTableSection.Add(MedicineTypeCell);

            // Purchased From
            var PurchasedFromCell = new ViewCell();
            var FromVerticalStack = FormattedElementsHelper.TableRowStack(stackOrientation: StackOrientation.Vertical);
            FromVerticalStack.Padding = 0;
            var PurchasedFromTypeStack = FormattedElementsHelper.TableRowStack();
            PurchasedFromTypeStack.Children.Add(FormattedElementsHelper.FormDataLabel(nameof(_viewModel.PurchasedFromTranslation)));
            PurchasedFromTypeStack.Children.Add(FormattedElementsHelper.FormPickerEntry(
                nameof(_viewModel.PurchasedFromListOfOptions),
                nameof(PickerToolHelper.TranslatedValue),
                nameof(_viewModel.SelectedPurchasedFrom),
                nameof(_viewModel.IsEditMode),
                _viewModel.SelectedPurchasedFrom,
                _viewModel.PickerPurchasedFromTranslation
                )
                );
            var OtherPurchasedFromType = FormattedElementsHelper.TableRowStack(nameof(_viewModel.DisplayOtherPurchasedFrom), true);
            OtherPurchasedFromType.Children.Add(FormattedElementsHelper.FormDataLabel(nameof(_viewModel.OtherPurchasedFromTranslation)));
            OtherPurchasedFromType.Children.Add(FormattedElementsHelper.FormTextEntry(nameof(_viewModel.OtherPurchasedFrom), nameof(_viewModel.IsEditMode)));
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


            HealthCareTableView.Root.Add(FullTableSection);
        }
    }
}