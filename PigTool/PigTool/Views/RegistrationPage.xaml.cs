﻿using PigTool.Helpers;
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
    public partial class RegistrationPage : ContentPage
    {
        private RegistrationViewModel _viewModel;
        private bool IsRendered = false;
        private UserLangSettings lang;
        private string countryTranslationRowKey;


        public RegistrationPage(string AccessToken,  string email, UserLangSettings lang, string countryTranslationRowKey)
        {
            InitializeComponent();
            this.lang = lang;
            this.countryTranslationRowKey = countryTranslationRowKey;
            BindingContext = _viewModel = new RegistrationViewModel(lang, countryTranslationRowKey, true);
            _viewModel.accessToken = AccessToken;
            _viewModel.registeredEmail = email;
            RegistrationTitleLabel.Text = _viewModel.RegistrationTitleTranslation;
        }

        public RegistrationPage(MobileUser UI, bool newUser)
        {
            BindingContext = _viewModel = new RegistrationViewModel(newUser);
            _viewModel.populatewithData(UI);
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

                _viewModel.ShowSuccess = (async (obj) =>
                {
                    await Shell.Current.GoToAsync("//RegistrationSuccessful");
                });
            }
        }

        private void PopulateTheTable()
        {
            var FullTableSection = new TableSection();

            // UserName
            var UserNameCell = new ViewCell();
            var UserNameStack = FormattedElementsHelper.TableRowStack();
            UserNameStack.Children.Add(FormattedElementsHelper.FormDataLabel(nameof(_viewModel.UserNameTranslation)));
            UserNameStack.Children.Add(FormattedElementsHelper.FormTextEntry(nameof(_viewModel.UserName), nameof(_viewModel.IsEditMode), null));
            UserNameCell.View = UserNameStack;
            FullTableSection.Add(UserNameCell);

            // Name
            var NameCell = new ViewCell();
            var NameStack = FormattedElementsHelper.TableRowStack();
            NameStack.Children.Add(FormattedElementsHelper.FormDataLabel(nameof(_viewModel.NameTranslation)));
            NameStack.Children.Add(FormattedElementsHelper.FormTextEntry(nameof(_viewModel.Name), nameof(_viewModel.IsEditMode), null));
            NameCell.View = NameStack;
            FullTableSection.Add(NameCell);


            //Gender
            var GenderCell = new ViewCell();
            var GenderVerticalStack = FormattedElementsHelper.TableRowStack(stackOrientation: StackOrientation.Vertical);
            GenderVerticalStack.Padding = 0;
            var GenderStack = FormattedElementsHelper.TableRowStack();
            GenderStack.Children.Add(FormattedElementsHelper.FormDataLabel(nameof(_viewModel.GenderTranslation)));
            GenderStack.Children.Add(FormattedElementsHelper.FormPickerEntry(
                nameof(_viewModel.GenderListOfOptions),
                nameof(PickerToolHelper.TranslatedValue),
                nameof(_viewModel.SelectedGender),
                nameof(_viewModel.IsEditMode),
                _viewModel.SelectedGender,
                _viewModel.PickerGenderTranslation
                )
                );
            GenderVerticalStack.Children.Add(GenderStack);
            GenderCell.View = GenderVerticalStack;
            FullTableSection.Add(GenderCell);

            // Email
            var EmailCell = new ViewCell();
            var EmailStack = FormattedElementsHelper.TableRowStack();
            EmailStack.Children.Add(FormattedElementsHelper.FormDataLabel(nameof(_viewModel.EmailTranslation)));
            EmailStack.Children.Add(FormattedElementsHelper.FormTextEntry(nameof(_viewModel.Email), nameof(_viewModel.IsEditMode), null));
            EmailCell.View = EmailStack;
            FullTableSection.Add(EmailCell);

            // PhoneNumber
            var PhoneNumberCell = new ViewCell();
            var PhoneNumberStack = FormattedElementsHelper.TableRowStack();
            PhoneNumberStack.Children.Add(FormattedElementsHelper.FormDataLabel(nameof(_viewModel.PhoneNumberTranslation)));
            PhoneNumberStack.Children.Add(FormattedElementsHelper.FormTextEntry(nameof(_viewModel.PhoneNumber), nameof(_viewModel.IsEditMode), null));
            PhoneNumberCell.View = PhoneNumberStack;
            FullTableSection.Add(PhoneNumberCell);


            // Province
            if (countryTranslationRowKey == "CountryTypeVietnam" || countryTranslationRowKey == "CountryTypeRwanda")
            {
                var ProvinceCell = new ViewCell();
                var ProvinceStack = FormattedElementsHelper.TableRowStack();
                ProvinceStack.Children.Add(FormattedElementsHelper.FormDataLabel(nameof(_viewModel.ProvinceTranslation)));
                ProvinceStack.Children.Add(FormattedElementsHelper.FormTextEntry(nameof(_viewModel.Province), nameof(_viewModel.IsEditMode), null));
                ProvinceCell.View = ProvinceStack;
                FullTableSection.Add(ProvinceCell);
            }


            /*District
            var DistrictCell = new ViewCell();
            var DistrictVerticalStack = FormattedElementsHelper.TableRowStack(stackOrientation: StackOrientation.Vertical);
            DistrictVerticalStack.Padding = 0;
            var DistrictStack = FormattedElementsHelper.TableRowStack();
            DistrictStack.Children.Add(FormattedElementsHelper.FormDataLabel(nameof(_viewModel.DistrictTranslation)));
            DistrictStack.Children.Add(FormattedElementsHelper.FormPickerEntry(
                nameof(_viewModel.DistrictListOfOptions),
                nameof(PickerToolHelper.TranslatedValue),
                nameof(_viewModel.SelectedDistrict),
                nameof(_viewModel.IsEditMode),
                _viewModel.SelectedDistrict,
                _viewModel.PickerDistrictTranslation
                )
                );
            DistrictVerticalStack.Children.Add(DistrictStack);
            DistrictCell.View = DistrictVerticalStack;
            FullTableSection.Add(DistrictCell);
            */
            var DistrictCell = new ViewCell();
            var DistrictStack = FormattedElementsHelper.TableRowStack();
            DistrictStack.Children.Add(FormattedElementsHelper.FormDataLabel(nameof(_viewModel.DistrictTranslation)));
            DistrictStack.Children.Add(FormattedElementsHelper.FormTextEntry(nameof(_viewModel.District), nameof(_viewModel.IsEditMode), null));
            DistrictCell.View = DistrictStack;
            FullTableSection.Add(DistrictCell);

            if (countryTranslationRowKey == "CountryTypeUganda")
            {
                /*County
                var CountyCell = new ViewCell();
                var CountyVerticalStack = FormattedElementsHelper.TableRowStack(stackOrientation: StackOrientation.Vertical);
                CountyVerticalStack.Padding = 0;
                var CountyStack = FormattedElementsHelper.TableRowStack();
                CountyStack.Children.Add(FormattedElementsHelper.FormDataLabel(nameof(_viewModel.CountyTranslation)));
                CountyStack.Children.Add(FormattedElementsHelper.FormPickerEntry(
                    nameof(_viewModel.CountyListOfOptions),
                    nameof(PickerToolHelper.TranslatedValue),
                    nameof(_viewModel.SelectedCounty),
                    nameof(_viewModel.IsEditMode),
                    _viewModel.SelectedCounty,
                    _viewModel.PickerCountyTranslation
                    )
                    );
                CountyVerticalStack.Children.Add(CountyStack);
                CountyCell.View = CountyVerticalStack;
                FullTableSection.Add(CountyCell);
                */
                var CountyCell = new ViewCell();
                var CountyStack = FormattedElementsHelper.TableRowStack();
                CountyStack.Children.Add(FormattedElementsHelper.FormDataLabel(nameof(_viewModel.CountyTranslation)));
                CountyStack.Children.Add(FormattedElementsHelper.FormTextEntry(nameof(_viewModel.County), nameof(_viewModel.IsEditMode), null));
                CountyCell.View = CountyStack;
                FullTableSection.Add(CountyCell);

                /*Sub County
                var SubCountyCell = new ViewCell();
                var SubCountyVerticalStack = FormattedElementsHelper.TableRowStack(stackOrientation: StackOrientation.Vertical);
                SubCountyVerticalStack.Padding = 0;
                var SubCountyStack = FormattedElementsHelper.TableRowStack();
                SubCountyStack.Children.Add(FormattedElementsHelper.FormDataLabel(nameof(_viewModel.SubCountyTranslation)));
                SubCountyStack.Children.Add(FormattedElementsHelper.FormPickerEntry(
                    nameof(_viewModel.SubCountyListOfOptions),
                    nameof(PickerToolHelper.TranslatedValue),
                    nameof(_viewModel.SelectedSubCounty),
                    nameof(_viewModel.IsEditMode),
                    _viewModel.SelectedSubCounty,
                    _viewModel.PickerSubCountyTranslation
                    )
                    );
                SubCountyVerticalStack.Children.Add(SubCountyStack);
                SubCountyCell.View = SubCountyVerticalStack;
                FullTableSection.Add(SubCountyCell);
                */
                var SubCountyCell = new ViewCell();
                var SubCountyStack = FormattedElementsHelper.TableRowStack();
                SubCountyStack.Children.Add(FormattedElementsHelper.FormDataLabel(nameof(_viewModel.SubCountyTranslation)));
                SubCountyStack.Children.Add(FormattedElementsHelper.FormTextEntry(nameof(_viewModel.SubCounty), nameof(_viewModel.IsEditMode), null));
                SubCountyCell.View = SubCountyStack;
                FullTableSection.Add(SubCountyCell);

                // Parish
                var ParishCell = new ViewCell();
                var ParishStack = FormattedElementsHelper.TableRowStack();
                ParishStack.Children.Add(FormattedElementsHelper.FormDataLabel(nameof(_viewModel.ParishTranslation)));
                ParishStack.Children.Add(FormattedElementsHelper.FormTextEntry(nameof(_viewModel.Parish), nameof(_viewModel.IsEditMode), null));
                ParishCell.View = ParishStack;
                FullTableSection.Add(ParishCell);
            }


            // Commune
            if (countryTranslationRowKey == "CountryTypeVietnam")
            {
                var CommuneCell = new ViewCell();
                var CommuneStack = FormattedElementsHelper.TableRowStack();
                CommuneStack.Children.Add(FormattedElementsHelper.FormDataLabel(nameof(_viewModel.CommuneTranslation)));
                CommuneStack.Children.Add(FormattedElementsHelper.FormTextEntry(nameof(_viewModel.Commune), nameof(_viewModel.IsEditMode), null));
                CommuneCell.View = CommuneStack;
                FullTableSection.Add(CommuneCell);
            }


            if (countryTranslationRowKey == "CountryTypeRwanda")
            { 
                // Sector
                var SectorCell = new ViewCell();
                var SectorStack = FormattedElementsHelper.TableRowStack();
                SectorStack.Children.Add(FormattedElementsHelper.FormDataLabel(nameof(_viewModel.SectorTranslation)));
                SectorStack.Children.Add(FormattedElementsHelper.FormTextEntry(nameof(_viewModel.Sector), nameof(_viewModel.IsEditMode), null));
                SectorCell.View = SectorStack;
                FullTableSection.Add(SectorCell);

                // Cell
                var CellCell = new ViewCell();
                var CellStack = FormattedElementsHelper.TableRowStack();
                CellStack.Children.Add(FormattedElementsHelper.FormDataLabel(nameof(_viewModel.CellTranslation)));
                CellStack.Children.Add(FormattedElementsHelper.FormTextEntry(nameof(_viewModel.Cell), nameof(_viewModel.IsEditMode), null));
                CellCell.View = CellStack;
                FullTableSection.Add(CellCell);
            }

            // Village
            var VillageCell = new ViewCell();
            var VillageStack = FormattedElementsHelper.TableRowStack();
            VillageStack.Children.Add(FormattedElementsHelper.FormDataLabel(nameof(_viewModel.VillageTranslation)));
            VillageStack.Children.Add(FormattedElementsHelper.FormTextEntry(nameof(_viewModel.Village), nameof(_viewModel.IsEditMode), null));
            VillageCell.View = VillageStack;
            FullTableSection.Add(VillageCell);

            //Currency
            var CurrencyCell = new ViewCell();
            var CurrencyVerticalStack = FormattedElementsHelper.TableRowStack(stackOrientation: StackOrientation.Vertical);
            CurrencyVerticalStack.Padding = 0;
            var CurrencyStack = FormattedElementsHelper.TableRowStack();
            CurrencyStack.Children.Add(FormattedElementsHelper.FormDataLabel(nameof(_viewModel.CurrencyTranslation)));
            CurrencyStack.Children.Add(FormattedElementsHelper.FormPickerEntry(
                nameof(_viewModel.CurrencyListOfOptions),
                nameof(PickerToolHelper.TranslatedValue),
                nameof(_viewModel.SelectedCurrency),
                nameof(_viewModel.IsEditMode),
                _viewModel.SelectedCurrency,
                _viewModel.PickerCurrencyTranslation
                )
                );
            CurrencyVerticalStack.Children.Add(CurrencyStack);
            CurrencyCell.View = CurrencyVerticalStack;
            FullTableSection.Add(CurrencyCell);

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


            RegistrationTableView.Root.Add(FullTableSection);

        }
    }
}