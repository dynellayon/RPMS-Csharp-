using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace RPMS.Application.DTOs.Users
{
    public class CreateUserDto
    {
        
        public string? EmployeeID { get; set; } 
        public string? FirstName { get; set; }
        public string? LastName { get; set; } 
        public string? MiddleName { get; set; } 
        public string? Address { get; set; }
        public IFormFile? Image { get; set; }
        public string? City { get; set; } 
        public string? Birthday { get; set; } 
        public string? Email { get; set; } 
        public string? UserName { get; set; } 
        public string? Role { get; set; } 
        public string? Password { get; set; }
        public string? PhoneNumber { get; set; } 


         
        


    }
}
