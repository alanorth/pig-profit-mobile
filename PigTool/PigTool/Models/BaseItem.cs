using System;
using System.Collections.Generic;
using System.Text;

namespace PigTool.Models
{
    public class BaseItem
    {
        public string PartitionKey { get; set; }
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsModified { get; set; }
        public bool IsEnable { get; set; }
        public DateTime CreatedTimeStamp { get; set; }
        public string CreatedBy { get; set; }
        public DateTime LastModified { get; set; }
    }
}
