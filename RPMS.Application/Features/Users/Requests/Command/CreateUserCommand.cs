using MediatR;
using Microsoft.AspNetCore.Http;
using RPMS.Application.DTOs.Users;
using RPMS.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPMS.Application.Features.Users.Requests.Command
{
    public class CreateUserCommand :IRequest<BaseCommandResponse<string>>
    {
        public CreateUserDto? CreateUserDto { get; set; }
    }
}
