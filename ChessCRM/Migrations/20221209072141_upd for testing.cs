using Microsoft.EntityFrameworkCore.Migrations;

namespace ChessCRM.Migrations
{
    public partial class updfortesting : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 900000002,
                column: "Active",
                value: false);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 900000004,
                column: "Active",
                value: false);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 900000005,
                column: "Active",
                value: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 900000002,
                column: "Active",
                value: true);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 900000004,
                column: "Active",
                value: true);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 900000005,
                column: "Active",
                value: true);
        }
    }
}
