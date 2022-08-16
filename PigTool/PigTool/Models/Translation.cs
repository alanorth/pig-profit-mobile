using System;
using System.Collections.Generic;
using System.Text;

namespace PigTool.Models
{
    public class Translation
    {
        public string RowKey { get; set; }
        public string PartitionKey { get; }
        public string English { get; set; }
        public string Lang1 { get; set; }
        public string Lang2 { get; set; }
        public List<ControlData> ControlDatas { get; set; }

        public Translation()
        {
            PartitionKey = "Translation";
        }

        public string getTranslation(UserLangSettings lang)
        {
            switch (lang)
            {
                case UserLangSettings.Eng:
                    return English;
                case UserLangSettings.Lang1:
                    return Lang1;
                case UserLangSettings.Lang2:
                    return Lang2;
                default:
                    return English;
            }
        }
    }
}
