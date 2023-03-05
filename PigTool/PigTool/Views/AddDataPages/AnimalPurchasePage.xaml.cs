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
    public partial class AnimalPurchasePage : ContentPage
    {
        private AnimalPurchaseViewModel _viewModel;
        private bool IsRendered = false;

        public AnimalPurchasePage()
        {
            BindingContext = _viewModel = new AnimalPurchaseViewModel();
            InitializeComponent();
        }

        public AnimalPurchasePage(AnimalPurchaseItem WCI)
        {
            BindingContext = _viewModel = new AnimalPurchaseViewModel();
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

            // Animal Type
            var AnimalTypeCell = new ViewCell();
            var AnimalTypeVerticalStack = FormattedElementsHelper.TableRowStack(stackOrientation: StackOrientation.Vertical);
            AnimalTypeVerticalStack.Padding = 0;
            var AnimalTypeTypeStack = FormattedElementsHelper.TableRowGrid();
            FormattedElementsHelper.AddGridValue(
                AnimalTypeTypeStack,
                FormattedElementsHelper.FormDataLabel(nameof(_viewModel.AnimalTypeTranslation)),
                GridPostion.TwoLeft);
            FormattedElementsHelper.AddGridValue(
                AnimalTypeTypeStack,
                FormattedElementsHelper.FormPickerEntry(
                nameof(_viewModel.AnimalTypeListOfOptions),
                nameof(PickerToolHelper.TranslatedValue),
                nameof(_viewModel.SelectedAnimalType),
                nameof(_viewModel.IsEditMode),
                _viewModel.SelectedAnimalType,
                _viewModel.PickerAnimalTypeTranslation
                ),
                GridPostion.TwoRight);
            var OtherAnimalType = FormattedElementsHelper.TableRowGrid(nameof(_viewModel.DisplayOtherAnimalType), true);
            FormattedElementsHelper.AddGridValue(
                OtherAnimalType,
                FormattedElementsHelper.FormDataLabel(nameof(_viewModel.OtherAnimalTypeTranslation)),
                GridPostion.TwoLeft);
            FormattedElementsHelper.AddGridValue(
                OtherAnimalType,
                FormattedElementsHelper.FormTextEntry(nameof(_viewModel.OtherAnimalType), nameof(_viewModel.IsEditMode)),
                GridPostion.TwoRight);
            AnimalTypeVerticalStack.Children.Add(AnimalTypeTypeStack);
            AnimalTypeVerticalStack.Children.Add(OtherAnimalType);
            AnimalTypeCell.View = AnimalTypeVerticalStack;
            FullTableSection.Add(AnimalTypeCell);

            // Number Purchased
            var NumberPurchasedCell = new ViewCell();
            var NumberPurchasedStack = FormattedElementsHelper.TableRowStack();
            NumberPurchasedStack.Children.Add(FormattedElementsHelper.FormDataLabel(nameof(_viewModel.NumberPurchasedTranslation)));
            NumberPurchasedStack.Children.Add(FormattedElementsHelper.FormNumericEntry(nameof(_viewModel.NumberPurchased), nameof(_viewModel.IsEditMode), null));
            NumberPurchasedCell.View = NumberPurchasedStack;
            FullTableSection.Add(NumberPurchasedCell);

            //Total Cost
            var TotalCostCell = new ViewCell();
            var TotalCostStack = FormattedElementsHelper.TableRowStack();
            TotalCostStack.Children.Add(FormattedElementsHelper.FormDataLabel(nameof(_viewModel.TotalAnimalCostsTranslation)));
            TotalCostStack.Children.Add(FormattedElementsHelper.FormNumericEntry(nameof(_viewModel.TotalCosts), nameof(_viewModel.IsEditMode), null));
            TotalCostCell.View = TotalCostStack;
            FullTableSection.Add(TotalCostCell);

            //Animal Purchased From
            var AnimalPurchasedFromCell = new ViewCell();
            var AnimalPurchasedFromVerticalStack = FormattedElementsHelper.TableRowStack(stackOrientation: StackOrientation.Vertical);
            AnimalPurchasedFromVerticalStack.Padding = 0;

            var AnimalPurchasedFromTypeStack = FormattedElementsHelper.TableRowGrid();
            FormattedElementsHelper.AddGridValue(
                AnimalPurchasedFromTypeStack,
                FormattedElementsHelper.FormDataLabel(nameof(_viewModel.AnimalPurchasedFromTranslation)),
                GridPostion.TwoLeft);
            FormattedElementsHelper.AddGridValue(
                AnimalPurchasedFromTypeStack,
                FormattedElementsHelper.FormPickerEntry(
                nameof(_viewModel.AnimalPurchasedFromListOfOptions),
                nameof(PickerToolHelper.TranslatedValue),
                nameof(_viewModel.SelectedAnimalPurchasedFrom),
                nameof(_viewModel.IsEditMode),
                _viewModel.SelectedAnimalPurchasedFrom,
                _viewModel.PickerPurchasedFromTranslation
                ),
                GridPostion.TwoRight);
            var OtherAnimalPurchasedFrom = FormattedElementsHelper.TableRowGrid(nameof(_viewModel.DisplayOtherAnimalPurchasedFrom), true);
            FormattedElementsHelper.AddGridValue(
                OtherAnimalPurchasedFrom,
                FormattedElementsHelper.FormDataLabel(nameof(_viewModel.OtherAnimalPurchasedTranslation)),
                GridPostion.TwoLeft);
            FormattedElementsHelper.AddGridValue(
                OtherAnimalPurchasedFrom,
                FormattedElementsHelper.FormTextEntry(nameof(_viewModel.OtherAnimalPurchasedFrom), nameof(_viewModel.IsEditMode)),
                GridPostion.TwoRight);
            AnimalPurchasedFromVerticalStack.Children.Add(AnimalPurchasedFromTypeStack);
            AnimalPurchasedFromVerticalStack.Children.Add(OtherAnimalPurchasedFrom);
            AnimalPurchasedFromCell.View = AnimalPurchasedFromVerticalStack;
            FullTableSection.Add(AnimalPurchasedFromCell);

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


            AnimalPurchaseTableView.Root.Add(FullTableSection);
        }
    }
}