using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shared;

namespace PigTool.API.Controllers
{
    [ApiController]
    [Tags("API Information")]
    public class PigToolAPIController : PigToolBaseController
    {
        public PigToolAPIController(

        IConfiguration config) : base(config)
        {

        }

        [HttpGet, Route(Constants.ROUTE_API_VERSION)]
        public ActionResult GetAuthApiVersion()
        {
            return new ContentResult()
            {
                Content = $"auth-api-ver: v2.0 at {DateTime.Now.ToString()}",
                ContentType = "text/plain"
            };
        }


        [HttpGet, Route(Constants.ROUTE_API_STORAGE)]
        public string Get()
        {
            
           var masterStorageConnectionString = GetStorageConnectionString();

            if (masterStorageConnectionString != null)
            {
                return "Storage account connection active";
            }
            else
            {
                return "Issue connecting to storage account";
            }
        }

        [HttpGet, Route(Constants.ROUTE_API_DENIED)]
        public ObjectResult AccessDenied()
        {
            return StatusCode(401, "Access has Been Denined again");
        }


        [Authorize]
        [HttpGet]
        [Route("api/authTest")]
        public IActionResult TestAuthorization()
        {
            return Ok("You're Authorized");
        }
    }
}