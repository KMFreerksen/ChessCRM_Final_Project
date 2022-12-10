using Microsoft.EntityFrameworkCore.Migrations;

namespace ChessCRM.Migrations
{
    public partial class Upd3forEval : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 900000001,
                column: "Skill",
                value: "white");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 900000002,
                column: "Skill",
                value: "white");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 900000003,
                column: "Skill",
                value: "white");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 900000004,
                column: "Skill",
                value: "white");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 900000005,
                column: "Skill",
                value: "white");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 900000006,
                column: "Skill",
                value: "white");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 900000001,
                column: "Skill",
                value: "New");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 900000002,
                column: "Skill",
                value: "New");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 900000003,
                column: "Skill",
                value: "New");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 900000004,
                column: "Skill",
                value: "New");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 900000005,
                column: "Skill",
                value: "New");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 900000006,
                column: "Skill",
                value: "New");
        }
    }
}
