using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TicketingSystem.Infrastructure.Migrations
{
    public partial class AccountRequestRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RoleId",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "AccountRequestRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountRequestRoles", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AccountRequestRoles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Administrator" },
                    { 2, "Client" },
                    { 3, "Staff" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "742f6f61-e11f-4d3f-9b58-d6ada1a6e3df");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "845f42cf-ac1d-4c06-91e1-0b1a931c144b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "cc0efaf7-eb90-4b3a-8fe1-4c2571e45cee");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "08cfa46f-f2e4-4ae3-b3b7-6a99ee51843a",
                columns: new[] { "ConcurrencyStamp", "IsActive", "PasswordHash", "SecurityStamp" },
                values: new object[] { "caedf919-c99d-4c4a-98ab-d5444b6ed5ef", false, "AQAAAAEAACcQAAAAEM82CeyshQ2/rBd/+K5NMH6pr0ZDOipu2qnoNslY/eSKONly1qZQ3DhkQgkhdISvDg==", "afb2061c-1daa-4722-a0c7-4b03eee4c388" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1a3c1aad-89c2-444f-88ef-ce265a341270",
                columns: new[] { "ConcurrencyStamp", "IsActive", "PasswordHash", "SecurityStamp" },
                values: new object[] { "15f6296e-6a31-4fac-86dc-4745f7b683bb", false, "AQAAAAEAACcQAAAAEOktU20hYDxYGBZZ6gQzakmh0QXthc/z3Fo0kkcm+jZdcSf/eKIJgC63QroBa7VQTQ==", "7647b05f-c8d0-4ef6-9e28-837843926876" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "622d93dd-682c-4370-999b-6c4315ccceea",
                columns: new[] { "ConcurrencyStamp", "IsActive", "PasswordHash", "SecurityStamp" },
                values: new object[] { "34c3fde1-ed17-49a5-baad-84a9cba0e4aa", false, "AQAAAAEAACcQAAAAEOHCMce9I3w70T7F2yC1TwrvXOHHhVbINHD43z5nBCAQeYI/UD9MXLiFDX8npQgvJA==", "ff30115f-bf1d-4a05-910e-4b3aa5520558" });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_RoleId",
                table: "AspNetUsers",
                column: "RoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_AccountRequestRoles_RoleId",
                table: "AspNetUsers",
                column: "RoleId",
                principalTable: "AccountRequestRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_AccountRequestRoles_RoleId",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "AccountRequestRoles");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_RoleId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "RoleId",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "6c5ecb4f-02f4-474d-ba0e-e59eb5724b8f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "a2d0bd28-c722-4944-af65-19b9d6e3f843");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "cd4cf85d-2576-4d0a-b1d0-14d2725f9307");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "08cfa46f-f2e4-4ae3-b3b7-6a99ee51843a",
                columns: new[] { "ConcurrencyStamp", "IsActive", "PasswordHash", "SecurityStamp" },
                values: new object[] { "64b6905e-5313-4aee-9f36-e13222fce4be", true, "AQAAAAEAACcQAAAAECGgwzvR3o/ePC7U8cAdj968CqwoywQ2Tebmc7KATBwOBOHmSU/U2TqrdKQUh3WTyQ==", "8b31ccbf-22c4-4b11-a5b7-f31d46c6dc22" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1a3c1aad-89c2-444f-88ef-ce265a341270",
                columns: new[] { "ConcurrencyStamp", "IsActive", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1227a519-1174-4d91-9c7f-e6689a683b90", true, "AQAAAAEAACcQAAAAEN4bydWaPlh6C95TQsGaoZmEC5IXNZzdrub1/WnOcdkDxNQonONRY87WJNn0jR303w==", "1aa7dab9-fd5c-4002-9756-139a102a8a15" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "622d93dd-682c-4370-999b-6c4315ccceea",
                columns: new[] { "ConcurrencyStamp", "IsActive", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b03dac13-fa3b-433a-877c-ee4372beb9d2", true, "AQAAAAEAACcQAAAAED2FudZygpXHfstPzBBgXxBwpUHnq5FomgK46is7OvvSzz1j/I/iuc+heZjArrbjlw==", "325482a9-ec80-41b5-ac52-9dfdedf02252" });
        }
    }
}
