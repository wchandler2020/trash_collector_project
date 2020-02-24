using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Migrations
{
    public partial class UpdatedCustomerModel3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<double>(
                name: "InvoiceAmount",
                table: "Customers",
                nullable: false,
                defaultValue: 0.0);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "InvoiceAmount",
                table: "Customers");

            migrationBuilder.AddColumn<double>(
                name: "BillAmount",
                table: "Customers",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

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
    }
}
