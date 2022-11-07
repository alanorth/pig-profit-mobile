using System;
using System.Collections.Generic;
using System.Text;
using Azure;
using Azure.Data.Tables;

namespace Shared
{
    public class Language
    {
        public string LanguageName { get; set; }
        public RegistrationLangSettings LangCode { get; set; }

    }
    public enum RegistrationLangSettings
    {
        Eng,
        Lang1,
        Lang2
    }

}
