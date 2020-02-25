using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Migrations
{
    public partial class updatedCustomeModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
