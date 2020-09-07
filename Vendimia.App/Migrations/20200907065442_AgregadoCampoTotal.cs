using Microsoft.EntityFrameworkCore.Migrations;

namespace Vendimia.App.Migrations
{
    public partial class AgregadoCampoTotal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Total",
                table: "Ventas",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Total",
                table: "Ventas");
        }
    }
}
