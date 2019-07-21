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
using System.Reflection;
using System.Net;

namespace TrainingManagement.RestApi.AzureFunction.Utils
{
    public static class RenderOpenApiDocument
    {
        [FunctionName("fx-render-open-api-document")]
        [OpenApiIgnore]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = "openapi/{version}.{extension}")] HttpRequest req,
            string version,
            string extension,
            ILogger log)
        {
            var settings = new AppSettings();
            
            var helper = new DocumentHelper(new Aliencube.AzureFunctions.Extensions.OpenApi.Configurations.RouteConstraintFilter());
            var document = new Document(helper);

            var result = await document.InitialiseDocument()
                                       .AddMetadata(settings.CurrentOpenApiInfo)
                                       .AddServer(req, settings.RoutePrefix)
                                       .Build(Assembly.GetExecutingAssembly())
                                       .RenderAsync(Microsoft.OpenApi.OpenApiSpecVersion.OpenApi3_0,Microsoft.OpenApi.OpenApiFormat.Json)
                                       .ConfigureAwait(false);
            var response = new ContentResult()
            {
                Content = result,
                ContentType = "application/json",
                StatusCode = (int)HttpStatusCode.OK
            };

            return response;
        }
    }
}
