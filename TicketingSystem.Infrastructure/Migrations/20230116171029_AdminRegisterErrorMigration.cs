using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TicketingSystem.Infrastructure.Migrations
{
    public partial class AdminRegisterErrorMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "3c6b9c39-9c18-4db3-b509-448dc5dd9d17");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "24c01e40-8701-4ba7-a279-daa2950a4d2e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "5d829372-ca92-4087-9e3c-776fb36b1b74");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a02a086f-e7a3-4dba-9732-d92a137c1158",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "54315999-d8ce-4c81-be64-03bbae27bd5b", "AQAAAAEAACcQAAAAELyCCMqnZeOajtFRrzyDTgiruglvLa0muVoHh6LYsKxCl4rKMMg7Z87JE4i/+PD9pw==", "f0e89153-af6f-405c-a562-2d877a5b6645" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e7fc219d-b7ae-447e-ad73-1a6b4dc9c5e2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bfaa6282-5a63-4442-a864-c83fb62c0309", "AQAAAAEAACcQAAAAEHAqgx8oNn15iTBd3K032CYYEFuFXcpBbSb9nIP5myLr0nTEyCtYT9bkS7nwGxitrg==", "c9f7f40d-31b5-42d6-b4d1-e420686917a8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fe738829-bae4-46ec-a545-ed40aee912ea",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "68cd0e98-685b-4591-85a2-9fce424e62da", "AQAAAAEAACcQAAAAEDDgeneUMhoMnPbnUJnWSBtAeb5cFz/XSfk25EKGLzHXLWTApMJwk/QWTgk9cY6lWg==", "ed53d885-5fda-4472-986c-06ec54730d84" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
