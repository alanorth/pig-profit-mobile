using Azure;
using Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Azure.Data.Tables;

namespace Shared
{
    /// <summary>
    /// This class is used for the drop downs
    /// beacuse the drop downs need to be translated we cannot store the vlaue as string,
    /// Instead it will be store as ints in other tables and referenced back to this table
    /// </summary>
    [Table("ControlDataOptions")]
    public class ControlData : ITableEntity
    {
        public string DropDownControlOption { get; set; }
        public string TranslationRowKey { get; set; }
        public Translation Translation { get; set; }
        public int DisplayOrder { get; set; }
        [DefaultValue(false)]
        public bool IsDeleted { get; set; }
        [DefaultValue(true)]
        public bool IsEnable { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? CreatedTimeStamp { get; set; }

        public string CreatedBy { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? LastModified { get; set; }

        public virtual string PartitionKey { get; set; }
        
        public virtual string RowKey { get; set; }
        public DateTimeOffset? Timestamp { get; set; }
        [NotMapped]
        public ETag ETag { get; set; }

        public string getTranslation(UserLangSettings lang)
        {
            return Translation.getTranslation(lang);
        }
    }
}
