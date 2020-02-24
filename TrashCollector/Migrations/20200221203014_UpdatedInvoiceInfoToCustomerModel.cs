using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Migrations
{
    public partial class UpdatedInvoiceInfoToCustomerModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6740418f-fc93-42ab-bb58-9ee516bdb88e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7d8e398a-7582-4eb2-9a33-39316da8e0c9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cfec593d-a1b4-4460-a9e8-572414546247");

            migrationBuilder.AddColumn<double>(
                name: "Balance",
                table: "Customers",
                nullable: false,
                defaultValue: 0.0);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Balance",
                table: "Customers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7d8e398a-7582-4eb2-9a33-39316da8e0c9", "a8424b5d-7969-43d7-aa6c-9e13ed3e037f", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cfec593d-a1b4-4460-a9e8-572414546247", "79641b9b-100b-4a7c-8b6e-1c0845c31532", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6740418f-fc93-42ab-bb58-9ee516bdb88e", "5d5f66af-171e-45d8-a277-38ba37b5bd2c", "Customer", "CUSTOMER" });
        }
    }
}
