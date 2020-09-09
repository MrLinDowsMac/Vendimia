using Microsoft.EntityFrameworkCore.Migrations;

namespace Vendimia.App.Migrations
{
    public partial class AgregarConfiguracion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Configuracion",
                columns: table => new
                {
                    PrimerConfiguracion = table.Column<bool>(nullable: false),
                    TasaFinanciamiento = table.Column<decimal>(type: "decimal(6,4)", nullable: false),
                    Enganche = table.Column<decimal>(type: "decimal(6,4)", nullable: false),
                    PlazoMaximo = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Configuracion");
        }
    }
}
