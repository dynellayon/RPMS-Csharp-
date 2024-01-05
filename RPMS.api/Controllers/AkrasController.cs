using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RPMS.Application.Features.Akras.Requests;
using RPMS.Application.Features.Users.Requests.Queries;
using RPMS.Domain;

namespace RPMS.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AkrasController : ControllerBase
    {
        private readonly IMediator _mediator;
        public AkrasController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Akras>>> Get()
        {
            var akras= await _mediator.Send( new GetAkrasListRequest() );
            return Ok( akras );
        }
    }
}
