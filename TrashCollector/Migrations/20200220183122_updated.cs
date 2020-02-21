using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Migrations
{
    public partial class updated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_customers_addresses_AddressId",
                table: "customers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_addresses",
                table: "addresses");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "40b2ffc8-42b3-4d58-8ef6-daf471c36291");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "967e8f4e-d28c-46ff-be52-3a2ed4780941");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ae53805f-bbad-448d-aab2-ce19550ef71b");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "addresses");

            migrationBuilder.AddColumn<int>(
                name: "AccountId",
                table: "customers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AddressId",
                table: "addresses",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_addresses",
                table: "addresses",
                column: "AddressId");

            migrationBuilder.CreateTable(
                name: "Account",
                columns: table => new
                {
                    AccountId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Balance = table.Column<double>(nullable: false),
                    AccountActive = table.Column<bool>(nullable: false),
                    PickupDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Account", x => x.AccountId);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "020dc859-5cfe-4822-bdb9-e8a5fc57f624", "82878f78-01fd-4274-822a-dd4f6752778b", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "83eea1f9-84bc-4617-b7a3-e32743ec6ce1", "bba34619-e711-4ee6-89ab-b54c7e37bb79", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9f70537c-b118-410b-bf26-b118b72592e0", "9873d4cb-cb8c-4d59-b131-05e4f184dada", "Customer", "CUSTOMER" });

            migrationBuilder.CreateIndex(
                name: "IX_customers_AccountId",
                table: "customers",
                column: "AccountId");

            migrationBuilder.AddForeignKey(
                name: "FK_customers_Account_AccountId",
                table: "customers",
                column: "AccountId",
                principalTable: "Account",
                principalColumn: "AccountId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_customers_addresses_AddressId",
                table: "customers",
                column: "AddressId",
                principalTable: "addresses",
                principalColumn: "AddressId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_customers_Account_AccountId",
                table: "customers");

            migrationBuilder.DropForeignKey(
                name: "FK_customers_addresses_AddressId",
                table: "customers");

            migrationBuilder.DropTable(
                name: "Account");

            migrationBuilder.DropIndex(
                name: "IX_customers_AccountId",
                table: "customers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_addresses",
                table: "addresses");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "020dc859-5cfe-4822-bdb9-e8a5fc57f624");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "83eea1f9-84bc-4617-b7a3-e32743ec6ce1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9f70537c-b118-410b-bf26-b118b72592e0");

            migrationBuilder.DropColumn(
                name: "AccountId",
                table: "customers");

            migrationBuilder.DropColumn(
                name: "AddressId",
                table: "addresses");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "addresses",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_addresses",
                table: "addresses",
                column: "Id");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ae53805f-bbad-448d-aab2-ce19550ef71b", "42ebbd95-b21e-412e-b553-26739c598b03", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "40b2ffc8-42b3-4d58-8ef6-daf471c36291", "1afa7e41-ce99-4180-aa75-f9b26cff2009", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "967e8f4e-d28c-46ff-be52-3a2ed4780941", "7568e3ee-6422-4c5d-8497-93d312fec026", "Customer", "CUSTOMER" });

            migrationBuilder.AddForeignKey(
                name: "FK_customers_addresses_AddressId",
                table: "customers",
                column: "AddressId",
                principalTable: "addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
