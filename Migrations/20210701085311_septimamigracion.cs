using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemaFacturacion.Migrations
{
    public partial class septimamigracion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FacturaProducto_Facturas_numeroFactura",
                table: "FacturaProducto");

            migrationBuilder.DropForeignKey(
                name: "FK_FacturaProducto_Productos_codigoProducto",
                table: "FacturaProducto");

            migrationBuilder.DropForeignKey(
                name: "FK_Facturas_Clientes_codigoCliente",
                table: "Facturas");

            migrationBuilder.AddForeignKey(
                name: "FK_FacturaProducto_Facturas_numeroFactura",
                table: "FacturaProducto",
                column: "numeroFactura",
                principalTable: "Facturas",
                principalColumn: "numeroFactura",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FacturaProducto_Productos_codigoProducto",
                table: "FacturaProducto",
                column: "codigoProducto",
                principalTable: "Productos",
                principalColumn: "codigoProducto",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Facturas_Clientes_codigoCliente",
                table: "Facturas",
                column: "codigoCliente",
                principalTable: "Clientes",
                principalColumn: "codigoCliente",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FacturaProducto_Facturas_numeroFactura",
                table: "FacturaProducto");

            migrationBuilder.DropForeignKey(
                name: "FK_FacturaProducto_Productos_codigoProducto",
                table: "FacturaProducto");

            migrationBuilder.DropForeignKey(
                name: "FK_Facturas_Clientes_codigoCliente",
                table: "Facturas");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Facturas_Clientes_codigoCliente",
                table: "Facturas",
                column: "codigoCliente",
                principalTable: "Clientes",
                principalColumn: "codigoCliente",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
