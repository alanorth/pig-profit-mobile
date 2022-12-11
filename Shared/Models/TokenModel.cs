using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.Models
{
    public class TokenModel
    {
        public string? access_token { get; set; }
        public string? refresh_token { get; set; }
    }
}
