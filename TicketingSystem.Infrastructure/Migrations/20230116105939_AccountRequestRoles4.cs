using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TicketingSystem.Infrastructure.Migrations
{
    public partial class AccountRequestRoles4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "d54a878b-978a-4942-af66-61b0c0e842dc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "8c155500-b4a4-40d3-839f-5f9c2ab7ae2e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "58f1ef5f-e611-405a-9ffc-e7b0d1cb6cd2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "08cfa46f-f2e4-4ae3-b3b7-6a99ee51843a",
                columns: new[] { "AccountRoleId", "ConcurrencyStamp", "IsActive", "PasswordHash", "SecurityStamp" },
                values: new object[] { 3, "a9e22bda-1831-489e-898d-1f063c1e387d", true, "AQAAAAEAACcQAAAAEM98e0njPzcBlpfpIVNkLHTPxhNkPj668hFGpiFyY01SBURLu0CLe+q3otp6oOWG6g==", "cefa2f48-c9a6-4597-bc0c-3e9d4ae0957f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1a3c1aad-89c2-444f-88ef-ce265a341270",
                columns: new[] { "AccountRoleId", "ConcurrencyStamp", "IsActive", "PasswordHash", "SecurityStamp" },
                values: new object[] { 2, "4a3b7dfc-50fd-4311-b848-02be85e48d63", true, "AQAAAAEAACcQAAAAEOwmytTg2HEQs2c5c2/ef8B2MP7iFVgmRNlBRavRLzF6LjE26E/yMqhsfs1yFEmL+Q==", "e12f08aa-4963-42a9-a832-121ddc9081b6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "622d93dd-682c-4370-999b-6c4315ccceea",
                columns: new[] { "AccountRoleId", "ConcurrencyStamp", "IsActive", "PasswordHash", "SecurityStamp" },
                values: new object[] { 1, "885de2d4-f1cf-4241-bc06-9bbfefcae6d1", true, "AQAAAAEAACcQAAAAEAAiV7vaTkjGwhLUiyRW/PxJUOoEuST9TAlAaPoGiuqjEse+caPKkvateCEziMBXmA==", "966d81ba-493a-4543-9cd3-e89c7bafbac7" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "AccountRoleId", "ConcurrencyStamp", "IsActive", "PasswordHash", "SecurityStamp" },
                values: new object[] { 0, "92f58298-e80c-4ab6-8edb-a03039d8e6f6", false, "AQAAAAEAACcQAAAAEHO5yF46rVtlJ91fAwSrusPpp/ib/K0hB2i0NQd220Gs4tFkkeS1BUkwIg5XDPrx2Q==", "474f1ab2-039a-43bd-9116-f46a2b41a7eb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1a3c1aad-89c2-444f-88ef-ce265a341270",
                columns: new[] { "AccountRoleId", "ConcurrencyStamp", "IsActive", "PasswordHash", "SecurityStamp" },
                values: new object[] { 0, "a99672df-e7ec-4a68-afab-d9aacd93dfe7", false, "AQAAAAEAACcQAAAAEBMT+z2j6fZlB/wByKT6ZIcj2fhT7HasP2jKzMIIrL1QZiwHn9fK/c+eTJX6wnXBzQ==", "801fcc77-7c8a-46f4-adbe-7cdb50fe002a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "622d93dd-682c-4370-999b-6c4315ccceea",
                columns: new[] { "AccountRoleId", "ConcurrencyStamp", "IsActive", "PasswordHash", "SecurityStamp" },
                values: new object[] { 0, "1581cb59-768d-49f6-ae24-4f520a4ae6ce", false, "AQAAAAEAACcQAAAAEMifs6Lk7BelNzPPDOg9gs643M6aPK0gTyEpBbmG0dzEojkOHyx7u3W/RSEGhznSkQ==", "4d78b9ea-abb1-4dbd-be4b-bb0696781d88" });
        }
    }
}
