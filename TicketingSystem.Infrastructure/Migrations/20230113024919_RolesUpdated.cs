using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TicketingSystem.Infrastructure.Migrations
{
    public partial class RolesUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a3244119-8e9b-45b3-bf41-5207fe58a2d2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a56fc288-dcbe-4499-bfb8-72341937f6d5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f33f4bd5-1160-487a-9305-111f130c4dcd");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a3244119-8e9b-45b3-bf41-5207fe58a2d2", "0ec8818a-42e3-456d-ac0f-844876b4cd66", "Client", "CLIENT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a56fc288-dcbe-4499-bfb8-72341937f6d5", "0e36ae14-e95b-40ae-90ff-d0e1d6c9b7ba", "Staff", null });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f33f4bd5-1160-487a-9305-111f130c4dcd", "ae8c9bf6-ffc2-4e65-9069-74112b6490eb", "Administrator", null });
        }
    }
}
