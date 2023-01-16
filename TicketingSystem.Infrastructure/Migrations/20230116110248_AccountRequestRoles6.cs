using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TicketingSystem.Infrastructure.Migrations
{
    public partial class AccountRequestRoles6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "14190b92-791d-4770-a2ed-a1b6fad83c1d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "a5eb0c55-2abb-4ab7-aa2a-fad164edf6ae");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "b08730a9-4a91-4712-b674-f5673c07885b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "08cfa46f-f2e4-4ae3-b3b7-6a99ee51843a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9ecfbaba-3562-48bb-a383-ab07e10d04af", "AQAAAAEAACcQAAAAEMeklWMdnXqNC7JoEI81oxJLG38x7NzcCm6GnA6SV/e9xMG0foRnmtHnJAOPzixfCA==", "33327eae-c772-4451-afa0-2db44d82823f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1a3c1aad-89c2-444f-88ef-ce265a341270",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bbea4080-bb82-4e52-ac72-c17d81701b24", "AQAAAAEAACcQAAAAEENb9SReboU5BxFa4bBg2T1StDLG/Ds/BFwNGmklgTQx3OXJTkCp99AfX5Imlyp4Xg==", "6e27d6b0-e9a5-4def-bf44-95642e2e5da0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "622d93dd-682c-4370-999b-6c4315ccceea",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d0a05528-ea9e-4abe-b9e4-9ab47c01d2b4", "AQAAAAEAACcQAAAAEOgLPmk0h3xNabjO3EsuM8ZfGm6s1TkT/T2lhM4XEQP1JoITiyF6VwiMcF5+ETlRTw==", "8ad60e74-4770-4c90-b106-816d4221a664" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
