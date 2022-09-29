using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using Shared;

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

        protected async Task<JsonParseModel> Parse(HttpRequest request)
        {
            // Read request body string.
            string body = await new StreamReader(request.Body).ReadToEndAsync();

            // Parse.
            dynamic parsed;

            try
            {
                parsed = JToken.Parse(body);
            }
            catch (JsonReaderException ex)
            {
                return new JsonParseModel(true, false, null, ex.Message);
            }

            return new JsonParseModel(true, true, parsed, body);
        }

    }
}
