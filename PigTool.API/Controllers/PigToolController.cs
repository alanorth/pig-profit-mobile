using Microsoft.AspNetCore.Mvc;
using PigTool.Shared;

namespace PigTool.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PigToolController : PigToolBaseController
    {
        public PigToolController(

          IConfiguration config) : base(
          
              config
             )
        {

        }

        [HttpGet, Route(Constants.ROUTE_AUTH_VERSION)]
        public ActionResult GetAuthApiVersion()
        {
            

            return new ContentResult()
            {
                Content = $"auth-api-ver: v2.0 at {DateTime.Now.ToString()}",
                ContentType = "text/plain"
            };
        }


        [HttpGet, Route(Constants.ROUTE_AUTH_STORAGE)]
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
    }
}