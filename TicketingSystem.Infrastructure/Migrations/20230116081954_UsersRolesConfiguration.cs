using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TicketingSystem.Infrastructure.Migrations
{
    public partial class UsersRolesConfiguration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

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

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "IsActive", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecondName", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "08cfa46f-f2e4-4ae3-b3b7-6a99ee51843a", 0, "64b6905e-5313-4aee-9f36-e13222fce4be", "staff@mail.com", false, "Staff", true, false, null, "STAFF@MAIL.COM", "STAFF", "AQAAAAEAACcQAAAAECGgwzvR3o/ePC7U8cAdj968CqwoywQ2Tebmc7KATBwOBOHmSU/U2TqrdKQUh3WTyQ==", null, false, "Staff", "8b31ccbf-22c4-4b11-a5b7-f31d46c6dc22", false, "Staff" },
                    { "1a3c1aad-89c2-444f-88ef-ce265a341270", 0, "1227a519-1174-4d91-9c7f-e6689a683b90", "client@mail.com", false, "Client", true, false, null, "CLIENT@MAIL.COM", "CLIENT", "AQAAAAEAACcQAAAAEN4bydWaPlh6C95TQsGaoZmEC5IXNZzdrub1/WnOcdkDxNQonONRY87WJNn0jR303w==", null, false, "Client", "1aa7dab9-fd5c-4002-9756-139a102a8a15", false, "Client" },
                    { "622d93dd-682c-4370-999b-6c4315ccceea", 0, "b03dac13-fa3b-433a-877c-ee4372beb9d2", "admin@mail.com", false, "Admin", true, false, null, "ADMIN@MAIL.COM", "ADMIN", "AQAAAAEAACcQAAAAED2FudZygpXHfstPzBBgXxBwpUHnq5FomgK46is7OvvSzz1j/I/iuc+heZjArrbjlw==", null, false, "Admin", "325482a9-ec80-41b5-ac52-9dfdedf02252", false, "Admin" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "2", "08cfa46f-f2e4-4ae3-b3b7-6a99ee51843a" },
                    { "3", "08cfa46f-f2e4-4ae3-b3b7-6a99ee51843a" },
                    { "2", "1a3c1aad-89c2-444f-88ef-ce265a341270" },
                    { "1", "622d93dd-682c-4370-999b-6c4315ccceea" },
                    { "2", "622d93dd-682c-4370-999b-6c4315ccceea" },
                    { "3", "622d93dd-682c-4370-999b-6c4315ccceea" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "08cfa46f-f2e4-4ae3-b3b7-6a99ee51843a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "08cfa46f-f2e4-4ae3-b3b7-6a99ee51843a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "1a3c1aad-89c2-444f-88ef-ce265a341270" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "622d93dd-682c-4370-999b-6c4315ccceea" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "622d93dd-682c-4370-999b-6c4315ccceea" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "622d93dd-682c-4370-999b-6c4315ccceea" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "08cfa46f-f2e4-4ae3-b3b7-6a99ee51843a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1a3c1aad-89c2-444f-88ef-ce265a341270");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "622d93dd-682c-4370-999b-6c4315ccceea");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "a0ee8cfb-0a9d-4d51-a887-86d612604f42");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "9384b70d-c068-41a6-989b-a36875a53593");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "1795b455-ff72-4b3c-b67d-877e45519e1b");
        }
    }
}
