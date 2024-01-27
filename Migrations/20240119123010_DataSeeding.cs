using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FakeCtrip.API.Migrations
{
    public partial class DataSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TouristRoutes",
                columns: new[] { "Id", "CreateTime", "DepatureTime", "Description", "DiscountPresnt", "Features", "Fees", "Notes", "OriginalPrice", "Title", "UpdateTime" },
                values: new object[] { new Guid("0a95bab6-2097-4834-b4f7-9e14a6451c3f"), new DateTime(2024, 1, 19, 12, 30, 10, 358, DateTimeKind.Utc).AddTicks(8230), null, "shuoming", null, null, null, null, 0m, "ceshititle", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TouristRoutes",
                keyColumn: "Id",
                keyValue: new Guid("0a95bab6-2097-4834-b4f7-9e14a6451c3f"));
        }
    }
}
