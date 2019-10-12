using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using TrainingManagement.RestApi.Application.Ref.RefBlock.DTO;

namespace TrainingManagement.WebApi.Controllers.Ref
{
    public class BlocksController : BaseController
    {
        [HttpGet]
        [Route("api/v1/training-center/{id:int}/refblocks")]
        [ProducesResponseType(typeof(IEnumerable<RefBlockDTO>), (int)HttpStatusCode.OK)]
        public IActionResult Get(long id)
        {
            return Ok(RefBlockDTO.GetMock(id));
        }
    }
}
