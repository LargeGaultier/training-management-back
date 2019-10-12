using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using TrainingManagement.WebApi.Application.Ref.RefBlock.DTO;
using TrainingManagement.WebApi.Application.Ref.TrainingCenter.Queries;

namespace TrainingManagement.WebApi.Controllers.Ref
{
    public class BlocksController : BaseController
    {
        [HttpGet]
        [Route("api/v1/training-center/{id:int}/refblocks")]
        [ProducesResponseType(typeof(IEnumerable<RefBlockDTO>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetByTrainingCenterIdAsync(long id)
        {
            return Ok(await Mediator.Send(new GetAllRefBlockByTrainingCenterIdQuery() { trainingCenterId = id }));
        }
    }
}
