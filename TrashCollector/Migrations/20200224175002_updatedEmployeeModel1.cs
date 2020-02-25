using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Migrations
{
    public partial class updatedEmployeeModel1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "10b89121-076e-4b30-a98b-7313c4bf7bca", "165bdb92-71d4-4ba8-a81a-4245ee790fd2", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f75325a4-0ffa-4490-8ccd-3840e0185163", "c0fa2993-f21e-4d42-b3f9-ffb745b091c7", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "60e3eb30-01db-4396-ae9c-86d50ba330b6", "2a03873e-0b60-49ac-8b54-d039cbc08f08", "Customer", "CUSTOMER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "10b89121-076e-4b30-a98b-7313c4bf7bca");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "60e3eb30-01db-4396-ae9c-86d50ba330b6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f75325a4-0ffa-4490-8ccd-3840e0185163");

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
    }
}
