using MediatR;
using Microsoft.AspNetCore.Mvc;
using RPMS.Application.DTOs.Auth;
using RPMS.Application.Features.Auth.Requests;
using RPMS.Application.ViewModel.Identity;
using System.ComponentModel.DataAnnotations;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RPMS.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IMediator _mediator;
        public LoginController(IMediator mediator)
        {
            _mediator = mediator;
        }
        // POST: api/<LoginController>
        [HttpPost("login")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult<AuthResponseDto>> Login(AuthRequest request)
        {
            var user = await _mediator.Send(new GetAuthRequest { Email=request.Email, Password=request.Password});

            return Ok(user);
        }




    }
}
