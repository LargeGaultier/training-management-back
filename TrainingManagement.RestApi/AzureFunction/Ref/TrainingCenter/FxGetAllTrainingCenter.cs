using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using MediatR;
using TrainingManagement.RestApi.Application.Ref.TrainingCenter.Queries;

namespace TrainingManagement.RestApi.AzureFunction.Ref.TrainingCenter
{
    public  class FxGetAllTrainingCenter : BaseAzureFunction
    {

        public FxGetAllTrainingCenter(IMediator mediator):base(mediator)
        {

        }

        [FunctionName("FxGetAllTrainingCenter")]
        public  async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get",  Route = "TrainingCenters")] HttpRequest req,
            ILogger log)
        {
            try
            {

                return (ActionResult)new OkObjectResult(await Mediator.Send(new GetAllTrainingCenterQuery()));

            }
            catch (Exception ex)
            {
                log.LogError(ex.ToString());
                return (ActionResult)new ObjectResult(ex);
            }  
        }
    }
}
