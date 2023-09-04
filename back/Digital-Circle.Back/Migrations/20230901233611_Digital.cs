using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Digital_Circle.Back.Migrations
{
    /// <inheritdoc />
    public partial class Digital : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB01",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    col_texto = table.Column<string>(type: "TEXT", nullable: true),
                    col_dt = table.Column<DateTime>(type: "TIMESTAMP", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB01", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB01");
        }
    }
}
