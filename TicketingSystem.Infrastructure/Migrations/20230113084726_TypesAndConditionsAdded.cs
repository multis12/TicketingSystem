using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TicketingSystem.Infrastructure.Migrations
{
    public partial class TypesAndConditionsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ac46e3da-b9b1-4970-a2e9-d9ebf36022c2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c285d909-003a-43ae-8d04-04ae17c4eb0c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ceba6ebb-c5da-4864-be4f-3257476ac071");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3226078d-daa5-41b5-9607-d567181d7352", "3183bd6d-d7c3-445b-9846-1fbddf494122", "Administrator", "ADMINISTRATOR" },
                    { "6df5e250-376d-47a0-984d-044c1be104a8", "1eaac567-668f-4941-b7a3-5f395fafefec", "Staff", "STAFF" },
                    { "73363c29-3b9f-4f30-a0d6-0fc866161b30", "76a18a8d-0a85-4a77-994b-896d50faccf5", "Client", "CLIENT" }
                });

            migrationBuilder.InsertData(
                table: "Conditions",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Чернова" },
                    { 2, "Нов" },
                    { 3, "Работи се" },
                    { 4, "Приключен" }
                });

            migrationBuilder.InsertData(
                table: "MessageConditions",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Чернова" });

            migrationBuilder.InsertData(
                table: "Types",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Bug report" },
                    { 2, "Feature request" },
                    { 3, "Assistance request" },
                    { 4, "Other" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3226078d-daa5-41b5-9607-d567181d7352");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6df5e250-376d-47a0-984d-044c1be104a8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73363c29-3b9f-4f30-a0d6-0fc866161b30");

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "MessageConditions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ac46e3da-b9b1-4970-a2e9-d9ebf36022c2", "295750dc-0e5d-4dc9-b235-425199d0ec4c", "Client", "CLIENT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c285d909-003a-43ae-8d04-04ae17c4eb0c", "9674b17a-3db7-4ffa-92f7-d02a5fcb8c67", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ceba6ebb-c5da-4864-be4f-3257476ac071", "4a0fc74a-0a83-4b9f-916e-a820e70066be", "Staff", "STAFF" });
        }
    }
}
