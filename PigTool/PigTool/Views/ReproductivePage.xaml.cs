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
    public partial class ReproductivePage : ContentPage
    {
        private ReproductiveViewModel _viewModel;
        private bool IsRendered = false;

        public ReproductivePage()
        {
            BindingContext = _viewModel = new ReproductiveViewModel();
            InitializeComponent();
        }

        public ReproductivePage(ReproductiveItem MI)
        {
            BindingContext = _viewModel = new ReproductiveViewModel();
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

            

            //Service
            var ServiceTypeCell = new ViewCell();
            var ServiceTypeVerticalStack = FormattedElementsHelper.TableRowStack(stackOrientation: StackOrientation.Vertical);
            ServiceTypeVerticalStack.Padding = 0;
            var ServiceTypeStack = FormattedElementsHelper.TableRowStack();
            ServiceTypeStack.Children.Add(FormattedElementsHelper.FormDataLabel(nameof(_viewModel.ServiceTypeTranslation)));
            ServiceTypeStack.Children.Add(FormattedElementsHelper.FormPickerEntry(
                nameof(_viewModel.ServiceTypeListOfOptions),
                nameof(PickerToolHelper.TranslatedValue),
                nameof(_viewModel.SelectedServiceType),
                nameof(_viewModel.IsEditMode),
                _viewModel.SelectedServiceType,
                _viewModel.PickerServiceTypeTranslation
                )
                );
            var OtherServiceType = FormattedElementsHelper.TableRowStack(nameof(_viewModel.DisplayOtherServiceType), true);
            OtherServiceType.Children.Add(FormattedElementsHelper.FormDataLabel(nameof(_viewModel.OtherServiceTypeTranslation)));
            OtherServiceType.Children.Add(FormattedElementsHelper.FormTextEntry(nameof(_viewModel.OtherServiceType), nameof(_viewModel.IsEditMode)));
            ServiceTypeVerticalStack.Children.Add(ServiceTypeStack);
            ServiceTypeVerticalStack.Children.Add(OtherServiceType);
            ServiceTypeCell.View = ServiceTypeVerticalStack;
            FullTableSection.Add(ServiceTypeCell);


            // Sows Serviced
            var SowsServicedCell = new ViewCell();
            var SowsServicedStack = FormattedElementsHelper.TableRowStack();
            SowsServicedStack.Children.Add(FormattedElementsHelper.FormDataLabel(nameof(_viewModel.SowsServicedTranslation)));
            SowsServicedStack.Children.Add(FormattedElementsHelper.FormNumericEntry(nameof(_viewModel.SowsServiced), nameof(_viewModel.IsEditMode), null));
            SowsServicedCell.View = SowsServicedStack;
            FullTableSection.Add(SowsServicedCell);

            //Who Provided Service
            var WhoProvidedServiceCell = new ViewCell();
            var WhoProvidedServiceVerticalStack = FormattedElementsHelper.TableRowStack(stackOrientation: StackOrientation.Vertical);
            WhoProvidedServiceVerticalStack.Padding = 0;
            var WhoProvidedServiceStack = FormattedElementsHelper.TableRowStack();
            WhoProvidedServiceStack.Children.Add(FormattedElementsHelper.FormDataLabel(nameof(_viewModel.WhoProvidedServiceTranslation)));
            WhoProvidedServiceStack.Children.Add(FormattedElementsHelper.FormPickerEntry(
                nameof(_viewModel.WhoProvidedServiceListOfOptions),
                nameof(PickerToolHelper.TranslatedValue),
                nameof(_viewModel.SelectedWhoProvidedService),
                nameof(_viewModel.IsEditMode),
                _viewModel.SelectedWhoProvidedService,
                _viewModel.PickerProviderTranslation
                )
                );
            var OtherWhoProvidedService = FormattedElementsHelper.TableRowStack(nameof(_viewModel.DisplayOtherWhoProvidedService), true);
            OtherWhoProvidedService.Children.Add(FormattedElementsHelper.FormDataLabel(nameof(_viewModel.OtherWhoProvidedServiceTranslation)));
            OtherWhoProvidedService.Children.Add(FormattedElementsHelper.FormTextEntry(nameof(_viewModel.OtherWhoProvidedService), nameof(_viewModel.IsEditMode)));
            WhoProvidedServiceVerticalStack.Children.Add(WhoProvidedServiceStack);
            WhoProvidedServiceVerticalStack.Children.Add(OtherWhoProvidedService);
            WhoProvidedServiceCell.View = WhoProvidedServiceVerticalStack;
            FullTableSection.Add(WhoProvidedServiceCell);

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


            ReproductiveTableView.Root.Add(FullTableSection);
            
        }
    }
}