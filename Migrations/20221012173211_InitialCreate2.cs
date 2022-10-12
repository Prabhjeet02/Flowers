using Microsoft.EntityFrameworkCore.Migrations;

namespace Flowers.Migrations
{
    public partial class InitialCreate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cuantity",
                table: "Flower");

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "Flower",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Flower");

            migrationBuilder.AddColumn<int>(
                name: "Cuantity",
                table: "Flower",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
