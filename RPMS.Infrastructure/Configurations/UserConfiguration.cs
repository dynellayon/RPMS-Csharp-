using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using RPMS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPMS.Infrastructure.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            var hasher = new PasswordHasher<ApplicationUser>();
            builder.HasData(
                 new ApplicationUser
                 {
                     Id = "8e445865-a24d-4543-a6c6-9443d048cdb9",
                     Email = "admin@gmail.com",
                     EmployeeID = "none",
                     NormalizedEmail = "ADMIN@GMAIL.COM",
                     FirstName = "System",
                     LastName = "Admin",
                     UserName = "admin@gmail.com",
                     MiddleName = "System",
                     Image = "none",
                     Address = "none",
                     IsDeleted = false,
                     City = "none",
                     Birthday = "none",
                     NormalizedUserName = "ADMIN@GMAIL.COM",
                     PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                     EmailConfirmed = true
                 },
                 new ApplicationUser
                 {
                     Id = "9e224968-33e4-4652-b7b7-8574d048cdb9",
                     Email = "user@gmail.com",
                     EmployeeID="none",
                     NormalizedEmail = "USER@GMAIL.COM",
                     FirstName = "System",
                     LastName = "User",
                     MiddleName = "System",
                     Image = "none",
                     Address = "none",
                     IsDeleted = false,
                     City = "none",
                     Birthday = "none",
                     UserName = "user@gmail.com",
                     NormalizedUserName = "USER@GMAIL.COM",
                     PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                     EmailConfirmed = true
                 }
            );
        }
    }
}
