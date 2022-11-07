using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;

namespace Lab05;

public class Function4
{
    [FunctionName("Function4")]
    public void Run([QueueTrigger("queue", Connection = "")]string myQueueItem, ILogger log)
    {
        log.LogInformation($"C# Queue trigger function processed: {myQueueItem}");
    }
}