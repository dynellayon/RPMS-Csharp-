using MediatR;
using Microsoft.AspNetCore.Identity;
using RPMS.Application.Features.Users.Requests.Command;
using RPMS.Application.Responses;
using RPMS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace RPMS.Application.Features.Users.Handlers.Commands
{
    public class DeleteUserCommandHandler : IRequestHandler<DeleteUserCommand, BaseCommandResponse<string>>
    {
        private readonly UserManager<ApplicationUser> _userManager;
        public DeleteUserCommandHandler(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }
        public async Task<BaseCommandResponse<string>> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
        {
            var deleteuser = await _userManager.FindByIdAsync(request.UserId);
            if (deleteuser == null)
            {
                return new BaseCommandResponse<string>()
                {
                    Message="User not found",
                    StatusCode=HttpStatusCode.NotFound
                };
            }
            await _userManager.DeleteAsync(deleteuser);
            return new BaseCommandResponse<string>()
            {
                Message="User Successfully Deleted",
                StatusCode=HttpStatusCode.OK
            };
        }
    }
}
