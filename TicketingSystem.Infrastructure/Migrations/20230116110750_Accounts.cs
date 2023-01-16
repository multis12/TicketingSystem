using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TicketingSystem.Infrastructure.Migrations
{
    public partial class Accounts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "4dcd4b77-0118-4fba-bdf9-044f8ec94e37");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "c95536e3-ec78-44d3-9494-563eac6af1d7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "3851d006-1b43-4b89-9cea-c9f1ea6876ef");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AccountRoleId", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "IsActive", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecondName", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "a02a086f-e7a3-4dba-9732-d92a137c1158", 0, 3, "ebb4313e-e81f-4711-97a2-e9717ccb157e", "staff@mail.com", false, "Staff", true, false, null, "STAFF@MAIL.COM", "STAFF", "AQAAAAEAACcQAAAAELOXT9SucTmHnzuK4hcMOvm0+qZK+La5pqmCfTowqRNH9+jLGUv2kfqCxYbAygYdwg==", null, false, "Staff", "d0a9f6e5-8616-491c-98a7-3dcdd45bca51", false, "Staff" },
                    { "e7fc219d-b7ae-447e-ad73-1a6b4dc9c5e2", 0, 2, "f47025e4-9f35-494d-bafa-771839cdde76", "client@mail.com", false, "Client", true, false, null, "CLIENT@MAIL.COM", "CLIENT", "AQAAAAEAACcQAAAAEMQGmnh0pbyv2hciAisMQjWOjrbe49QMQbNIXRJzgAK8/f0dmXTie1UetPfGlFogSw==", null, false, "Client", "ee4ba869-70fa-4b9b-9e50-4f5ed78ffe4b", false, "Client" },
                    { "fe738829-bae4-46ec-a545-ed40aee912ea", 0, 1, "f7a7f835-29d8-4f43-941f-b62e9b4d0bad", "admin@mail.com", false, "Admin", true, false, null, "ADMIN@MAIL.COM", "ADMIN", "AQAAAAEAACcQAAAAEEF5GTLAtNopC+fVar+cLd/fByZXoMEwoiFFemocBE+/FCKBdFw5tYwJPDXHjkP2aQ==", null, false, "Admin", "89c50a04-e506-4e72-b9d4-a2bc3a34770a", false, "Admin" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "2", "a02a086f-e7a3-4dba-9732-d92a137c1158" },
                    { "3", "a02a086f-e7a3-4dba-9732-d92a137c1158" },
                    { "2", "e7fc219d-b7ae-447e-ad73-1a6b4dc9c5e2" },
                    { "1", "fe738829-bae4-46ec-a545-ed40aee912ea" },
                    { "2", "fe738829-bae4-46ec-a545-ed40aee912ea" },
                    { "3", "fe738829-bae4-46ec-a545-ed40aee912ea" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "a02a086f-e7a3-4dba-9732-d92a137c1158" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "a02a086f-e7a3-4dba-9732-d92a137c1158" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "e7fc219d-b7ae-447e-ad73-1a6b4dc9c5e2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "fe738829-bae4-46ec-a545-ed40aee912ea" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "fe738829-bae4-46ec-a545-ed40aee912ea" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "fe738829-bae4-46ec-a545-ed40aee912ea" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a02a086f-e7a3-4dba-9732-d92a137c1158");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e7fc219d-b7ae-447e-ad73-1a6b4dc9c5e2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fe738829-bae4-46ec-a545-ed40aee912ea");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "5ba4f1ad-1052-44dc-a2d7-d91bf9600fd8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "7ea5a30d-4803-44ae-b7f3-fbd5b45aaae8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "5d70f051-b16b-467f-8296-10fe171c6e68");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AccountRoleId", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "IsActive", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecondName", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "08cfa46f-f2e4-4ae3-b3b7-6a99ee51843a", 0, 3, "336fd5fb-80d0-4fb7-87db-41c6675d88f6", "staff@mail.com", false, "Staff", true, false, null, "STAFF@MAIL.COM", "STAFF", "AQAAAAEAACcQAAAAEGm36cSDSLc952BJE097M6a1VREhQE/Qa4DYkYfjOC5DFXGL/7u50ufQGJSEIAroKw==", null, false, "Staff", "e72e59ee-bfaa-4b92-adfc-875a3cd391b6", false, "Staff" },
                    { "1a3c1aad-89c2-444f-88ef-ce265a341270", 0, 2, "646f1359-1108-47d2-95b8-cbf2962f13a4", "client@mail.com", false, "Client", true, false, null, "CLIENT@MAIL.COM", "CLIENT", "AQAAAAEAACcQAAAAEGFcDPox6u4XgDPI8Yd0P3tpbInOG04xy4TclEplwi/B2YomxCVKKO02lyRSJDu8PQ==", null, false, "Client", "f24dec55-27f9-4cd6-b701-6ce8d3054c4f", false, "Client" },
                    { "622d93dd-682c-4370-999b-6c4315ccceea", 0, 1, "da451866-5be5-40b4-9b15-155311aed16a", "admin@mail.com", false, "Admin", true, false, null, "ADMIN@MAIL.COM", "ADMIN", "AQAAAAEAACcQAAAAEH0ZthRdfuUaz6sagasQRsKfZL1IWn/7qjrMdhMEGXOT98QA4bQ3YAlI/6X/cWUIfQ==", null, false, "Admin", "7c5eac2f-90ca-4e0e-b4ae-8fbf7da7de0c", false, "Admin" }
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
    }
}
