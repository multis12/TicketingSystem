using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TicketingSystem.Infrastructure.Migrations
{
    public partial class ErrorMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "fafbe72a-32d1-46ae-94f6-a6ce04009aed");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "a2dc8fa3-00b8-40c9-bf20-d4c62c855f23");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "10ec9528-7b0f-4ba3-9935-4ff2ddbcf1d0");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a02a086f-e7a3-4dba-9732-d92a137c1158",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "440e411d-c631-43ae-9ef1-8dce562fbc85", "AQAAAAEAACcQAAAAEETu2b6NY3eoDhsSaq0AthmBl+OntAfHNjFJRBdazzBfLn650Tscxx391g+zqHyUFA==", "adf0f1ee-3e3c-452b-8f74-d8841ddc3ec1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e7fc219d-b7ae-447e-ad73-1a6b4dc9c5e2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2db22ad7-5e1b-4730-914b-2484abdf6013", "AQAAAAEAACcQAAAAEKF+y4XTWK9kuBZdoomEJLHX0aPvE5UsRW7FcUFPdPUu2A/UrOayM43zmT3zpAtBHA==", "61890207-4f5e-4b21-974f-524d4d7ace0d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fe738829-bae4-46ec-a545-ed40aee912ea",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "525a2315-a38f-47ae-869d-e5e804566e69", "AQAAAAEAACcQAAAAEIcEYskHE1xtOF5rXYicUSqet/PSMaVuUXeRgH7apmvVYGowHfCM0hqp4FtCeeW9mQ==", "8d958e5f-ddb5-4fac-9c58-74d5a19c2f08" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a02a086f-e7a3-4dba-9732-d92a137c1158",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ebb4313e-e81f-4711-97a2-e9717ccb157e", "AQAAAAEAACcQAAAAELOXT9SucTmHnzuK4hcMOvm0+qZK+La5pqmCfTowqRNH9+jLGUv2kfqCxYbAygYdwg==", "d0a9f6e5-8616-491c-98a7-3dcdd45bca51" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e7fc219d-b7ae-447e-ad73-1a6b4dc9c5e2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f47025e4-9f35-494d-bafa-771839cdde76", "AQAAAAEAACcQAAAAEMQGmnh0pbyv2hciAisMQjWOjrbe49QMQbNIXRJzgAK8/f0dmXTie1UetPfGlFogSw==", "ee4ba869-70fa-4b9b-9e50-4f5ed78ffe4b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fe738829-bae4-46ec-a545-ed40aee912ea",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f7a7f835-29d8-4f43-941f-b62e9b4d0bad", "AQAAAAEAACcQAAAAEEF5GTLAtNopC+fVar+cLd/fByZXoMEwoiFFemocBE+/FCKBdFw5tYwJPDXHjkP2aQ==", "89c50a04-e506-4e72-b9d4-a2bc3a34770a" });
        }
    }
}
