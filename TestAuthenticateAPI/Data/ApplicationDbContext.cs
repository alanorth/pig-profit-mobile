using ElCamino.AspNetCore.Identity.AzureTable;
using ElCamino.AspNetCore.Identity.AzureTable.Model;

namespace TestAuthenticateAPI.Data;

public class ApplicationDbContext : IdentityCloudContext
{
    public ApplicationDbContext(IdentityConfiguration config) : base(config)
    {
    }
}
