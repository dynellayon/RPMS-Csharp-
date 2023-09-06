using MediatR;
using RPMS.Application.DTOs.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPMS.Application.Features.Users.Requests.Queries
{
    public class GetUserDetailRequest : IRequest<GetUserDto>
    {
        [Required]
        public string UserId { get; set; } = string.Empty;
    }
}
