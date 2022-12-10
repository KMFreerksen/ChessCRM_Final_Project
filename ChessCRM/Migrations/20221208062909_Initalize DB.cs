using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ChessCRM.Migrations
{
    public partial class InitalizeDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    ContactID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fname = table.Column<string>(nullable: true),
                    Lname = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    StreetAddress = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    Zip = table.Column<int>(nullable: false),
                    FamilyID = table.Column<int>(nullable: false),
                    SchoolID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.ContactID);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    StartDateTime = table.Column<DateTime>(nullable: false),
                    EndDateTime = table.Column<DateTime>(nullable: false),
                    Location = table.Column<string>(nullable: true),
                    StreetAddress = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    Zip = table.Column<int>(nullable: false),
                    MaxCapacity = table.Column<int>(nullable: false),
                    BasePrice = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductID);
                });

            migrationBuilder.CreateTable(
                name: "Registrations",
                columns: table => new
                {
                    RegistrationID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentID = table.Column<int>(nullable: false),
                    ProductID = table.Column<int>(nullable: false),
                    RegistrationDate = table.Column<DateTime>(nullable: false),
                    ActualPaid = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registrations", x => x.RegistrationID);
                });

            migrationBuilder.CreateTable(
                name: "Schools",
                columns: table => new
                {
                    SchoolID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SchoolName = table.Column<string>(nullable: true),
                    District = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    StreetAddress = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    Zip = table.Column<int>(nullable: false),
                    Phone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schools", x => x.SchoolID);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fname = table.Column<string>(nullable: true),
                    Lname = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Dob = table.Column<DateTime>(nullable: false),
                    Phone = table.Column<string>(nullable: true),
                    UschessID = table.Column<int>(nullable: false),
                    FamilyID = table.Column<int>(nullable: false),
                    SchoolID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentID);
                });

            migrationBuilder.CreateTable(
                name: "StudentContact",
                columns: table => new
                {
                    StudentID = table.Column<int>(nullable: false),
                    ContactID = table.Column<int>(nullable: false),
                    FamilyID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentContact", x => new { x.StudentID, x.ContactID });
                    table.ForeignKey(
                        name: "FK_StudentContact_Contacts_ContactID",
                        column: x => x.ContactID,
                        principalTable: "Contacts",
                        principalColumn: "ContactID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentContact_Students_StudentID",
                        column: x => x.StudentID,
                        principalTable: "Students",
                        principalColumn: "StudentID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "ContactID", "City", "Email", "FamilyID", "Fname", "Lname", "Phone", "SchoolID", "State", "StreetAddress", "Type", "Zip" },
                values: new object[,]
                {
                    { 100000001, null, null, 600000001, "Parent", "One", null, 0, null, null, null, 0 },
                    { 100000008, null, null, 600000004, "Parent", "Eight", null, 0, null, null, null, 0 },
                    { 100000007, null, null, 600000004, "Parent", "Seven", null, 0, null, null, null, 0 },
                    { 100000006, null, null, 600000003, "Parent", "Six", null, 0, null, null, null, 0 },
                    { 100000009, null, null, 600000005, "Parent", "Nine", null, 0, null, null, null, 0 },
                    { 100000004, null, null, 600000002, "Parent", "Four", null, 0, null, null, null, 0 },
                    { 100000003, null, null, 600000002, "Parent", "Three", null, 0, null, null, null, 0 },
                    { 100000002, null, null, 600000001, "Parent", "Two", null, 0, null, null, null, 0 },
                    { 100000005, null, null, 600000003, "Parent", "Five", null, 0, null, null, null, 0 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "BasePrice", "City", "EndDateTime", "Location", "MaxCapacity", "ProductName", "StartDateTime", "State", "StreetAddress", "Type", "Zip" },
                values: new object[,]
                {
                    { 1001, 0.0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sample Elementary School", 0, "Sample Club", new DateTime(2022, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "club", 0 },
                    { 1002, 0.0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sample Middle School", 0, "Sample Class", new DateTime(2022, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "class", 0 },
                    { 1003, 0.0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sample High School", 0, "Sample Lesson", new DateTime(2022, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "lesson", 0 }
                });

            migrationBuilder.InsertData(
                table: "Registrations",
                columns: new[] { "RegistrationID", "ActualPaid", "ProductID", "RegistrationDate", "StudentID" },
                values: new object[,]
                {
                    { 100008, 450.0, 1003, new DateTime(2022, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 900000005 },
                    { 100011, 450.0, 1003, new DateTime(2022, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 900000006 },
                    { 100010, 90.0, 1001, new DateTime(2022, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 900000006 },
                    { 100009, 210.0, 1002, new DateTime(2022, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 900000006 },
                    { 100007, 90.0, 1001, new DateTime(2022, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 900000004 },
                    { 100004, 450.0, 1003, new DateTime(2022, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 900000002 },
                    { 100005, 90.0, 1001, new DateTime(2022, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 900000003 },
                    { 100003, 90.0, 1001, new DateTime(2022, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 900000002 },
                    { 100002, 210.0, 1002, new DateTime(2022, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 900000001 },
                    { 100001, 90.0, 1001, new DateTime(2022, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 900000001 },
                    { 100006, 210.0, 1002, new DateTime(2022, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 900000003 }
                });

            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "SchoolID", "City", "District", "Phone", "SchoolName", "State", "StreetAddress", "Type", "Zip" },
                values: new object[,]
                {
                    { 300001, "Whoville", "Whoville CSD", "555-555-5555", "Sample Elementary School", "IA", "123 Elementary Dr", "elem", 55555 },
                    { 300002, "Whoville", "Whoville CSD", "555-555-5555", "Sample Middle School", "IA", "123 Middle Ave", "midl", 55555 },
                    { 300003, "Whoville", "Whoville CSD", "555-555-5555", "Sample High School", "IA", "123 High St", "high", 55555 }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentID", "Dob", "Email", "FamilyID", "Fname", "Gender", "Lname", "Phone", "SchoolID", "UschessID" },
                values: new object[,]
                {
                    { 900000005, new DateTime(2004, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "misc@email.com", 600000004, "Student", "Female", "Five", "555-555-5555", 300003, 12345682 },
                    { 900000001, new DateTime(2013, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "misc@email.com", 600000001, "Student", "Female", "One", "555-555-5555", 300001, 12345678 },
                    { 900000002, new DateTime(2010, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "misc@email.com", 600000002, "Student", "Male", "Two", "555-555-5555", 300001, 12345679 },
                    { 900000003, new DateTime(2008, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "misc@email.com", 600000001, "Student", "Nonbinary", "Three", "555-555-5555", 300002, 12345680 },
                    { 900000004, new DateTime(2007, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "misc@email.com", 600000003, "Student", "NA", "Four", "555-555-5555", 300002, 12345681 },
                    { 900000006, new DateTime(2002, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "misc@email.com", 600000005, "Student", "NA", "Four", "555-555-5555", 300003, 12345683 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_StudentContact_ContactID",
                table: "StudentContact",
                column: "ContactID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Registrations");

            migrationBuilder.DropTable(
                name: "Schools");

            migrationBuilder.DropTable(
                name: "StudentContact");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
