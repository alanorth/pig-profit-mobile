using System;
using System.Collections.Generic;
using System.Text;

namespace PigTool.Models
{
    public class UserInfo
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string Village { get; set; }
        public DateTime LastUploadDate { get; set; }
        public UserLangSettings UserLang { get; set; }

    }
    public enum UserLangSettings
    {
        Eng,
        Lang1,
        Lang2
    }

}
