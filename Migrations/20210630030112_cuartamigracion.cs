using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemaFacturacion.Migrations
{
    public partial class cuartamigracion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Factura_Productos_Facturas_numeroFactura",
                table: "Factura_Productos");

            migrationBuilder.DropForeignKey(
                name: "FK_Factura_Productos_Productos_codigoProducto",
                table: "Factura_Productos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Factura_Productos",
                table: "Factura_Productos");

            migrationBuilder.RenameTable(
                name: "Factura_Productos",
                newName: "FacturaProductos");

            migrationBuilder.RenameIndex(
                name: "IX_Factura_Productos_codigoProducto",
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                newName: "Factura_Productos");

            migrationBuilder.RenameIndex(
                name: "IX_FacturaProductos_codigoProducto",
                table: "Factura_Productos",
                newName: "IX_Factura_Productos_codigoProducto");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Factura_Productos",
                table: "Factura_Productos",
                columns: new[] { "numeroFactura", "codigoProducto" });

            migrationBuilder.AddForeignKey(
                name: "FK_Factura_Productos_Facturas_numeroFactura",
                table: "Factura_Productos",
                column: "numeroFactura",
                principalTable: "Facturas",
                principalColumn: "numeroFactura",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Factura_Productos_Productos_codigoProducto",
                table: "Factura_Productos",
                column: "codigoProducto",
                principalTable: "Productos",
                principalColumn: "codigoProducto",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
