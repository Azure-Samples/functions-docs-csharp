using System.Collections.Generic;
using System.Net;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;

namespace functions_add_output_binding_storage_queue_isolated
{
    public static class HttpExample
    {
        [Function("HttpExample")]
        public static MultiResponse Run([HttpTrigger(AuthorizationLevel.Function, "get", "post")] HttpRequestData req,
            FunctionContext executionContext)
        {
            var logger = executionContext.GetLogger("HttpExample");
            logger.LogInformation("C# HTTP trigger function processed a request.");

            var message = "Welcome to Azure Functions!";

            var response = req.CreateResponse(HttpStatusCode.OK);
            response.Headers.Add("Content-Type", "text/plain; charset=utf-8");
            response.WriteString(message);

            // Return a response to both HTTP trigger and storage output binding.
            return new MultiResponse()
            {
                Messages = new string[] { message },
                HttpResponse = response
            };
        }
    }
    public class MultiResponse
    {
        // Supports writing to both storage output binding and HTTP trigger responses.
        [QueueOutput("output-queue")]
        public string[] Messages { get; set; }
        public HttpResponseData HttpResponse { get; set; }
    }
}
