using System;
using System.Collections.Generic;
using System.Text;

namespace PigTool.Models
{
    public class BaseClass
    {
        public bool IsDeleted { get; set; }
        public bool IsModified { get; set; }
        public bool IsEnable { get; set; }
        public DateTime CreatedTimeStamp { get; set; }
    }
}
