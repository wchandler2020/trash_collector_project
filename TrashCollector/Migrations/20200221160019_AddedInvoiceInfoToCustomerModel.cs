using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Migrations
{
    public partial class AddedInvoiceInfoToCustomerModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2543a3c7-1d90-4a20-b832-9fb3949d8adc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5d304068-39a5-403b-abe1-210ba2db3843");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b7936bcc-1833-42e4-a12f-b4c268f66c55");

            migrationBuilder.AddColumn<bool>(
                name: "AccountActive",
                table: "Customers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "Customers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "PickupDate",
                table: "Customers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "AccountActive",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "PickupDate",
                table: "Customers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2543a3c7-1d90-4a20-b832-9fb3949d8adc", "311032e1-7519-4a31-aabc-b21e28e49e6d", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5d304068-39a5-403b-abe1-210ba2db3843", "2f4ea752-2732-4065-83a2-d37123299770", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b7936bcc-1833-42e4-a12f-b4c268f66c55", "3a2d46d3-3c60-442f-80f8-790556d4c5c9", "Customer", "CUSTOMER" });
        }
    }
}
