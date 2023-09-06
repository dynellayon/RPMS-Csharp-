using MediatR;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RPMS.Application.DTOs.Users;
using RPMS.Application.Features.Users.Requests.Command;
using RPMS.Application.Responses;
using RPMS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
#nullable disable
namespace RPMS.Application.Features.Users.Handlers.Commands
{
    public class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommand, BaseCommandResponse<string>>
    {
        private readonly UserManager<ApplicationUser> _userManager;
    
        public UpdateUserCommandHandler(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
   
        }
        public async Task<BaseCommandResponse<string>> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
            var user = await _userManager.FindByIdAsync(request.UserId);
            if (user is null)
            {
                return new BaseCommandResponse<string>()
                {
                    Message ="User Not Found",
                    StatusCode = HttpStatusCode.NotFound

                };
            }
            user.EmployeeID = request.UpdateUserDto.EmployeeID;
            user.FirstName = request.UpdateUserDto.FirstName;
            user.LastName = request.UpdateUserDto.LastName;
            user.Email = request.UpdateUserDto.Email;
            user.MiddleName = request.UpdateUserDto.MiddleName;
            user.PhoneNumber = request.UpdateUserDto.PhoneNumber;
            user.UserName = request.UpdateUserDto.UserName;
            user.Address = request.UpdateUserDto.Address;
            user.Birthday = request.UpdateUserDto.Birthday;
            user.City = request.UpdateUserDto.City;
            

            var result = await _userManager.UpdateAsync(user);
            if (result.Succeeded)
            {

                return new BaseCommandResponse<string>()
                {
                    Message = "User Successfully Updated",
                    StatusCode = HttpStatusCode.OK
                };
            }
            else
            {
                // Handle errors from result.Errors
                foreach (var error in result.Errors)
                {
                    return new BaseCommandResponse<string>()
                    {
                        Message = user.EmployeeID,
                        StatusCode = HttpStatusCode.OK,
                        ValidationError=error
                       
                    };
                }
            }
            return new BaseCommandResponse<string>()
            {
                Message = "Unsuccessfull",
                StatusCode = HttpStatusCode.BadRequest

            };
        


    
        }
    }
}
