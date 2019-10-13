using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using TrainingManagement.WebApi.Application.Ref.DTO;
using TrainingManagement.WebApi.Application.Ref.TrainingCenter.Queries;

namespace TrainingManagement.WebApi.Controllers.Ref
{
    public class BlocksController : BaseController
    {
        [HttpGet]
        [Route("api/v1/training-center/{idTrainingCenter:int}/refblocks")]
        [ProducesResponseType(typeof(IEnumerable<RefBlockDTO>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetByTrainingCenterIdAsync(long idTrainingCenter)
        {
            return Ok(RefBlockDTO.GetMock(1));
            //  return Ok(await Mediator.Send(new GetAllRefBlockByTrainingCenterIdQuery() { trainingCenterId = id }));
        }

        [HttpPost]
        [Route("api/v1/training-center/{idTrainingCenter:int}/refblock")]
        [ProducesResponseType(typeof(long), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> CreateRefBlockAsync(long idTrainingCenter, [FromBody] RefBlockDTO refBlockDTO)
        {
            return Ok(1);
            //  return Ok(await Mediator.Send(new GetAllRefBlockByTrainingCenterIdQuery() { trainingCenterId = id }));
        }

        [HttpPut]
        [Route("api/v1/training-center/{idTrainingCenter:int}/refblock/{idBlock:int}")]
        [ProducesResponseType(typeof(RefBlockDTO), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> UpdateRefBlockAsync(long idTraningCenter, long idBlock,[FromBody] RefBlockDTO refBlockDTO)
        {
            return Ok(refBlockDTO);
            //  return Ok(await Mediator.Send(new GetAllRefBlockByTrainingCenterIdQuery() { trainingCenterId = id }));
        }
    }
}
