using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Migrations
{
    public partial class AddForiegnKeyForCustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2dd355c5-aa69-4769-959f-4d71bb62af2f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "970fd748-f195-476e-9b9e-ad9ff528ab89");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "be04c809-e37b-425c-b061-cea74d7112c7");

            migrationBuilder.AddColumn<string>(
                name: "IdentityUserId",
                table: "Customers",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Customers_IdentityUserId",
                table: "Customers",
                column: "IdentityUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_AspNetUsers_IdentityUserId",
                table: "Customers",
                column: "IdentityUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_AspNetUsers_IdentityUserId",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Customers_IdentityUserId",
                table: "Customers");

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

            migrationBuilder.DropColumn(
                name: "IdentityUserId",
                table: "Customers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "be04c809-e37b-425c-b061-cea74d7112c7", "310922e8-a2dc-4bf8-bde4-5d2400c2def8", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2dd355c5-aa69-4769-959f-4d71bb62af2f", "9348726f-5a91-41ba-873f-2ef406137077", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "970fd748-f195-476e-9b9e-ad9ff528ab89", "db3b6e70-2279-46d9-88cd-c356db61adbc", "Customer", "CUSTOMER" });
        }
    }
}
