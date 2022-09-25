using Microsoft.AspNetCore.Mvc;
using PigTool.Shared;

namespace PigTool.API.Controllers
{
    public class PigToolBaseController : Controller
    {
        protected readonly IConfiguration _config;
       // protected readonly ILogger _logger;


        public PigToolBaseController(

           IConfiguration config)
        {
          
            _config = config;
       
        }

        protected string GetStorageConnectionString()
        {
            // https://stackoverflow.com/questions/30575689/how-do-we-use-cloudconfigurationmanager-with-asp-net-5-json-configs
            var storageConnectionString = _config[Constants.MasterStorageConnectionString];

            return storageConnectionString;
        }

    }
}
