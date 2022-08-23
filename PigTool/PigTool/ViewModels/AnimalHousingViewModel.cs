using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PigTool.Helpers;
using PigTool.Models;
using Xamarin.Forms;

namespace PigTool.ViewModels
{
    public class AnimalHousingViewModel : LoggedInViewModel
    {

        #region
        public string DateTranslation { get; set; }
        public string HousingExpenseTranslation { get; set; }
        public string OtherHousingExpenseTranslation { get; set; }
        public string TotalCostTranslation { get; set; }
        public string TransportationCostTranslation { get; set; }
        public string OtherCostTranslation { get; set; }
        public string SliderControlTranslation { get; set; }
        public string CommentTranslation { get; set; }
        #endregion


        #region
        DateTime Date { get; set; }
        string HousingExpense { get; set; }
        string OtherHousingExpense { get; set; }
        double? TotalCosts { get; set; }
        double? TransportationCost { get; set; }
        double? OtherCosts { get; set; }
        int YearsExpected { get; set; }

        #endregion


        public AnimalHousingViewModel()
        {
            TransportationCostTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(TransportationCostTranslation), User.UserLang);
            DateTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(DateTranslation), User.UserLang);
            HousingExpenseTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(HousingExpenseTranslation), User.UserLang);
            OtherHousingExpenseTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(OtherHousingExpenseTranslation), User.UserLang);
            TotalCostTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(TotalCostTranslation), User.UserLang);
            TransportationCostTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(TransportationCostTranslation), User.UserLang);
            OtherCostTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(OtherCostTranslation), User.UserLang);
            SliderControlTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(SliderControlTranslation), User.UserLang);
            CommentTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(CommentTranslation), User.UserLang);

        }
    }
}
