using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using TrainingManagement.WebApi.Application.Ref.DTO;

namespace TrainingManagement.WebApi.Controllers.Ref
{
    public class DegreesController : BaseController
    {
        [HttpGet]
        [Route("api/v1/training-center/{idTrainingCenter:int}/RefDegrees")]
        [ProducesResponseType(typeof(IEnumerable<RefDegreeDTO>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetByTrainingCenterIdAsync(long idTrainingCenter)
        {
            return Ok(RefDegreeDTO.GetMock());
            //  return Ok(await Mediator.Send(new GetAllRefBlockByTrainingCenterIdQuery() { trainingCenterId = id }));
        }
    }
}
