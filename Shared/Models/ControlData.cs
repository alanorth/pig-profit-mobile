using Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Shared
{
    /// <summary>
    /// This class is used for the drop downs
    /// beacuse the drop downs need to be translated we cannot store the vlaue as string,
    /// Instead it will be store as ints in other tables and referenced back to this table
    /// </summary>
    [Table("ControlDataOptions")]
    public class ControlData : BaseItem
    {
        public string DropDownControlOption { get; set; }
        public string TranslationRowKey { get; set; }
        public Translation Translation { get; set; }
        public int DisplayOrder { get; set; }

        public string getTranslation(UserLangSettings lang)
        {
            return Translation.getTranslation(lang);
        }
    }
}
