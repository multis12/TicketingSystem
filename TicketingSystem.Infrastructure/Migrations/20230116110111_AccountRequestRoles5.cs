using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TicketingSystem.Infrastructure.Migrations
{
    public partial class AccountRequestRoles5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "ee893386-37a2-4822-aed9-ff0b687b32f6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "4249481c-1601-4520-aaa2-3cc63dbf78dc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "3be47e70-6de4-4efa-8c02-019bdedbf1e9");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "08cfa46f-f2e4-4ae3-b3b7-6a99ee51843a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c2ecf051-1615-4746-95db-b07dbdc1079c", "AQAAAAEAACcQAAAAEKjFhrX2jnYJhTa4Pi2fjLc/FM6oeAlF2BThWySXd7Mfk5Jpu31aDC5F9avy/XYfXw==", "e23ccd40-676d-43cb-bd8b-2a34e6476eb0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1a3c1aad-89c2-444f-88ef-ce265a341270",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a5b39229-df25-4765-88e8-d15199191e73", "AQAAAAEAACcQAAAAEGMOFHerk2rbDtlWsQJaUka/AFs2wk0ApHNEy24AYFck3bmbadBY3Gc6x9a+w/BL2Q==", "3034856c-e47e-481e-8ce0-8617fde4a195" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "622d93dd-682c-4370-999b-6c4315ccceea",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9e7fb13b-42a0-44f5-8f7e-69513b4b18fa", "AQAAAAEAACcQAAAAEKO8phe5I54kzjIBcQO8UnBvZ/mZ+eWgwbZJxflH+zRPhENX1pxTkuW7XKNtde4kIw==", "8daa4774-e527-4264-9791-f8278b4ec70d" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a9e22bda-1831-489e-898d-1f063c1e387d", "AQAAAAEAACcQAAAAEM98e0njPzcBlpfpIVNkLHTPxhNkPj668hFGpiFyY01SBURLu0CLe+q3otp6oOWG6g==", "cefa2f48-c9a6-4597-bc0c-3e9d4ae0957f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1a3c1aad-89c2-444f-88ef-ce265a341270",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4a3b7dfc-50fd-4311-b848-02be85e48d63", "AQAAAAEAACcQAAAAEOwmytTg2HEQs2c5c2/ef8B2MP7iFVgmRNlBRavRLzF6LjE26E/yMqhsfs1yFEmL+Q==", "e12f08aa-4963-42a9-a832-121ddc9081b6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "622d93dd-682c-4370-999b-6c4315ccceea",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "885de2d4-f1cf-4241-bc06-9bbfefcae6d1", "AQAAAAEAACcQAAAAEAAiV7vaTkjGwhLUiyRW/PxJUOoEuST9TAlAaPoGiuqjEse+caPKkvateCEziMBXmA==", "966d81ba-493a-4543-9cd3-e89c7bafbac7" });
        }
    }
}
