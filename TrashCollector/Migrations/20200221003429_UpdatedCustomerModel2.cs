using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Migrations
{
    public partial class UpdatedCustomerModel2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "02ef2466-4ed6-42e2-9c40-a620b266cad2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "50397347-e1e6-4992-b257-82cd61704180");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e93f7f57-d71c-4687-9294-216b39d26bbe");

            migrationBuilder.AddColumn<double>(
                name: "BillAmount",
                table: "Customers",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "DayOfWeek",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDate",
                table: "Customers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fe246218-8a5f-4f8b-a336-691e4e6242e6", "4675efaf-8f5a-410e-be04-9a3363c7351c", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "33b2804a-4872-48df-b08a-bdc667becb28", "9bd67cb0-b92c-46f7-b891-28748657946a", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d381fb35-29a7-4550-9a6a-b026d67e048e", "1eb5da22-5a2b-4f22-94e2-7ba6d5dcfc33", "Customer", "CUSTOMER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "33b2804a-4872-48df-b08a-bdc667becb28");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d381fb35-29a7-4550-9a6a-b026d67e048e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fe246218-8a5f-4f8b-a336-691e4e6242e6");

            migrationBuilder.DropColumn(
                name: "BillAmount",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "DayOfWeek",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "Customers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e93f7f57-d71c-4687-9294-216b39d26bbe", "7a12a0c2-453c-4a09-ab24-06a2c7bacb1d", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "02ef2466-4ed6-42e2-9c40-a620b266cad2", "d3e122a2-f771-4660-be6d-af32bf1c6952", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "50397347-e1e6-4992-b257-82cd61704180", "acc88b65-6ee1-463e-ae51-4506a423288f", "Customer", "CUSTOMER" });
        }
    }
}
