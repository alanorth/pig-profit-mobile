using System;
using System.Collections.Generic;
using System.Text;

namespace PigTool.Interfaces
{
    public interface IAppVersionService
    {
        string GetVersionNumber();

        public int GetVersionCode();
    }
}
