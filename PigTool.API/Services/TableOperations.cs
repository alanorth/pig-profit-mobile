
using Microsoft.VisualBasic;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Collections.Concurrent;
using Shared;

namespace PigTool.API.Services
{
    public class TableOperations
    {
        public CloudTable GetStorageTable(string masterStorageConnectionString, string tableName)
        {
                var storageAccount = CloudStorageAccount.Parse(masterStorageConnectionString);
                CloudTable table;
                var tableClient = storageAccount.CreateCloudTableClient();

                table = tableClient.GetTableReference(tableName);
                table.CreateIfNotExistsAsync();
                return table;
        }

        public async Task<string> InsertTableEntities(
         IEnumerable<ITableEntity> entities,
         string tableName,
         string masterStorageConnectionString)
        {
            try
            {
                var table = GetStorageTable(masterStorageConnectionString, tableName);

                // nothing to do just bail out now
                if ((entities == null)
                    || !entities.Any())
                {
                    return "no entities ";
                }

                // Check to see if table name is provided
                if (string.IsNullOrWhiteSpace(tableName)
                    && table == null)
                {
                    return "no table name";
                }

                // Make sure table exists in db
                // Construct the query operation
                // Create the batch operation.
                var batchOperation = new TableBatchOperation();

                // because items in TableBatchOperation can't have different PartitionKeys,
                // we need to group them into entityGroups by PartitionKey
                var entitiesPartitionKeyGroup = entities
                    .GroupBy(f => f.PartitionKey).ToList();

                foreach (var entityGroup in entitiesPartitionKeyGroup)
                {
                    foreach (var entity in entityGroup)
                    {
                        // TableBatchOperation not full yet
                        if (batchOperation.Count < 100)
                        {
                            var hasDuplicate = batchOperation
                                .Any(ba => ba.Entity.PartitionKey == entity.PartitionKey && ba.Entity.RowKey == entity.RowKey);

                            if (!hasDuplicate)
                            {
                                //batchOperation.Add(TableOperation.InsertOrReplace(entity));
                                batchOperation.InsertOrReplace(entity);
                            }
                        }
                        else
                        {
                            // Execute the batch operation and reset TableBatchOperation
                            await table.ExecuteBatchAsync(batchOperation);

                            batchOperation = new TableBatchOperation();
                            //batchOperation.Add(TableOperation.InsertOrReplace(entity));
                            batchOperation.InsertOrReplace(entity);
                        }
                    }
                    // Execute the batch operation
                    if (batchOperation.Any())
                    {
                        await table.ExecuteBatchAsync(batchOperation);
                       
                    }
                    batchOperation = new TableBatchOperation();
                }

                if (batchOperation.Any())
                {
                    await table.ExecuteBatchAsync(batchOperation);
                }
            }
            catch (StorageException exception)
            {

                return exception.Message;
            }
            catch (Exception ex)
            {
                // https://stackoverflow.com/questions/881473/why-catch-and-rethrow-an-exception-in-c
                return ex.Message;
            }

            return string.Empty;
        }

    }
}
