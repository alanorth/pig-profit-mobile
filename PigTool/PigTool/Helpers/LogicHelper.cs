using PigTool.Models;
using PigTool.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigTool.Helpers
{
    public static class LogicHelper
    {
        public static async Task<string> getTranslation(IDataRepo repo, string TranslationRowKey, UserLangSettings langSetting)
        {
            var trans = await repo.GetTranslationAsync(TranslationRowKey);
            if(trans == null)
            {
                return TranslationRowKey;
            }


            return trans.getTranslation(langSetting);
        }


        public static List<PickerToolHelper> CreatePickerToolOption(List<ControlData> CDList , UserLangSettings lang)
        {

            var returnList = new List<PickerToolHelper>();

            if (CDList.Any())
            {
                foreach(var CD in CDList)
                {
                    var picker = new PickerToolHelper();
                    picker.TranslationRowKey = CD.TranslationRowKey;
                    picker.TranslatedValue = CD.getTranslation(lang);

                    returnList.Add(picker);
                }
            }

            return returnList;
        }


        public static string GetTranslationFromStore(List<Translation> transList, string RowKey, UserLangSettings lang)
        {
            var translation = transList.Where(x => x.RowKey == RowKey).FirstOrDefault();

            if (translation != null)
            {
                return translation.getTranslation(lang);
            }

            return "Translation Not Found";
        }

    }



    public class PickerToolHelper : IComparable<PickerToolHelper>
    {
        public string TranslationRowKey { get; set; }
        public string TranslatedValue { get; set; }

        public int CompareTo(PickerToolHelper other)
        {
            if(other == null)
            {
                return 0;
            }

            return other.TranslationRowKey == this.TranslationRowKey ? 1 : 0;
        }
    }

    
}
