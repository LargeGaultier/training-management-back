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
    public class FxGetAllUes
    {
        private readonly TrainingManagementRefDbContext _trainingManagementDbContext;
        public FxGetAllUes(TrainingManagementRefDbContext trainingManagementDbContext)
        {
            _trainingManagementDbContext = trainingManagementDbContext;
        }

        [FunctionName("fx-get-all-ues")]
        [OpenApiOperation("Ues", "Get")]
        [OpenApiResponseBody(HttpStatusCode.OK, "application/json", typeof(Domain.Ref.Ref_Ue))]
        public async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = "Ues")] HttpRequest req,
            ILogger log)
        {
            var result = await _trainingManagementDbContext.Ref_Ue.ToListAsync();
            return (ActionResult)new OkObjectResult(result);
        }
    }
}
