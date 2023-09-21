using Azure;
using Azure.Data.Tables;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;

namespace Shared
{
    public abstract class BaseItem : ITableEntity
    {
        //public string PartitionKey { get; set; }
        //public int Id { get; set; }
        public BaseItem()
        {
            IsDeleted = false;
            IsModified = false;
            IsEnable = true;
            CreatedTimeStamp = DateTime.UtcNow;
            LastModified = DateTime.UtcNow;
            RowKey = Guid.NewGuid().ToString();
        }

        [DefaultValue(false)]
        public bool IsDeleted { get; set; }
        [DefaultValue(false)]
        public bool IsModified { get; set; }
        [DefaultValue(true)]
        public bool IsEnable { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? CreatedTimeStamp { get; set; }

        public string CreatedBy { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime LastModified { get; set; }

        public virtual string PartitionKey { get; set ; }
        [Key]
        public virtual string RowKey { get; set ; }
        public DateTimeOffset? Timestamp { get; set; }
        [NotMapped]
        public ETag ETag { get; set; }
    }
}
