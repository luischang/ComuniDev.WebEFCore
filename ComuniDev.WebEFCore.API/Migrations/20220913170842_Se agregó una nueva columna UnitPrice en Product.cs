using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ComuniDev.WebEFCore.API.Migrations
{
    public partial class SeagregóunanuevacolumnaUnitPriceenProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "UnitPrice",
                table: "Product",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UnitPrice",
                table: "Product");
        }
    }
}
