using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TicketingSystem.Infrastructure.Migrations
{
    public partial class IsActiveAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d42d02eb-a3cc-4844-bc2a-2bb484207910");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d8758b07-dcf2-490b-982a-24c59fd51170");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f8da704a-097b-4d34-b7e1-45999ff69460");

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Projects",
                type: "bit",
                nullable: false,
                defaultValue: false);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Projects");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d42d02eb-a3cc-4844-bc2a-2bb484207910", "fa1681b6-c0b3-46c8-912b-d731978dcdfb", "Client", "CLIENT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d8758b07-dcf2-490b-982a-24c59fd51170", "41334c3e-d4a0-46a7-a0d0-b161344f9360", "Staff", "STAFF" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f8da704a-097b-4d34-b7e1-45999ff69460", "b7a0d9c9-934f-4e8d-ba29-16c3f71d5bf3", "Administrator", "ADMINISTRATOR" });
        }
    }
}
