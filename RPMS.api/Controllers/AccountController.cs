using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using RPMS.Application.DTOs.Users;
using RPMS.Application.Features.Users.Requests.Command;
using RPMS.Application.Features.Users.Requests.Queries;
using RPMS.Application.Responses;



// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RPMS.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IMediator _mediator;
        public AccountController(IMediator mediator)
        {
            _mediator = mediator;

        }
        // GET: api/<ValuesController>
        [HttpGet]
        public async Task<ActionResult<IQueryable<UserDto>>> GetAll()
        {
            var users = await _mediator.Send(new GetUserListRequest());
            return Ok(users);
        }   

        // GET api/<ValuesController>/5
        [HttpGet("{id}")] 
        public async Task<ActionResult<GetUserDto>> Get(string id)
        {

            var user = await _mediator.Send(new GetUserDetailRequest() { UserId = id });
            return Ok(user);
        }

        // POST api/<ValuesController>
        [HttpPost]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [Authorize(Roles = "Administrator")]
        public async Task<ActionResult<BaseCommandResponse<string>>> Post([FromForm] CreateUserDto createuserdto)
        {

            var command = new CreateUserCommand(){
                CreateUserDto = createuserdto
            };
            var repsonse = await _mediator.Send(command);
            return Ok(repsonse);
        }

        // PUT api/<ValuesController>/5
        [HttpPatch("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        [Authorize(Roles = "Administrator")]
        public async Task<ActionResult<BaseCommandResponse<string>>> Patch(string id, [FromBody] UpdateUserDto updateUserDto)
        {
            var command = new UpdateUserCommand()
            {
                UserId=id,
                UpdateUserDto= updateUserDto
            };
            var repsonse = await _mediator.Send(command);
            return Ok(repsonse);
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        [Authorize(Roles = "Administrator")]
        public async Task<ActionResult<BaseCommandResponse<string>>> Delete(string id)
        {
            var command = new DeleteUserCommand() { UserId = id };
            var repsonse = await _mediator.Send(command);
            return Ok(repsonse);
        }
    }
}
