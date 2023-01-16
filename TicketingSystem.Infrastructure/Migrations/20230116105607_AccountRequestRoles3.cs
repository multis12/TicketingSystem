using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TicketingSystem.Infrastructure.Migrations
{
    public partial class AccountRequestRoles3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_AccountRequestRoles_RoleId",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "RoleId",
                table: "AspNetUsers",
                newName: "AccountRoleId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUsers_RoleId",
                table: "AspNetUsers",
                newName: "IX_AspNetUsers_AccountRoleId");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "71504727-5a5a-4c0a-9bb8-ae1a510dae28");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "5e163a93-7718-42ad-b10b-ffa82d4f7bad");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "63612a5e-67a5-41b2-b7d3-dad547e2630d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "08cfa46f-f2e4-4ae3-b3b7-6a99ee51843a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "92f58298-e80c-4ab6-8edb-a03039d8e6f6", "AQAAAAEAACcQAAAAEHO5yF46rVtlJ91fAwSrusPpp/ib/K0hB2i0NQd220Gs4tFkkeS1BUkwIg5XDPrx2Q==", "474f1ab2-039a-43bd-9116-f46a2b41a7eb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1a3c1aad-89c2-444f-88ef-ce265a341270",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a99672df-e7ec-4a68-afab-d9aacd93dfe7", "AQAAAAEAACcQAAAAEBMT+z2j6fZlB/wByKT6ZIcj2fhT7HasP2jKzMIIrL1QZiwHn9fK/c+eTJX6wnXBzQ==", "801fcc77-7c8a-46f4-adbe-7cdb50fe002a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "622d93dd-682c-4370-999b-6c4315ccceea",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1581cb59-768d-49f6-ae24-4f520a4ae6ce", "AQAAAAEAACcQAAAAEMifs6Lk7BelNzPPDOg9gs643M6aPK0gTyEpBbmG0dzEojkOHyx7u3W/RSEGhznSkQ==", "4d78b9ea-abb1-4dbd-be4b-bb0696781d88" });

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_AccountRequestRoles_AccountRoleId",
                table: "AspNetUsers",
                column: "AccountRoleId",
                principalTable: "AccountRequestRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_AccountRequestRoles_AccountRoleId",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "AccountRoleId",
                table: "AspNetUsers",
                newName: "RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUsers_AccountRoleId",
                table: "AspNetUsers",
                newName: "IX_AspNetUsers_RoleId");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "80357635-586f-49e7-a8a2-a79005365ed0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "ac98a73f-7b18-492e-bf9c-0ab73ad16e12");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "3d2ecd98-625a-448d-9d89-f6821809d467");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "08cfa46f-f2e4-4ae3-b3b7-6a99ee51843a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "80c94e2c-b0f0-43e3-aec1-b64b92add910", "AQAAAAEAACcQAAAAEEIiwdX1gvdJsmUlnzgmaAyg8EyqPhqiqa+xZ3RKCBIoUnR8vDGq4cWL9T0TUN0hSQ==", "9e1b4948-3da9-4932-b91a-5c7349a590f9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1a3c1aad-89c2-444f-88ef-ce265a341270",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f00fb48a-4772-4fb1-8343-31282553d2ba", "AQAAAAEAACcQAAAAEGZ8imBviCMgccv+J7JaY30S0XS/uO85RuCcZ+vaae65xa0ZA/CwXSDnmYlIZ2fzbg==", "09aadbc3-b91b-49f9-b01d-a2c4d76c5aac" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "622d93dd-682c-4370-999b-6c4315ccceea",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "921b1386-a41b-4114-aa90-fb035f678267", "AQAAAAEAACcQAAAAEBOCbKeEVbf9K6z9vyJvQTXvycOVKrHA50vWusHNqFUkMe3aFUbHJqeJt7k7/rEWSw==", "29a63e37-e934-4ad5-a296-d86c72263e8d" });

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_AccountRequestRoles_RoleId",
                table: "AspNetUsers",
                column: "RoleId",
                principalTable: "AccountRequestRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
