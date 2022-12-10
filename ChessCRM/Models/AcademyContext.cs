using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace ChessCRM.Models
{
    public class AcademyContext : IdentityDbContext<User>
    {
        public AcademyContext(DbContextOptions<AcademyContext> options) : base(options) { }

        public DbSet<Student> Students { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<School> Schools { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Registration> Registrations { get; set; }

        public static async Task CreateAdminUser(IServiceProvider serviceProvider)
        {
            UserManager<User> userManager = serviceProvider.GetRequiredService<UserManager<User>>();
            RoleManager<IdentityRole> roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();

            string username = "admin";
            string password = "adminPassword";
            string roleName = "Admin";

            if (await roleManager.FindByNameAsync(roleName) == null)
                await roleManager.CreateAsync(new IdentityRole(roleName));

            if (await userManager.FindByNameAsync(username) == null)
            {
                User user = new User { UserName = username };

                var result = await userManager.CreateAsync(user, password);

                if (result.Succeeded)
                    await userManager.AddToRoleAsync(user, roleName);
            }
        }

        public static async Task CreateViewOnlyUser(IServiceProvider serviceProvider)
        {
            UserManager<User> userManager = serviceProvider.GetRequiredService<UserManager<User>>();
            RoleManager<IdentityRole> roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();

            string username = "viewonly";
            string password = "viewOnly";
            string roleName = "ViewOnly";

            if (await roleManager.FindByNameAsync(roleName) == null)
                await roleManager.CreateAsync(new IdentityRole(roleName));

            if (await userManager.FindByNameAsync(username) == null)
            {
                User user = new User { UserName = username };

                var result = await userManager.CreateAsync(user, password);

                if (result.Succeeded)
                    await userManager.AddToRoleAsync(user, roleName);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().HasData(
                new Product { ProductID = 1001, ProductName = "Sample Club", Type = "club", Location = "Sample Elementary School", StartDateTime = new DateTime(2022, 12, 14) },
                new Product { ProductID = 1002, ProductName = "Sample Class", Type = "class", Location = "Sample Middle School", StartDateTime = new DateTime(2022, 12, 21) },
                new Product { ProductID = 1003, ProductName = "Sample Lesson", Type = "lesson", Location = "Sample High School", StartDateTime = new DateTime(2022, 12, 29) }
                );

            modelBuilder.Entity<Student>().HasData(
                new Student { StudentID = 900000001, Fname = "Student", Lname = "One", Gender = "Female", Dob = new DateTime(2013, 1, 24), Email = "misc@email.com", Phone = "555-555-5555", UschessID = 12345678, SchoolID = 300001, FamilyID = 600000001, Active = true, Skill = "white"},
                new Student { StudentID = 900000002, Fname = "Student", Lname = "Two", Gender = "Male", Dob = new DateTime(2010, 10, 3), Email = "misc@email.com", Phone = "555-555-5555", UschessID = 12345679, SchoolID = 300001, FamilyID = 600000002, Active = false, Skill = "white" },
                new Student { StudentID = 900000003, Fname = "Student", Lname = "Three", Gender = "Nonbinary", Dob = new DateTime(2008, 5, 30), Email = "misc@email.com", Phone = "555-555-5555", UschessID = 12345680, SchoolID = 300002, FamilyID = 600000001, Active = true, Skill = "white" },
                new Student { StudentID = 900000004, Fname = "Student", Lname = "Four", Gender = "NA", Dob = new DateTime(2007, 7, 13), Email = "misc@email.com", Phone = "555-555-5555", UschessID = 12345681, SchoolID = 300002, FamilyID = 600000003, Active = false, Skill = "white" },
                new Student { StudentID = 900000005, Fname = "Student", Lname = "Five", Gender = "Female", Dob = new DateTime(2004, 2, 18), Email = "misc@email.com", Phone = "555-555-5555", UschessID = 12345682, SchoolID = 300003, FamilyID = 600000004  , Active = false, Skill = "white" },
                new Student { StudentID = 900000006, Fname = "Student", Lname = "Six", Gender = "NA", Dob = new DateTime(2002, 12, 8), Email = "misc@email.com", Phone = "555-555-5555", UschessID = 12345683, SchoolID = 300003, FamilyID = 600000005, Active = true, Skill = "white" }
                );

            modelBuilder.Entity<School>().HasData(
                new School { SchoolID = 300001, SchoolName = "Sample Elementary School", District = "Whoville CSD", Type = "elem", StreetAddress = "123 Elementary Dr", City = "Whoville", State = "IA", Zip = 55555, Phone = "555-555-5555" },
                new School { SchoolID = 300002, SchoolName = "Sample Middle School", District = "Whoville CSD", Type = "midl", StreetAddress = "123 Middle Ave", City = "Whoville", State = "IA", Zip = 55555, Phone = "555-555-5555" },
                new School { SchoolID = 300003, SchoolName = "Sample High School", District = "Whoville CSD", Type = "high", StreetAddress = "123 High St", City = "Whoville", State = "IA", Zip = 55555, Phone = "555-555-5555" }
                );

            modelBuilder.Entity<Registration>().HasData(
                new Registration { RegistrationID = 100001, StudentID = 900000001, ProductID = 1001, RegistrationDate = new DateTime(2022, 11, 10), ActualPaid = 90.00 },
                new Registration { RegistrationID = 100002, StudentID = 900000001, ProductID = 1002, RegistrationDate = new DateTime(2022, 11, 10), ActualPaid = 210.00 },
                new Registration { RegistrationID = 100003, StudentID = 900000002, ProductID = 1001, RegistrationDate = new DateTime(2022, 11, 17), ActualPaid = 90.00 },
                new Registration { RegistrationID = 100004, StudentID = 900000002, ProductID = 1003, RegistrationDate = new DateTime(2022, 11, 17), ActualPaid = 450.00 },
                new Registration { RegistrationID = 100005, StudentID = 900000003, ProductID = 1001, RegistrationDate = new DateTime(2022, 11, 10), ActualPaid = 90.00 },
                new Registration { RegistrationID = 100006, StudentID = 900000003, ProductID = 1002, RegistrationDate = new DateTime(2022, 11, 10), ActualPaid = 210.00 },
                new Registration { RegistrationID = 100007, StudentID = 900000004, ProductID = 1001, RegistrationDate = new DateTime(2022, 11, 5), ActualPaid = 90.00 },
                new Registration { RegistrationID = 100008, StudentID = 900000005, ProductID = 1003, RegistrationDate = new DateTime(2022, 11, 25), ActualPaid = 450.00 },
                new Registration { RegistrationID = 100009, StudentID = 900000006, ProductID = 1002, RegistrationDate = new DateTime(2022, 12, 2), ActualPaid = 210.00 },
                new Registration { RegistrationID = 100010, StudentID = 900000006, ProductID = 1001, RegistrationDate = new DateTime(2022, 11, 12), ActualPaid = 90.00 },
                new Registration { RegistrationID = 100011, StudentID = 900000006, ProductID = 1003, RegistrationDate = new DateTime(2022, 11, 12), ActualPaid = 450.00 }
                );

            modelBuilder.Entity<Contact>().HasData(
                new Contact { ContactID = 100000001, Fname = "Parent", Lname = "One", FamilyID = 600000001 },
                new Contact { ContactID = 100000002, Fname = "Parent", Lname = "Two", FamilyID = 600000001 },
                new Contact { ContactID = 100000003, Fname = "Parent", Lname = "Three", FamilyID = 600000002 },
                new Contact { ContactID = 100000004, Fname = "Parent", Lname = "Four", FamilyID = 600000002 },
                new Contact { ContactID = 100000005, Fname = "Parent", Lname = "Five", FamilyID = 600000003 },
                new Contact { ContactID = 100000006, Fname = "Parent", Lname = "Six", FamilyID = 600000003 },
                new Contact { ContactID = 100000007, Fname = "Parent", Lname = "Seven", FamilyID = 600000004 },
                new Contact { ContactID = 100000008, Fname = "Parent", Lname = "Eight", FamilyID = 600000004 },
                new Contact { ContactID = 100000009, Fname = "Parent", Lname = "Nine", FamilyID = 600000005 }
                );

            modelBuilder.Entity<StudentContact>().HasKey(sc => new { sc.StudentID, sc.ContactID });
            modelBuilder.Entity<StudentContact>().HasOne(sc => sc.Student).WithMany(s => s.StudentContacts).HasForeignKey(sc => sc.StudentID);
            modelBuilder.Entity<StudentContact>().HasOne(sc => sc.Contact).WithMany(c => c.StudentContacts).HasForeignKey(sc => sc.ContactID);

        }
    }
}
