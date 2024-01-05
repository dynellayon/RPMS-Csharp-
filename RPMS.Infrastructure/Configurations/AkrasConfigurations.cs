using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RPMS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPMS.Infrastructure.Configurations
{
    public class AkrasConfigurations : IEntityTypeConfiguration<Akras>
    {
        public void Configure(EntityTypeBuilder<Akras> builder)
        {
            builder.HasData(
                new Akras
                {
                    Id = 1,
                    Name= "Content Knowledge and Pedagogy (PPST Domain 1)",
                }, new Akras
                {
                    Id = 2,
                    Name = "Learning Environment (PPST Domain 2)",
                }, new Akras
                {
                    Id = 3,
                    Name = "Learning Environment (PPST Domain 2) - continuation",
                }, new Akras
                {
                    Id = 4,
                    Name = "Diversity of Learners, Curriculum and Planning, & Assessment and Reporting\r\n(PPST Domains 3, 4, and 5)",
                }, new Akras
                {
                    Id = 5,
                    Name = "Community Linkages and Professional Engagement & Personal Growth and\r\nProfessional Development (PPST Domains 6 & 7)",
                }, new Akras
                {
                    Id = 6,
                    Name = "Plus Factor",
                }
                );
        }
    }
}
