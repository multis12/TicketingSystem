using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TicketingSystem.Infrastructure.Migrations
{
    public partial class Roles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9c617ccc-8dc2-482b-bb2d-3c7518e4db2f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b2e0fef2-6bc4-429c-b9c1-a5d2d987f98a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b9431f37-06c0-4636-abc0-16b919208f93");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "9c617ccc-8dc2-482b-bb2d-3c7518e4db2f", "00e68869-0eaf-4b3d-bcc9-8c74b145fb27", "Client", null });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b2e0fef2-6bc4-429c-b9c1-a5d2d987f98a", "b3cb6651-9057-4b25-9188-3b650e8abcaa", "Staff", null });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b9431f37-06c0-4636-abc0-16b919208f93", "97548d7a-d83f-49f7-9784-818dd067f33a", "Administrator", null });
        }
    }
}
