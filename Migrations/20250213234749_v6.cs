using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookStore.Migrations
{
    /// <inheritdoc />
    public partial class v6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d1f1b9a1-11ec-4e1a-945d-2fbd57d2c3a8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d8191078-0c49-4e02-b025-d8734c2d404b");

            migrationBuilder.DropColumn(
                name: "Admin_Password",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "34957be5-33a4-425f-8ecf-c2d30908df6e", null, "Customer", "CUSTOMER" },
                    { "a700a748-39ba-4adb-a850-0465aed766af", null, "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "34957be5-33a4-425f-8ecf-c2d30908df6e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a700a748-39ba-4adb-a850-0465aed766af");

            migrationBuilder.AddColumn<string>(
                name: "Admin_Password",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "d1f1b9a1-11ec-4e1a-945d-2fbd57d2c3a8", null, "Admin", "ADMIN" },
                    { "d8191078-0c49-4e02-b025-d8734c2d404b", null, "Customer", "CUSTOMER" }
                });
        }
    }
}
