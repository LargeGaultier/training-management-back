using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using TrainingManagement.RestApi.Persistence;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Aliencube.AzureFunctions.Extensions.OpenApi.Attributes;
using System.Net;

namespace TrainingManagement.RestApi.AzureFunction.Student
{
    public  class FxGetAllStudents
    {
        private readonly TrainingManagementDbContext _trainingManagementDbContext;
        public FxGetAllStudents(TrainingManagementDbContext trainingManagementDbContext)
        {
            _trainingManagementDbContext = trainingManagementDbContext;
        }

        [FunctionName("fx-get-all-students")]
        [OpenApiOperation("Students", "Get")]
        [OpenApiResponseBody(HttpStatusCode.OK, "application/json", typeof(Domain.Student))]
        public async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = "Students")] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");
            var result = await _trainingManagementDbContext.Students.ToListAsync();
            return (ActionResult)new OkObjectResult(result);
                
        }
    }
}
