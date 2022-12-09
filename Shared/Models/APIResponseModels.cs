using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.Models
{
    public class DataUploadResponse
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public string Content { get; set; }

    }

    public class RefreshTokenResponse
    {
        public bool Success { get; set; }
        public string Token { get; set; }
        public string RefreshToken { get; set; }
        public int StatusCode { get; set; }
    }
}
