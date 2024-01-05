﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RPMS.Infrastructure;

#nullable disable

namespace RPMS.Infrastructure.Migrations
{
    [DbContext(typeof(RpmsDbContext))]
    partial class RpmsDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                            ConcurrencyStamp = "9bc728d7-967a-4707-b28c-86da63d95d07",
                            Name = "Employee",
                            NormalizedName = "EMPLOYEE"
                        },
                        new
                        {
                            Id = "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                            ConcurrencyStamp = "9b51b624-dbab-4953-9b03-1374b5761cee",
                            Name = "Administrator",
                            NormalizedName = "ADMINISTRATOR"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "8e445865-a24d-4543-a6c6-9443d048cdb9",
                            RoleId = "cbc43a8e-f7bb-4445-baaf-1add431ffbbf"
                        },
                        new
                        {
                            UserId = "9e224968-33e4-4652-b7b7-8574d048cdb9",
                            RoleId = "cac43a6e-f7bb-4448-baaf-1add431ccbbf"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("RPMS.Domain.Akras", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Akras");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Content Knowledge and Pedagogy (PPST Domain 1)"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Learning Environment (PPST Domain 2)"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Learning Environment (PPST Domain 2) - continuation"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Diversity of Learners, Curriculum and Planning, & Assessment and Reporting\r\n(PPST Domains 3, 4, and 5)"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Community Linkages and Professional Engagement & Personal Growth and\r\nProfessional Development (PPST Domains 6 & 7)"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Plus Factor"
                        });
                });

            modelBuilder.Entity("RPMS.Domain.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Birthday")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("EmployeeID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastModifiedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("MiddleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "8e445865-a24d-4543-a6c6-9443d048cdb9",
                            AccessFailedCount = 0,
                            Address = "none",
                            Birthday = "none",
                            City = "none",
                            ConcurrencyStamp = "85258a4c-a820-4672-bb52-917a4081cd8c",
                            CreatedBy = "",
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "admin@gmail.com",
                            EmailConfirmed = true,
                            EmployeeID = "none",
                            FirstName = "System",
                            Image = "none",
                            IsDeleted = false,
                            LastModifiedBy = "",
                            LastModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "Admin",
                            LockoutEnabled = false,
                            MiddleName = "System",
                            NormalizedEmail = "ADMIN@GMAIL.COM",
                            NormalizedUserName = "ADMIN@GMAIL.COM",
                            Password = "",
                            PasswordHash = "AQAAAAEAACcQAAAAELmIlJcHWEnKV3/sSQI9H1vn7xKhyZRso//mAF/lQA8pb4vNNt97ug37v6Gkc63xNw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "78f8f8e6-c5b2-4a61-ae4b-bbe174ab78e2",
                            TwoFactorEnabled = false,
                            UserName = "admin@gmail.com"
                        },
                        new
                        {
                            Id = "9e224968-33e4-4652-b7b7-8574d048cdb9",
                            AccessFailedCount = 0,
                            Address = "none",
                            Birthday = "none",
                            City = "none",
                            ConcurrencyStamp = "12ea9be9-58b9-46b1-8f7e-a31c156a24f1",
                            CreatedBy = "",
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "user@gmail.com",
                            EmailConfirmed = true,
                            EmployeeID = "none",
                            FirstName = "System",
                            Image = "none",
                            IsDeleted = false,
                            LastModifiedBy = "",
                            LastModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "User",
                            LockoutEnabled = false,
                            MiddleName = "System",
                            NormalizedEmail = "USER@GMAIL.COM",
                            NormalizedUserName = "USER@GMAIL.COM",
                            Password = "",
                            PasswordHash = "AQAAAAEAACcQAAAAEEL5eAf3mItuiLqJY+qOBiy5YkmZeropwCPngNZsTGfk0nQuqDAel+h6BLb3T81o8Q==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "b6fa3e3e-a071-4f46-8708-55bb22c0d00d",
                            TwoFactorEnabled = false,
                            UserName = "user@gmail.com"
                        });
                });

            modelBuilder.Entity("RPMS.Domain.Position", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("PositionName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PositionType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Positions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            PositionName = "Teacher I",
                            PositionType = "Proficient Teacher"
                        },
                        new
                        {
                            Id = 2,
                            PositionName = "Teacher II",
                            PositionType = "Proficient Teacher"
                        },
                        new
                        {
                            Id = 3,
                            PositionName = "Teacher III",
                            PositionType = "Proficient Teacher"
                        },
                        new
                        {
                            Id = 4,
                            PositionName = "SPET I",
                            PositionType = "Proficient Teacher"
                        },
                        new
                        {
                            Id = 5,
                            PositionName = "SPET II",
                            PositionType = "Proficient Teacher"
                        },
                        new
                        {
                            Id = 6,
                            PositionName = "SPET III",
                            PositionType = "Proficient Teacher"
                        },
                        new
                        {
                            Id = 7,
                            PositionName = "SPET IV",
                            PositionType = "Proficient Teacher"
                        },
                        new
                        {
                            Id = 8,
                            PositionName = "SPET V",
                            PositionType = "Proficient Teacher"
                        },
                        new
                        {
                            Id = 9,
                            PositionName = "INSTRUCTOR I",
                            PositionType = "Proficient Teacher"
                        },
                        new
                        {
                            Id = 10,
                            PositionName = "INSTRUCTOR II",
                            PositionType = "Proficient Teacher"
                        },
                        new
                        {
                            Id = 11,
                            PositionName = "Special Science Teacher I",
                            PositionType = "Proficient Teacher"
                        },
                        new
                        {
                            Id = 12,
                            PositionName = "Special Science Teacher II",
                            PositionType = "Proficient Teacher"
                        },
                        new
                        {
                            Id = 13,
                            PositionName = "Special Science Teacher III",
                            PositionType = "Proficient Teacher"
                        },
                        new
                        {
                            Id = 14,
                            PositionName = "Special Science Teacher IV",
                            PositionType = "Proficient Teacher"
                        },
                        new
                        {
                            Id = 15,
                            PositionName = "Special Science Teacher V",
                            PositionType = "Proficient Teacher"
                        },
                        new
                        {
                            Id = 16,
                            PositionName = "Master Teacher I",
                            PositionType = "High Proficient Teacher"
                        },
                        new
                        {
                            Id = 17,
                            PositionName = "Master Teacher II",
                            PositionType = "High Proficient Teacher"
                        },
                        new
                        {
                            Id = 18,
                            PositionName = "Master Teacher III",
                            PositionType = "High Proficient Teacher"
                        },
                        new
                        {
                            Id = 19,
                            PositionName = "Master Teacher IV",
                            PositionType = "High Proficient Teacher"
                        },
                        new
                        {
                            Id = 20,
                            PositionName = "Master Teacher V",
                            PositionType = "High Proficient Teacher"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("RPMS.Domain.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("RPMS.Domain.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RPMS.Domain.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("RPMS.Domain.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
