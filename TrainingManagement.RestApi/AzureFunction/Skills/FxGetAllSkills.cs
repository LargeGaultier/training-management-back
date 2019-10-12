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
    public class FxGetAllSkills
    {
        private readonly TrainingManagementRefDbContext _trainingManagementDbContext;
        public FxGetAllSkills(TrainingManagementRefDbContext trainingManagementDbContext)
        {
            _trainingManagementDbContext = trainingManagementDbContext;
        }

        [FunctionName("fx-get-all-skills")]
        [OpenApiOperation("Skills", "Get")]
        [OpenApiResponseBody(HttpStatusCode.OK, "application/json", typeof(Domain.Ref.Ref_Skill))]
        public async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = "Skills")] HttpRequest req,
            ILogger log)
        {
            var result = await _trainingManagementDbContext.Ref_UeSkill.ToListAsync();
            return (ActionResult)new OkObjectResult(result);
        }
    }
}
