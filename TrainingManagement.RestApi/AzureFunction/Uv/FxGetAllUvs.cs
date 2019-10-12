using Aliencube.AzureFunctions.Extensions.OpenApi.Attributes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using System;
using System.Collections.Generic;
using System.Net;
using Microsoft.Extensions.Logging;
using System.Text;
using System.Threading.Tasks;
using TrainingManagement.RestApi.Persistence;
using Microsoft.EntityFrameworkCore;

namespace TrainingManagement.RestApi.AzureFunction.Uv
{
    public class FxGetAllUvs
    {
        private readonly TrainingManagementRefDbContext _trainingManagementDbContext;
        public FxGetAllUvs(TrainingManagementRefDbContext trainingManagementDbContext)
        {
            _trainingManagementDbContext = trainingManagementDbContext;
        }

        [FunctionName("fx-get-all-uvs")]
        [OpenApiOperation("Uvs", "Get")]
        [OpenApiResponseBody(HttpStatusCode.OK, "application/json", typeof(Domain.Ref.Ref_Uv))]
        public async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = "Uvs")] HttpRequest req,
            ILogger log)
        {
            var result = await _trainingManagementDbContext.Ref_Uv.ToListAsync();
            return (ActionResult)new OkObjectResult(result);
        }
    }
}
