using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TicketingSystem.Infrastructure.Migrations
{
    public partial class AccountRequestRoles7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "08cfa46f-f2e4-4ae3-b3b7-6a99ee51843a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "336fd5fb-80d0-4fb7-87db-41c6675d88f6", "AQAAAAEAACcQAAAAEGm36cSDSLc952BJE097M6a1VREhQE/Qa4DYkYfjOC5DFXGL/7u50ufQGJSEIAroKw==", "e72e59ee-bfaa-4b92-adfc-875a3cd391b6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1a3c1aad-89c2-444f-88ef-ce265a341270",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "646f1359-1108-47d2-95b8-cbf2962f13a4", "AQAAAAEAACcQAAAAEGFcDPox6u4XgDPI8Yd0P3tpbInOG04xy4TclEplwi/B2YomxCVKKO02lyRSJDu8PQ==", "f24dec55-27f9-4cd6-b701-6ce8d3054c4f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "622d93dd-682c-4370-999b-6c4315ccceea",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "da451866-5be5-40b4-9b15-155311aed16a", "AQAAAAEAACcQAAAAEH0ZthRdfuUaz6sagasQRsKfZL1IWn/7qjrMdhMEGXOT98QA4bQ3YAlI/6X/cWUIfQ==", "7c5eac2f-90ca-4e0e-b4ae-8fbf7da7de0c" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
