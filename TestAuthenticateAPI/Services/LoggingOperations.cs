using Azure.Storage.Blobs;
using Shared;
using System.Text;

namespace TestAuthenticateAPI.Services
{
    public static class LoggingOperations
    {
        public static async Task<string> LogRequestToBlob(string APIRequestType, string requestType, string payload, string callGUID, string masterStorageConnectionString)
        {
            var sendResult = "Error";

            try
            {
                // var accountKey = GetStorageConnectionString();
                //var tenantCode = SessionHelper.SessionTenant?.TenantCode;
                //var storageAccount = Azure.Storage.acc   Microsoft.WindowsAzure.Storage.CloudStorageAccount.Parse(masterStorageConnectionString);
                BlobServiceClient blobServiceClient = new BlobServiceClient(masterStorageConnectionString);
                //var blobClient = storageAccount.CreateCloudBlobClient();

                // Write to blob storage prior to processing
                var dtVal = DateTime.UtcNow;
                var tenantSettingsTimeZoneDT = dtVal.ToString(Constants.DATE_FORMAT_DMY) + " " + dtVal.ToShortTimeString();

                // azure treats "/" as subfolders, Storage Explorer can't download filenames with ":"
                tenantSettingsTimeZoneDT = tenantSettingsTimeZoneDT.Replace("/", "-");
                tenantSettingsTimeZoneDT = tenantSettingsTimeZoneDT.Replace(":", "-");

                var blobName = $"{"API_Data_" + APIRequestType}/{callGUID + "_" + requestType}_{tenantSettingsTimeZoneDT}";

                // Store blob name for event entry linking
                // SessionHelper.ImportDataValidationModel.FileName = blobName;

                // Retrieve a reference to the tenant code container.
                var tenantCodeContainer = blobServiceClient.GetBlobContainerClient("logging");
                await tenantCodeContainer.CreateIfNotExistsAsync();

                var blockBlob = tenantCodeContainer.GetBlobClient(blobName);// tenantCodeContainer.GetBlockBlobReference(blobName);


                byte[] byteArray = Encoding.UTF8.GetBytes(payload);
                //byte[] byteArray = Encoding.ASCII.GetBytes(contents);
                MemoryStream stream = new MemoryStream(byteArray);
                await blockBlob.UploadAsync(stream);



            }
            catch (Exception ex)
            {



            }


            return string.Empty;

        }




    }
}
