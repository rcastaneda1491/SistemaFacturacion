using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemaFacturacion.Migrations
{
    public partial class primeraMigracion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    codigoCliente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    apellidos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    telefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    activo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.codigoCliente);
                });

            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    codigoProducto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    precio = table.Column<double>(type: "float", nullable: false),
                    costo = table.Column<double>(type: "float", nullable: false),
                    existencia = table.Column<int>(type: "int", nullable: false),
                    activo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.codigoProducto);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    idUsuario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    user = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.idUsuario);
                });

            migrationBuilder.CreateTable(
                name: "Facturas",
                columns: table => new
                {
                    numeroFactura = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    totalFactura = table.Column<double>(type: "float", nullable: false),
                    anulada = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    codigoCliente = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Facturas", x => x.numeroFactura);
                    table.ForeignKey(
                        name: "FK_Facturas_Clientes_codigoCliente",
                        column: x => x.codigoCliente,
                        principalTable: "Clientes",
                        principalColumn: "codigoCliente",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Factura_Productos",
                columns: table => new
                {
                    numeroFactura = table.Column<int>(type: "int", nullable: false),
                    codigoProducto = table.Column<int>(type: "int", nullable: false),
                    cantidad = table.Column<int>(type: "int", nullable: false),
                    precioUnitario = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Factura_Productos", x => new { x.numeroFactura, x.codigoProducto });
                    table.ForeignKey(
                        name: "FK_Factura_Productos_Facturas_numeroFactura",
                        column: x => x.numeroFactura,
                        principalTable: "Facturas",
                        principalColumn: "numeroFactura",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Factura_Productos_Productos_codigoProducto",
                        column: x => x.codigoProducto,
                        principalTable: "Productos",
                        principalColumn: "codigoProducto",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Factura_Productos_codigoProducto",
                table: "Factura_Productos",
                column: "codigoProducto");

            migrationBuilder.CreateIndex(
                name: "IX_Facturas_codigoCliente",
                table: "Facturas",
                column: "codigoCliente");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Factura_Productos");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Facturas");

            migrationBuilder.DropTable(
                name: "Productos");

            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}
