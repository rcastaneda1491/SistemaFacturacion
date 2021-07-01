﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SistemaFacturacion.DB;

namespace SistemaFacturacion.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210630030427_quintamigracion")]
    partial class quintamigracion
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SistemaFacturacion.Models.Cliente", b =>
                {
                    b.Property<int>("codigoCliente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("activo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("apellidos")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nit")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombres")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("codigoCliente");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("SistemaFacturacion.Models.Factura", b =>
                {
                    b.Property<int>("numeroFactura")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("anulada")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("codigoCliente")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<DateTime>("fecha")
                        .HasColumnType("datetime2");

                    b.Property<double>("totalFactura")
                        .HasColumnType("float");

                    b.HasKey("numeroFactura");

                    b.HasIndex("codigoCliente");

                    b.ToTable("Facturas");
                });

            modelBuilder.Entity("SistemaFacturacion.Models.FacturaProducto", b =>
                {
                    b.Property<int?>("numeroFactura")
                        .HasColumnType("int");

                    b.Property<int?>("codigoProducto")
                        .HasColumnType("int");

                    b.Property<int>("cantidad")
                        .HasColumnType("int");

                    b.Property<double>("precioUnitario")
                        .HasColumnType("float");

                    b.HasKey("numeroFactura", "codigoProducto");

                    b.HasIndex("codigoProducto");

                    b.ToTable("FacturaProducto");
                });

            modelBuilder.Entity("SistemaFacturacion.Models.Producto", b =>
                {
                    b.Property<int>("codigoProducto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("activo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("costo")
                        .HasColumnType("float");

                    b.Property<string>("descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("existencia")
                        .HasColumnType("int");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("precio")
                        .HasColumnType("float");

                    b.HasKey("codigoProducto");

                    b.ToTable("Productos");
                });

            modelBuilder.Entity("SistemaFacturacion.Models.Usuario", b =>
                {
                    b.Property<int>("idUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("user")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idUsuario");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("SistemaFacturacion.Models.Factura", b =>
                {
                    b.HasOne("SistemaFacturacion.Models.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("codigoCliente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("SistemaFacturacion.Models.FacturaProducto", b =>
                {
                    b.HasOne("SistemaFacturacion.Models.Producto", "Productos")
                        .WithMany()
                        .HasForeignKey("codigoProducto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SistemaFacturacion.Models.Factura", "Factura")
                        .WithMany()
                        .HasForeignKey("numeroFactura")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Factura");

                    b.Navigation("Productos");
                });
#pragma warning restore 612, 618
        }
    }
}
