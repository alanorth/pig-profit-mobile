using Azure;
using Azure.Data.Tables;
using System;

namespace Shared
{
    public class BaseItem : ITableEntity
    {
        //public string PartitionKey { get; set; }
        //public int Id { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsModified { get; set; }
        public bool IsEnable { get; set; }
        public DateTime CreatedTimeStamp { get; set; }
        public string CreatedBy { get; set; }
        public DateTime LastModified { get; set; }

        public virtual string PartitionKey { get; set ; }
        public virtual string RowKey { get; set ; }
        public DateTimeOffset? Timestamp { get; set; }
        public ETag ETag { get; set; }
    }
}
