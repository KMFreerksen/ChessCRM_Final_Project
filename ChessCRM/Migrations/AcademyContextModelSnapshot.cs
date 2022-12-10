﻿// <auto-generated />
using System;
using ChessCRM.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ChessCRM.Migrations
{
    [DbContext(typeof(AcademyContext))]
    partial class AcademyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.31")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ChessCRM.Models.Contact", b =>
                {
                    b.Property<int>("ContactID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FamilyID")
                        .HasColumnType("int");

                    b.Property<string>("Fname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SchoolID")
                        .HasColumnType("int");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StreetAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Zip")
                        .HasColumnType("int");

                    b.HasKey("ContactID");

                    b.ToTable("Contacts");

                    b.HasData(
                        new
                        {
                            ContactID = 100000001,
                            FamilyID = 600000001,
                            Fname = "Parent",
                            Lname = "One",
                            SchoolID = 0,
                            Zip = 0
                        },
                        new
                        {
                            ContactID = 100000002,
                            FamilyID = 600000001,
                            Fname = "Parent",
                            Lname = "Two",
                            SchoolID = 0,
                            Zip = 0
                        },
                        new
                        {
                            ContactID = 100000003,
                            FamilyID = 600000002,
                            Fname = "Parent",
                            Lname = "Three",
                            SchoolID = 0,
                            Zip = 0
                        },
                        new
                        {
                            ContactID = 100000004,
                            FamilyID = 600000002,
                            Fname = "Parent",
                            Lname = "Four",
                            SchoolID = 0,
                            Zip = 0
                        },
                        new
                        {
                            ContactID = 100000005,
                            FamilyID = 600000003,
                            Fname = "Parent",
                            Lname = "Five",
                            SchoolID = 0,
                            Zip = 0
                        },
                        new
                        {
                            ContactID = 100000006,
                            FamilyID = 600000003,
                            Fname = "Parent",
                            Lname = "Six",
                            SchoolID = 0,
                            Zip = 0
                        },
                        new
                        {
                            ContactID = 100000007,
                            FamilyID = 600000004,
                            Fname = "Parent",
                            Lname = "Seven",
                            SchoolID = 0,
                            Zip = 0
                        },
                        new
                        {
                            ContactID = 100000008,
                            FamilyID = 600000004,
                            Fname = "Parent",
                            Lname = "Eight",
                            SchoolID = 0,
                            Zip = 0
                        },
                        new
                        {
                            ContactID = 100000009,
                            FamilyID = 600000005,
                            Fname = "Parent",
                            Lname = "Nine",
                            SchoolID = 0,
                            Zip = 0
                        });
                });

            modelBuilder.Entity("ChessCRM.Models.Product", b =>
                {
                    b.Property<int>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("BasePrice")
                        .HasColumnType("float");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MaxCapacity")
                        .HasColumnType("int");

                    b.Property<string>("ProductName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StreetAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Zip")
                        .HasColumnType("int");

                    b.HasKey("ProductID");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductID = 1001,
                            BasePrice = 0.0,
                            EndDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Location = "Sample Elementary School",
                            MaxCapacity = 0,
                            ProductName = "Sample Club",
                            StartDateTime = new DateTime(2022, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = "club",
                            Zip = 0
                        },
                        new
                        {
                            ProductID = 1002,
                            BasePrice = 0.0,
                            EndDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Location = "Sample Middle School",
                            MaxCapacity = 0,
                            ProductName = "Sample Class",
                            StartDateTime = new DateTime(2022, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = "class",
                            Zip = 0
                        },
                        new
                        {
                            ProductID = 1003,
                            BasePrice = 0.0,
                            EndDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Location = "Sample High School",
                            MaxCapacity = 0,
                            ProductName = "Sample Lesson",
                            StartDateTime = new DateTime(2022, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = "lesson",
                            Zip = 0
                        });
                });

            modelBuilder.Entity("ChessCRM.Models.Registration", b =>
                {
                    b.Property<int>("RegistrationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("ActualPaid")
                        .HasColumnType("float");

                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.Property<DateTime>("RegistrationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("StudentID")
                        .HasColumnType("int");

                    b.HasKey("RegistrationID");

                    b.ToTable("Registrations");

                    b.HasData(
                        new
                        {
                            RegistrationID = 100001,
                            ActualPaid = 90.0,
                            ProductID = 1001,
                            RegistrationDate = new DateTime(2022, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            StudentID = 900000001
                        },
                        new
                        {
                            RegistrationID = 100002,
                            ActualPaid = 210.0,
                            ProductID = 1002,
                            RegistrationDate = new DateTime(2022, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            StudentID = 900000001
                        },
                        new
                        {
                            RegistrationID = 100003,
                            ActualPaid = 90.0,
                            ProductID = 1001,
                            RegistrationDate = new DateTime(2022, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            StudentID = 900000002
                        },
                        new
                        {
                            RegistrationID = 100004,
                            ActualPaid = 450.0,
                            ProductID = 1003,
                            RegistrationDate = new DateTime(2022, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            StudentID = 900000002
                        },
                        new
                        {
                            RegistrationID = 100005,
                            ActualPaid = 90.0,
                            ProductID = 1001,
                            RegistrationDate = new DateTime(2022, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            StudentID = 900000003
                        },
                        new
                        {
                            RegistrationID = 100006,
                            ActualPaid = 210.0,
                            ProductID = 1002,
                            RegistrationDate = new DateTime(2022, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            StudentID = 900000003
                        },
                        new
                        {
                            RegistrationID = 100007,
                            ActualPaid = 90.0,
                            ProductID = 1001,
                            RegistrationDate = new DateTime(2022, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            StudentID = 900000004
                        },
                        new
                        {
                            RegistrationID = 100008,
                            ActualPaid = 450.0,
                            ProductID = 1003,
                            RegistrationDate = new DateTime(2022, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            StudentID = 900000005
                        },
                        new
                        {
                            RegistrationID = 100009,
                            ActualPaid = 210.0,
                            ProductID = 1002,
                            RegistrationDate = new DateTime(2022, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            StudentID = 900000006
                        },
                        new
                        {
                            RegistrationID = 100010,
                            ActualPaid = 90.0,
                            ProductID = 1001,
                            RegistrationDate = new DateTime(2022, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            StudentID = 900000006
                        },
                        new
                        {
                            RegistrationID = 100011,
                            ActualPaid = 450.0,
                            ProductID = 1003,
                            RegistrationDate = new DateTime(2022, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            StudentID = 900000006
                        });
                });

            modelBuilder.Entity("ChessCRM.Models.School", b =>
                {
                    b.Property<int>("SchoolID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("District")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SchoolName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StreetAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Zip")
                        .HasColumnType("int");

                    b.HasKey("SchoolID");

                    b.ToTable("Schools");

                    b.HasData(
                        new
                        {
                            SchoolID = 300001,
                            City = "Whoville",
                            District = "Whoville CSD",
                            Phone = "555-555-5555",
                            SchoolName = "Sample Elementary School",
                            State = "IA",
                            StreetAddress = "123 Elementary Dr",
                            Type = "elem",
                            Zip = 55555
                        },
                        new
                        {
                            SchoolID = 300002,
                            City = "Whoville",
                            District = "Whoville CSD",
                            Phone = "555-555-5555",
                            SchoolName = "Sample Middle School",
                            State = "IA",
                            StreetAddress = "123 Middle Ave",
                            Type = "midl",
                            Zip = 55555
                        },
                        new
                        {
                            SchoolID = 300003,
                            City = "Whoville",
                            District = "Whoville CSD",
                            Phone = "555-555-5555",
                            SchoolName = "Sample High School",
                            State = "IA",
                            StreetAddress = "123 High St",
                            Type = "high",
                            Zip = 55555
                        });
                });

            modelBuilder.Entity("ChessCRM.Models.Student", b =>
                {
                    b.Property<int>("StudentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Dob")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FamilyID")
                        .HasColumnType("int");

                    b.Property<string>("Fname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SchoolID")
                        .HasColumnType("int");

                    b.Property<string>("Skill")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UschessID")
                        .HasColumnType("int");

                    b.HasKey("StudentID");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            StudentID = 900000001,
                            Active = true,
                            Dob = new DateTime(2013, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "misc@email.com",
                            FamilyID = 600000001,
                            Fname = "Student",
                            Gender = "Female",
                            Lname = "One",
                            Phone = "555-555-5555",
                            SchoolID = 300001,
                            Skill = "white",
                            UschessID = 12345678
                        },
                        new
                        {
                            StudentID = 900000002,
                            Active = false,
                            Dob = new DateTime(2010, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "misc@email.com",
                            FamilyID = 600000002,
                            Fname = "Student",
                            Gender = "Male",
                            Lname = "Two",
                            Phone = "555-555-5555",
                            SchoolID = 300001,
                            Skill = "white",
                            UschessID = 12345679
                        },
                        new
                        {
                            StudentID = 900000003,
                            Active = true,
                            Dob = new DateTime(2008, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "misc@email.com",
                            FamilyID = 600000001,
                            Fname = "Student",
                            Gender = "Nonbinary",
                            Lname = "Three",
                            Phone = "555-555-5555",
                            SchoolID = 300002,
                            Skill = "white",
                            UschessID = 12345680
                        },
                        new
                        {
                            StudentID = 900000004,
                            Active = false,
                            Dob = new DateTime(2007, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "misc@email.com",
                            FamilyID = 600000003,
                            Fname = "Student",
                            Gender = "NA",
                            Lname = "Four",
                            Phone = "555-555-5555",
                            SchoolID = 300002,
                            Skill = "white",
                            UschessID = 12345681
                        },
                        new
                        {
                            StudentID = 900000005,
                            Active = false,
                            Dob = new DateTime(2004, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "misc@email.com",
                            FamilyID = 600000004,
                            Fname = "Student",
                            Gender = "Female",
                            Lname = "Five",
                            Phone = "555-555-5555",
                            SchoolID = 300003,
                            Skill = "white",
                            UschessID = 12345682
                        },
                        new
                        {
                            StudentID = 900000006,
                            Active = true,
                            Dob = new DateTime(2002, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "misc@email.com",
                            FamilyID = 600000005,
                            Fname = "Student",
                            Gender = "NA",
                            Lname = "Four",
                            Phone = "555-555-5555",
                            SchoolID = 300003,
                            Skill = "white",
                            UschessID = 12345683
                        });
                });

            modelBuilder.Entity("ChessCRM.Models.StudentContact", b =>
                {
                    b.Property<int>("StudentID")
                        .HasColumnType("int");

                    b.Property<int>("ContactID")
                        .HasColumnType("int");

                    b.Property<int>("FamilyID")
                        .HasColumnType("int");

                    b.HasKey("StudentID", "ContactID");

                    b.HasIndex("ContactID");

                    b.ToTable("StudentContact");
                });

            modelBuilder.Entity("ChessCRM.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

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
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
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

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
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

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("ChessCRM.Models.StudentContact", b =>
                {
                    b.HasOne("ChessCRM.Models.Contact", "Contact")
                        .WithMany("StudentContacts")
                        .HasForeignKey("ContactID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ChessCRM.Models.Student", "Student")
                        .WithMany("StudentContacts")
                        .HasForeignKey("StudentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
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
                    b.HasOne("ChessCRM.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("ChessCRM.Models.User", null)
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

                    b.HasOne("ChessCRM.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("ChessCRM.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
