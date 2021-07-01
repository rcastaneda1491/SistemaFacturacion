using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemaFacturacion.Migrations
{
    public partial class segundaMigracion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "apellido",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "email",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "apellido",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "email",
                table: "Usuarios");
        }
    }
}
