using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using RPMS.Application.DTOs.Users;
using RPMS.Application.Features.Users.Requests.Queries;
using RPMS.Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPMS.Application.Features.Users.Handlers.Queries
{
    public class GetUserListRequestHandler : IRequestHandler<GetUserListRequest, IQueryable<UserDto>>
    {
        private readonly UserManager<ApplicationUser> _userManager;
        public GetUserListRequestHandler(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }
        public async Task<IQueryable<UserDto>> Handle(GetUserListRequest request, CancellationToken cancellationToken)
        {
            var users = await _userManager.Users.ToListAsync(cancellationToken);
            var userList = users.Select(p => new UserDto
            {
                Id = p.Id,
                UserName=p.UserName,
                Email=p.Email,  
                FirstName=p.FirstName,
                LastName=p.LastName,    
                Address=p.Address,
                City=p.City,
                Image=p.Image,
                MiddleName  =p.MiddleName,
                Birthday=p.Birthday,
                EmployeeID=p.EmployeeID,
                Role = string.Join(",", _userManager.GetRolesAsync(p).Result.ToArray()),

            });
;
            return userList.AsQueryable();
        }
    }
}
