using MediatR;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using RPMS.Application.DTOs.Users;
using RPMS.Application.Features.Users.Requests.Command;
using RPMS.Application.Responses;
using RPMS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
#nullable disable
namespace RPMS.Application.Features.Users.Handlers.Commands
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, BaseCommandResponse<string>>
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IWebHostEnvironment _hostingEnv;
        public CreateUserCommandHandler(UserManager<ApplicationUser> userManager, IWebHostEnvironment hostingEnv)
        {
            _userManager = userManager;
            _hostingEnv = hostingEnv;
        }
        public async Task<BaseCommandResponse<string>> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            if (request == null)
            {
                return new BaseCommandResponse<string>()
                {
                    Message = "Empty values",
                    StatusCode = HttpStatusCode.BadRequest

                };
            }

            var existingUser = await _userManager.FindByNameAsync(request.CreateUserDto.UserName);

            if (existingUser != null)
            {
                return new BaseCommandResponse<string>()
                {
                    Message = $"Username '{request.CreateUserDto.UserName}' already exists.",
                    StatusCode = HttpStatusCode.BadRequest
                };
            }
            string FilePath = Path.Combine(_hostingEnv.WebRootPath, "Upload");

            if (!Directory.Exists(FilePath))
            {
                Directory.CreateDirectory(FilePath);
            }
            var fileName = request.CreateUserDto.LastName + request.CreateUserDto.Image.FileName;

            string filePath = Path.Combine(FilePath, fileName);
            var user = new ApplicationUser()
            {
                Email = request.CreateUserDto.Email,
                FirstName = request.CreateUserDto.FirstName,
                LastName = request.CreateUserDto.LastName,
                UserName = request.CreateUserDto.UserName,
                MiddleName = request.CreateUserDto.MiddleName,
                EmployeeID = request.CreateUserDto.EmployeeID,
                Address = request.CreateUserDto.Address,
                Birthday = request.CreateUserDto.Birthday,
                City = request.CreateUserDto.City,
                PhoneNumber = request.CreateUserDto.PhoneNumber,
                EmailConfirmed = true,
                Image = fileName
            };

            var existingEmail = await _userManager.FindByEmailAsync(request.CreateUserDto.Email);

            if (existingEmail == null)
            {

                var result = await _userManager.CreateAsync(user, request.CreateUserDto.Password);

                if (result.Succeeded)
                {
                    using (FileStream fs = File.Create(filePath))
                    {
                        request.CreateUserDto.Image.CopyTo(fs);
                    }
                    await _userManager.AddToRoleAsync(user, "Employee");
                    return new BaseCommandResponse<string>()
                    {
                        StatusCode = HttpStatusCode.OK,
                        Message = "Successfully Added",
                    };
                }
                else
                {
                    return new BaseCommandResponse<string>()
                    {
                        Message = "Invalid Request",
                        StatusCode = HttpStatusCode.BadRequest,
                        ValidationError = result.Errors.First(),
                    };
                }
            }
            else
            {
                return new BaseCommandResponse<string>()
                {
                    Message = $"Email {request.CreateUserDto.Email} already exists.",
                    StatusCode = HttpStatusCode.BadRequest

                };
            }

        }
    }
}
