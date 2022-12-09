using System;
using System.Collections.Generic;
using System.Text;

namespace PigTool.Models
{
    public class MobileAuthModelData
    {
        public Dictionary<string, string> ResultProperties { get; set; }
        public bool SuccesfulResponse {get; set;}
        public string FailMessage { get; set;}
    }
}
