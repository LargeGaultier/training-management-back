using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Aliencube.AzureFunctions.Extensions.OpenApi.Attributes;
using Aliencube.AzureFunctions.Extensions.OpenApi;
using System.Net;
using Aliencube.AzureFunctions.Extensions.OpenApi.Extensions;

namespace TrainingManagement.RestApi.AzureFunction.Utils
{
    public static class RenderSwaggerUi
    {
        [FunctionName("fx-render-swagger-ui")]
        [OpenApiIgnore]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = "swagger/ui")] HttpRequest req,
            ILogger log)
        {
            

            var settings = new AppSettings();
            var ui = new SwaggerUI();
            var result = await ui.AddMetadata(settings.CurrentOpenApiInfo)
                                 .AddServer(req, settings.RoutePrefix)
                                 .BuildAsync()
                                 .RenderAsync("api/openapi/3.json", settings.SwaggerAuthKey)
                                 .ConfigureAwait(false);
            var response = new ContentResult()
            {
                Content = result,
                ContentType = "text/html",
                StatusCode = (int)HttpStatusCode.OK
            };

            return response;
        }
    }
}
