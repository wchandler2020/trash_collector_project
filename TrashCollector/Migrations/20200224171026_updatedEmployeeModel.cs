using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Migrations
{
    public partial class updatedEmployeeModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5f95bc3c-3efc-44fc-b36a-1b1b5b48b574");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "90ff431d-9267-44da-b5ce-c3b5ecc9ee4a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "be849d0d-d832-4abc-ad91-9e0445a63ceb");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e9b2c2f9-8471-4e62-ab4a-f18dc4a6163e", "6c218f3a-23e3-43d6-ad24-8d17f988f68f", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cf9b6c6f-2c2e-498b-a89e-2c4ab2d3095c", "a4c56e3b-241f-4400-b417-b82471a3caf4", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "61ca6491-4666-474a-9e82-bc438033fa3e", "37a99ce9-7f72-422e-87a3-0f2c40b31280", "Customer", "CUSTOMER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "61ca6491-4666-474a-9e82-bc438033fa3e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cf9b6c6f-2c2e-498b-a89e-2c4ab2d3095c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e9b2c2f9-8471-4e62-ab4a-f18dc4a6163e");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "be849d0d-d832-4abc-ad91-9e0445a63ceb", "965472b3-ad6d-4e0b-8f8d-9d5a352ea80d", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5f95bc3c-3efc-44fc-b36a-1b1b5b48b574", "80d9aaab-27a4-4143-98f1-cf777aaadf92", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "90ff431d-9267-44da-b5ce-c3b5ecc9ee4a", "63552075-a511-4495-9f1f-be20ac9ab868", "Customer", "CUSTOMER" });
        }
    }
}
