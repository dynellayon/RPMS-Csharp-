using MediatR;
using RPMS.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPMS.Application.Features.Users.Requests.Command
{
    public class DeleteUserCommand : IRequest<BaseCommandResponse<string>>
    {
        public string? UserId { get; set; }
    }
}
