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
using System.Linq;
using Microsoft.OpenApi.Models;

namespace TrainingManagement.RestApi.AzureFunction.Uv
{
    public class FxGetUvById
    {
        private readonly TrainingManagementRefDbContext _trainingManagementDbContext;
        public FxGetUvById(TrainingManagementRefDbContext trainingManagementDbContext)
        {
            _trainingManagementDbContext = trainingManagementDbContext;
        }

        [FunctionName("fx-get-uv-by-id")]
        [OpenApiOperation("Uv", "GetById")]
        [OpenApiParameter("id", In = ParameterLocation.Query, Required = false ,Type = typeof(int))]
        [OpenApiResponseBody(HttpStatusCode.OK, "application/json", typeof(Domain.Ref.Uv))]
        public async Task<IActionResult> Run([FromRoute]int id,
            ILogger log)
        {
            var result = await _trainingManagementDbContext.Uv.FirstOrDefaultAsync(e=>e.Id==id);
            return (ActionResult)new OkObjectResult(result);
        }
    }
}
