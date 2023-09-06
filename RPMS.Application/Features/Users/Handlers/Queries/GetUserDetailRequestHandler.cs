using MediatR;
using Microsoft.AspNetCore.Identity;
using RPMS.Application.DTOs.Users;
using RPMS.Application.Features.Users.Requests.Queries;
using RPMS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace RPMS.Application.Features.Users.Handlers.Queries
{
    public class GetUserDetailRequestHandler : IRequestHandler<GetUserDetailRequest, GetUserDto>
    {
        private readonly UserManager<ApplicationUser> _userManager;
        public GetUserDetailRequestHandler(UserManager<ApplicationUser> userManager) 
        {
            _userManager = userManager;
        }
        public async Task<GetUserDto> Handle(GetUserDetailRequest request, CancellationToken cancellationToken)
        {
           var user =await _userManager.FindByIdAsync(request.UserId);
            if (user == null)
            {
                return new GetUserDto
                {
                    Status = HttpStatusCode.NotFound,
                    Message = "User not Found"
                };
            }

            return new GetUserDto
            {
                Status = HttpStatusCode.OK,
                FirstName=user.FirstName,
                MiddleName = user.MiddleName,
                LastName =user.LastName,  
                Address=user.Address,
                Birthday=user.Birthday,
                City=user.City,
                Email=user.Email,
                Image=user.Image,
                EmployeeID=user.EmployeeID,
                
            };

        }
    }
}
