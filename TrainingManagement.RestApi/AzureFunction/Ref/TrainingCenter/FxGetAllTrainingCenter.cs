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
        public  async Task<JsonResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get",  Route = "Training-Centers")] HttpRequest req,
            ILogger log)
        {
            try
            {

                return new JsonResult(await Mediator.Send(new GetAllTrainingCenterQuery()));

            }
            catch (Exception ex)
            {
                log.LogError(ex.ToString());
                return new JsonResult(ex);
            }  
        }
    }
}
