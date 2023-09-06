using MediatR;
using Microsoft.AspNetCore.JsonPatch;
using RPMS.Application.DTOs.Users;
using RPMS.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#nullable disable
namespace RPMS.Application.Features.Users.Requests.Command
{
    public class UpdateUserCommand:IRequest<BaseCommandResponse<string>>
    {
        public string UserId { get; set;}
        public UpdateUserDto UpdateUserDto { get; set;}
    }
}
