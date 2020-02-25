using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Migrations
{
    public partial class addedcustomerbalancetoemployeedb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "36a05b18-ae13-4432-92aa-ff83915338c5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c43b1911-e97d-43a3-9f85-89a51a1b9331");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c57e1a01-a4a1-40fd-9435-c400cc673888");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ada5a9f2-120a-4bca-aa36-b872850dc08c", "7502f33c-e578-4bd0-a93d-3a1ec028c50b", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3ac3d014-d473-4077-8cda-7b422b94ab63", "9b6a0819-be1e-4966-81be-4850bac38c78", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2b199420-93f2-4a94-8948-0c28ca46409d", "cd6379d5-a8e3-4e2e-bea0-9f4a63113869", "Customer", "CUSTOMER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2b199420-93f2-4a94-8948-0c28ca46409d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3ac3d014-d473-4077-8cda-7b422b94ab63");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ada5a9f2-120a-4bca-aa36-b872850dc08c");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c57e1a01-a4a1-40fd-9435-c400cc673888", "2b08f5d6-ad47-40b9-8937-e811dbffccc2", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c43b1911-e97d-43a3-9f85-89a51a1b9331", "4661ce50-91d3-4735-bb2f-97ac856cb4a0", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "36a05b18-ae13-4432-92aa-ff83915338c5", "67623d77-a59d-43e4-9b0c-bafcf21a5635", "Customer", "CUSTOMER" });
        }
    }
}
