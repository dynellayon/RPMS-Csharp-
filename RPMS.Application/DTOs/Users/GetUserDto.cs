using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace RPMS.Application.DTOs.Users
{
    public class GetUserDto
    {
        public string Id { get; set; }= string.Empty;
        public string EmployeeID { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string MiddleName { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string Image { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string Birthday { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public HttpStatusCode Status { get; set; }= HttpStatusCode.OK;
        public string Message { get; set; } = string.Empty;
    }
}
