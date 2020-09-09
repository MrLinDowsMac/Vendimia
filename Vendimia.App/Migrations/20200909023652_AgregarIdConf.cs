using Microsoft.EntityFrameworkCore.Migrations;

namespace Vendimia.App.Migrations
{
    public partial class AgregarIdConf : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Configuracion",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Configuracion",
                table: "Configuracion",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Configuracion",
                columns: new[] { "Id", "Enganche", "PlazoMaximo", "PrimerConfiguracion", "TasaFinanciamiento" },
                values: new object[] { 1, 0.00m, 0, true, 0.00m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Configuracion",
                table: "Configuracion");

            migrationBuilder.DeleteData(
                table: "Configuracion",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Configuracion");
        }
    }
}
