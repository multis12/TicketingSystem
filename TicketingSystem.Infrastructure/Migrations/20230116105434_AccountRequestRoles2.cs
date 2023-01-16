using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TicketingSystem.Infrastructure.Migrations
{
    public partial class AccountRequestRoles2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "caedf919-c99d-4c4a-98ab-d5444b6ed5ef", "AQAAAAEAACcQAAAAEM82CeyshQ2/rBd/+K5NMH6pr0ZDOipu2qnoNslY/eSKONly1qZQ3DhkQgkhdISvDg==", "afb2061c-1daa-4722-a0c7-4b03eee4c388" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1a3c1aad-89c2-444f-88ef-ce265a341270",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "15f6296e-6a31-4fac-86dc-4745f7b683bb", "AQAAAAEAACcQAAAAEOktU20hYDxYGBZZ6gQzakmh0QXthc/z3Fo0kkcm+jZdcSf/eKIJgC63QroBa7VQTQ==", "7647b05f-c8d0-4ef6-9e28-837843926876" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "622d93dd-682c-4370-999b-6c4315ccceea",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "34c3fde1-ed17-49a5-baad-84a9cba0e4aa", "AQAAAAEAACcQAAAAEOHCMce9I3w70T7F2yC1TwrvXOHHhVbINHD43z5nBCAQeYI/UD9MXLiFDX8npQgvJA==", "ff30115f-bf1d-4a05-910e-4b3aa5520558" });
        }
    }
}
