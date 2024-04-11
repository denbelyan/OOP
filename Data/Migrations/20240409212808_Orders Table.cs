using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hotel.Data.Migrations
{
    /// <inheritdoc />
    public partial class OrdersTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "data");

            migrationBuilder.CreateTable(
                name: "Orders",
                schema: "data",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GuestsNum = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<float>(type: "real", nullable: false),
                    IsCompleted = table.Column<bool>(type: "bit", nullable: false),
                    DateOfOrder = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndOfOrder = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.ID);
                });

            migrationBuilder.InsertData(
                schema: "data",
                table: "Orders",
                columns: new[] { "ID", "DateOfOrder", "EndOfOrder", "GuestsNum", "IsCompleted", "Price" },
                values: new object[] { 1, new DateTime(2024, 4, 10, 0, 28, 7, 979, DateTimeKind.Local).AddTicks(8502), new DateTime(2024, 4, 15, 0, 28, 7, 979, DateTimeKind.Local).AddTicks(8515), 1, false, 1000f });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders",
                schema: "data");
        }
    }
}
