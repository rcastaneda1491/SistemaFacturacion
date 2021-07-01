using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemaFacturacion.Migrations
{
    public partial class quintamigracion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FacturaProductos_Facturas_numeroFactura",
                table: "FacturaProductos");

            migrationBuilder.DropForeignKey(
                name: "FK_FacturaProductos_Productos_codigoProducto",
                table: "FacturaProductos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FacturaProductos",
                table: "FacturaProductos");

            migrationBuilder.RenameTable(
                name: "FacturaProductos",
                newName: "FacturaProducto");

            migrationBuilder.RenameIndex(
                name: "IX_FacturaProductos_codigoProducto",
                table: "FacturaProducto",
                newName: "IX_FacturaProducto_codigoProducto");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FacturaProducto",
                table: "FacturaProducto",
                columns: new[] { "numeroFactura", "codigoProducto" });

            migrationBuilder.AddForeignKey(
                name: "FK_FacturaProducto_Facturas_numeroFactura",
                table: "FacturaProducto",
                column: "numeroFactura",
                principalTable: "Facturas",
                principalColumn: "numeroFactura",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FacturaProducto_Productos_codigoProducto",
                table: "FacturaProducto",
                column: "codigoProducto",
                principalTable: "Productos",
                principalColumn: "codigoProducto",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FacturaProducto_Facturas_numeroFactura",
                table: "FacturaProducto");

            migrationBuilder.DropForeignKey(
                name: "FK_FacturaProducto_Productos_codigoProducto",
                table: "FacturaProducto");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FacturaProducto",
                table: "FacturaProducto");

            migrationBuilder.RenameTable(
                name: "FacturaProducto",
                newName: "FacturaProductos");

            migrationBuilder.RenameIndex(
                name: "IX_FacturaProducto_codigoProducto",
                table: "FacturaProductos",
                newName: "IX_FacturaProductos_codigoProducto");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FacturaProductos",
                table: "FacturaProductos",
                columns: new[] { "numeroFactura", "codigoProducto" });

            migrationBuilder.AddForeignKey(
                name: "FK_FacturaProductos_Facturas_numeroFactura",
                table: "FacturaProductos",
                column: "numeroFactura",
                principalTable: "Facturas",
                principalColumn: "numeroFactura",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FacturaProductos_Productos_codigoProducto",
                table: "FacturaProductos",
                column: "codigoProducto",
                principalTable: "Productos",
                principalColumn: "codigoProducto",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
