//using AspNetCore.Identity.Mongo.Model;
using ElCamino.AspNetCore.Identity.AzureTable.Model;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestAuthenticateAPI.Models
{
    public class TokenModel5
    {
        public string? access_token { get; set; }
        public string? refresh_token { get; set; }
    }
}

