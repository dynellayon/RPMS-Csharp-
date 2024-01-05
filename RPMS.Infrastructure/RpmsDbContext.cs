using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RPMS.Domain;
using RPMS.Domain.Common;
using RPMS.Infrastructure.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace RPMS.Infrastructure
{
    public class RpmsDbContext:IdentityDbContext<ApplicationUser>
    {
        public RpmsDbContext(DbContextOptions<RpmsDbContext> options) : base(options) { }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Akras>()
                 .HasMany(e => e.Objectives)
                 .WithOne(e => e.Akras)
                 .HasForeignKey(e => e.Kra)
                 .IsRequired();
            modelBuilder.Entity<Objectives>()
                 .HasMany(e => e.Performance)
                 .WithOne(e => e.Objectives)
                 .HasForeignKey(e => e.ObjectiveID)
                 .IsRequired();

            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new UserRoleConfiguration());
            modelBuilder.ApplyConfiguration(new PositionConfiguration());
            modelBuilder.ApplyConfiguration(new AkrasConfigurations());
        }
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            foreach (var entry in ChangeTracker.Entries<BaseDomainEntity>())
            {
                entry.Entity.LastModifiedDate = DateTime.Now;

                if (entry.State == EntityState.Added)
                {
                    entry.Entity.DateCreated = DateTime.Now;
                }
            }

            return base.SaveChangesAsync(cancellationToken);
        }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Akras> Akras { get; set; } 
    }
   
}
