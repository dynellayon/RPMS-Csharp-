using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPMS.Domain
{
    public class ApplicationUser :IdentityUser
    {
        public string EmployeeID { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string MiddleName { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string Image { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string Birthday { get; set; } = string.Empty;
        public bool IsDeleted { get; set; }=false;
        public DateTime DateCreated { get; set; }
        public string? CreatedBy { get; set; } = string.Empty;
        public DateTime LastModifiedDate { get; set; }
        public string LastModifiedBy { get; set; } = string.Empty;

    }
}
