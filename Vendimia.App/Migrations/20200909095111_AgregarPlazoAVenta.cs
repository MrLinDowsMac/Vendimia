using Microsoft.EntityFrameworkCore.Migrations;

namespace Vendimia.App.Migrations
{
    public partial class AgregarPlazoAVenta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Plazo",
                table: "Ventas",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Plazo",
                table: "Ventas");
        }
    }
}
