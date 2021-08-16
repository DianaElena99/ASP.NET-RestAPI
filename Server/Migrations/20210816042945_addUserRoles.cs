using Microsoft.EntityFrameworkCore.Migrations;

namespace Server.Migrations
{
    public partial class addUserRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "59203cf7-bafa-4804-9e0f-d7c7ba04c2f7", "e11802ff-fcdd-4c8a-9992-243da2415059", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c5e874cb-2cec-43df-91b9-ae3970c754d4", "b7cac341-bf13-4b6b-8e11-4fe8d833e672", "Administrator", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "59203cf7-bafa-4804-9e0f-d7c7ba04c2f7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c5e874cb-2cec-43df-91b9-ae3970c754d4");
        }
    }
}
