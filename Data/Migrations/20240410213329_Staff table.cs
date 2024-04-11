using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hotel.Data.Migrations
{
    /// <inheritdoc />
    public partial class Stafftable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Roles",
                schema: "data",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Staff",
                schema: "data",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    salary = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JobTitle = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staff", x => x.ID);
                });

            migrationBuilder.UpdateData(
                schema: "data",
                table: "Orders",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateOfOrder", "EndOfOrder" },
                values: new object[] { new DateTime(2024, 4, 11, 0, 33, 28, 938, DateTimeKind.Local).AddTicks(9020), new DateTime(2024, 4, 16, 0, 33, 28, 938, DateTimeKind.Local).AddTicks(9032) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Roles",
                schema: "data");

            migrationBuilder.DropTable(
                name: "Staff",
                schema: "data");

            migrationBuilder.UpdateData(
                schema: "data",
                table: "Orders",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateOfOrder", "EndOfOrder" },
                values: new object[] { new DateTime(2024, 4, 10, 0, 28, 7, 979, DateTimeKind.Local).AddTicks(8502), new DateTime(2024, 4, 15, 0, 28, 7, 979, DateTimeKind.Local).AddTicks(8515) });
        }
    }
}
