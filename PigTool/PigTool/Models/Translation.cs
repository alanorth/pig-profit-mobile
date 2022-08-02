using System;
using System.Collections.Generic;
using System.Text;

namespace PigTool.Models
{
    public class Translation : BaseClass
    {
        public string RowKey { get; set; }
        public string PartitionKey { get; }
        public string English { get; set; }
        public string Lang1 { get; set; }
        public string Lang2 { get; set; }

        public Translation()
        {
            PartitionKey = "Translation";
        }

        public string getTranslation(string lang)
        {
            switch (lang)
            {
                case nameof(English):
                    return English;
                case nameof(Lang1):
                    return Lang1;
                case nameof(Lang2):
                    return Lang2;
                default:
                    return English;
            }
        }
    }
}
