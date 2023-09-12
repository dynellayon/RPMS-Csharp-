using MediatR;
using Microsoft.AspNetCore.Mvc;
using RPMS.Application.DTOs.Position;
using RPMS.Application.Features.Position.Requests.Queries;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RPMS.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PositionController : ControllerBase
    {
        private readonly IMediator _mediator;
        public PositionController(IMediator mediator)
        {
            _mediator = mediator;

        }
        // GET: api/<ValuesController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PositionDto>>> Get()
        {
            var position = await _mediator.Send(new GetPositionListRequest());

            return Ok(position);
        }

        
    }
}
