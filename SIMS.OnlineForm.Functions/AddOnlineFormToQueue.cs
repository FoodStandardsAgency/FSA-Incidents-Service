using Microsoft.AspNetCore.Http;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using System;
using System.IO;
using System.Threading.Tasks;

namespace SIMS.OnlineForm.Functions
{
    public static class AddOnlineFormToQueue
    {
        [FunctionName("SendForm")]
        [return: Queue("%OnlineFormQueueName%", Connection = "ConnectionStrings:SIMSOnlineFormConnection")]
        public static async Task<string> Run(
            [HttpTrigger(AuthorizationLevel.Function,"post", Route = null)] HttpRequest req,
            ILogger log)
        {
            try
            {
                log.LogInformation("Online form receivied from website.");
                string onlineFormRaw = await new StreamReader(req.Body).ReadToEndAsync();
                return onlineFormRaw;
            }
            catch(Exception ex)
            {
                log.LogCritical("Send Form Failed", ex);
                throw ex;
            }
        }
    }
}
