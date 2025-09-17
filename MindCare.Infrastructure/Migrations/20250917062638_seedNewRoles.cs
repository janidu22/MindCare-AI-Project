using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MindCare.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class seedNewRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "674da2f8-78b0-4b24-a256-485fec74423d", null, "Counselor", "COUNSELOR" },
                    { "7c2463b2-3656-4019-9d88-66b2e3b84bff", null, "Admin", "ADMIN" },
                    { "ac26837a-f3e2-407e-86d6-0e65c3811b0b", null, "Patient", "PATIENT" },
                    { "e5295090-8476-42c2-9799-075fdd49c1b1", null, "Junior Counselor", "JUNIOR COUNSELOR" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "674da2f8-78b0-4b24-a256-485fec74423d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7c2463b2-3656-4019-9d88-66b2e3b84bff");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ac26837a-f3e2-407e-86d6-0e65c3811b0b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e5295090-8476-42c2-9799-075fdd49c1b1");
        }
    }
}
