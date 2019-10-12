using MediatR;
using Microsoft.AspNetCore.Mvc;


namespace TrainingManagement.WebApi.Controllers
{
    [ApiController]
    public abstract class BaseController : Controller
    {
        private IMediator _mediator;

        protected IMediator Mediator => _mediator ?? (_mediator = (IMediator)HttpContext.RequestServices.GetService(typeof(IMediator)));
    }
}
