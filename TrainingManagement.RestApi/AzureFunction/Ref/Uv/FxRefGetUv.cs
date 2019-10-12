using Aliencube.AzureFunctions.Extensions.OpenApi.Attributes;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using TrainingManagement.RestApi.Application.Ref.RefBlock.DTO;


namespace TrainingManagement.RestApi.AzureFunction.Ref.RefUv
{
    public class FxRefGetUv : BaseAzureFunction
    {
        
        public FxRefGetUv(IMediator mediator) : base(mediator)
        {

        }
        [FunctionName("FxRefGetUv")]
        [OpenApiOperation("GetRefBlocks", "RefBlocks")]
        [OpenApiResponseBody(HttpStatusCode.OK, "application/json", typeof(RefBlockDTO))]
        public async Task<JsonResult> Run(
           [HttpTrigger(AuthorizationLevel.Function, "get", Route = "V1/training-center/{id:int}/RefBlocks")] HttpRequest req,
           int id,
           ILogger log)
        {
            try
            {
                return new JsonResult(RefBlockDTO.GetMock(id));
            }
            catch (Exception ex)
            {
                log.LogError(ex.ToString());
                return new JsonResult(ex);
            }
        }
    }
}

