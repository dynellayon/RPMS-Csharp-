using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RPMS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPMS.Infrastructure.Configurations
{
    public class PositionConfiguration : IEntityTypeConfiguration<Position>
    {
        public void Configure(EntityTypeBuilder<Position> builder)
        {
            builder.HasData(
                new Position
                {
                    Id=1,
                    PositionName = "Teacher I",
                    PositionType="Proficient Teacher"
                }, new Position
                {
             Id = 2,
                    PositionName = "Teacher II",
                    PositionType = "Proficient Teacher"
                }, new Position
                {
                    Id = 3,
                    PositionName = "Teacher III",
                    PositionType = "Proficient Teacher"
                }, new Position
                {
                    Id = 4,
                    PositionName = "SPET I",
                    PositionType = "Proficient Teacher"
                }, new Position
                {
                    Id= 5,
                    PositionName = "SPET II",
                    PositionType = "Proficient Teacher"
                }, new Position
                {
                    Id = 6,
                    PositionName = "SPET III",
                    PositionType = "Proficient Teacher"
                }, new Position
                {
                    Id = 7,
                    PositionName = "SPET IV",
                    PositionType = "Proficient Teacher"
                }, new Position
                {
                    Id = 8,
                    PositionName = "SPET V",
                    PositionType = "Proficient Teacher"
                }, new Position
                {
                    Id = 9,
                    PositionName = "INSTRUCTOR I",
                    PositionType = "Proficient Teacher"
                }, new Position
                {
                    Id = 10,
                    PositionName = "INSTRUCTOR II",
                    PositionType = "Proficient Teacher"
                }, new Position
                {
                    Id = 11,
                    PositionName = "Special Science Teacher I",
                    PositionType = "Proficient Teacher"
                }, new Position
                {
                    Id = 12,
                    PositionName = "Special Science Teacher II",
                    PositionType = "Proficient Teacher"
                }, new Position
                {   
                    Id = 13,
                    PositionName = "Special Science Teacher III",
                    PositionType = "Proficient Teacher"
                }, new Position
                {
                    Id = 14,
                    PositionName = "Special Science Teacher IV",
                    PositionType = "Proficient Teacher"
                }, new Position
                {
                    Id = 15,
                    PositionName = "Special Science Teacher V",
                    PositionType = "Proficient Teacher"
                }, new Position
                {
                    Id= 16,
                    PositionName = "Master Teacher I",
                    PositionType = "High Proficient Teacher"
                }, new Position
                {
                    Id = 17,
                    PositionName = "Master Teacher II",
                    PositionType = "High Proficient Teacher"
                }, new Position
                {
                    Id = 18,
                    PositionName = "Master Teacher III",
                    PositionType = "High Proficient Teacher"
                }, new Position
                {
                    Id = 19,
                    PositionName = "Master Teacher IV",
                    PositionType = "High Proficient Teacher"
                }, new Position
                {
                    Id = 20,
                    PositionName = "Master Teacher V",
                    PositionType = "High Proficient Teacher"
                }

                );
        }
    }
}
