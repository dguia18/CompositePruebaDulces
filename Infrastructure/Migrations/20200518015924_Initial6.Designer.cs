﻿// <auto-generated />
using System;
using Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Infrastructure.Migrations
{
    [DbContext(typeof(DulcesYmasContext))]
    [Migration("20200518015924_Initial6")]
    partial class Initial6
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Domain.Entities.Compra", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ProveedorId")
                        .HasColumnType("int");

                    b.Property<double>("Total")
                        .HasColumnType("float");

                    b.Property<int?>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProveedorId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Compras");
                });

            modelBuilder.Entity("Domain.Entities.CompraDetalle", b =>
                {
                    b.Property<int>("ProductoId")
                        .HasColumnType("int");

                    b.Property<int>("CompraId")
                        .HasColumnType("int");

                    b.Property<double>("Cantidad")
                        .HasColumnType("float");

                    b.Property<double>("Valor")
                        .HasColumnType("float");

                    b.HasKey("ProductoId", "CompraId");

                    b.HasIndex("CompraId");

                    b.ToTable("CompraDetalles");
                });

            modelBuilder.Entity("Domain.Entities.Fabricacion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Cantidad")
                        .HasColumnType("float");

                    b.Property<double>("Costo")
                        .HasColumnType("float");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ProductoId")
                        .HasColumnType("int");

                    b.Property<int?>("TerceroEmpleadoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductoId");

                    b.HasIndex("TerceroEmpleadoId");

                    b.ToTable("Fabricaciones");
                });

            modelBuilder.Entity("Domain.Entities.ProductoSubCategoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProductoSubCategoriaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductoSubCategoriaId");

                    b.ToTable("ProductoSubCategoria");
                });

            modelBuilder.Entity("Domain.Entities.Rol", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TerceroUsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TerceroUsuarioId");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Domain.Entities.Tercero.Contacto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroCelular")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TerceroId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TerceroId");

                    b.ToTable("Contacto");
                });

            modelBuilder.Entity("Domain.Entities.Tercero.Tercero", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nit")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RazonSocial")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Terceros");
                });

            modelBuilder.Entity("Domain.Entities.Tercero.TerceroEmpleado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<int?>("TerceroId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TerceroId");

                    b.ToTable("TercerosEmpleados");
                });

            modelBuilder.Entity("Domain.Entities.Tercero.TerceroPropietario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<int?>("TerceroId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TerceroId");

                    b.ToTable("TercerosPropietario");
                });

            modelBuilder.Entity("Domain.Entities.Tercero.TerceroProvedor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<int?>("TerceroId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TerceroId");

                    b.ToTable("TercerosProvedor");
                });

            modelBuilder.Entity("Domain.Entities.Tercero.TerceroUsuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TerceroId")
                        .HasColumnType("int");

                    b.Property<string>("Usuario")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("TerceroId");

                    b.ToTable("TerceroUsuarios");
                });

            modelBuilder.Entity("Domain.FabricacionDetalle", b =>
                {
                    b.Property<int>("FabricacionId")
                        .HasColumnType("int");

                    b.Property<int>("MateriaPrimaId")
                        .HasColumnType("int");

                    b.Property<double>("Cantidad")
                        .HasColumnType("float");

                    b.Property<double>("Costo")
                        .HasColumnType("float");

                    b.Property<int?>("ProductoMateriaPrimaId")
                        .HasColumnType("int");

                    b.HasKey("FabricacionId", "MateriaPrimaId");

                    b.HasIndex("MateriaPrimaId");

                    b.HasIndex("ProductoMateriaPrimaId");

                    b.ToTable("FabricacionDetalles");
                });

            modelBuilder.Entity("Domain.Producto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Cantidad")
                        .HasColumnType("float");

                    b.Property<int>("Contestura")
                        .HasColumnType("int");

                    b.Property<double>("CostoUnitario")
                        .HasColumnType("float");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Envoltorio")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("PorcentajeDeUtilidad")
                        .HasColumnType("float");

                    b.Property<int?>("SubCategoriaId")
                        .HasColumnType("int");

                    b.Property<int?>("TerceroPropietarioId")
                        .HasColumnType("int");

                    b.Property<int>("UnidadDeMedida")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SubCategoriaId");

                    b.HasIndex("TerceroPropietarioId");

                    b.ToTable("Producto");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Producto");
                });

            modelBuilder.Entity("Domain.ProductoParaVenderDetalle", b =>
                {
                    b.Property<int>("ProductoParaVenderId")
                        .HasColumnType("int");

                    b.Property<int>("ProductoParaFabricarId")
                        .HasColumnType("int");

                    b.Property<double>("Cantidad")
                        .HasColumnType("float");

                    b.Property<double>("Costo")
                        .HasColumnType("float");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.HasKey("ProductoParaVenderId", "ProductoParaFabricarId");

                    b.HasIndex("ProductoParaFabricarId");

                    b.ToTable("ProductosParaVenderDetalles");
                });

            modelBuilder.Entity("Domain.ProductoMateriaPrima", b =>
                {
                    b.HasBaseType("Domain.Producto");

                    b.HasDiscriminator().HasValue("ProductoMateriaPrima");
                });

            modelBuilder.Entity("Domain.ProductoParaFabricar", b =>
                {
                    b.HasBaseType("Domain.Producto");

                    b.HasDiscriminator().HasValue("ProductoParaFabricar");
                });

            modelBuilder.Entity("Domain.ProductoParaVender", b =>
                {
                    b.HasBaseType("Domain.Producto");

                    b.Property<int?>("EnvoltorioProductoId")
                        .HasColumnType("int");

                    b.HasIndex("EnvoltorioProductoId");

                    b.HasDiscriminator().HasValue("ProductoParaVender");
                });

            modelBuilder.Entity("Domain.ProductoParaFabricarDuro", b =>
                {
                    b.HasBaseType("Domain.ProductoParaFabricar");

                    b.HasDiscriminator().HasValue("ProductoParaFabricarDuro");
                });

            modelBuilder.Entity("Domain.ProductoParaFabricarSuave", b =>
                {
                    b.HasBaseType("Domain.ProductoParaFabricar");

                    b.HasDiscriminator().HasValue("ProductoParaFabricarSuave");
                });

            modelBuilder.Entity("Domain.ProductoParaVenderConEnvoltorio", b =>
                {
                    b.HasBaseType("Domain.ProductoParaVender");

                    b.HasDiscriminator().HasValue("ProductoParaVenderConEnvoltorio");
                });

            modelBuilder.Entity("Domain.ProductoParaVenderSinEnvoltorio", b =>
                {
                    b.HasBaseType("Domain.ProductoParaVender");

                    b.HasDiscriminator().HasValue("ProductoParaVenderSinEnvoltorio");
                });

            modelBuilder.Entity("Domain.Entities.Compra", b =>
                {
                    b.HasOne("Domain.Entities.Tercero.TerceroProvedor", "Proveedor")
                        .WithMany()
                        .HasForeignKey("ProveedorId");

                    b.HasOne("Domain.Entities.Tercero.TerceroUsuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId");
                });

            modelBuilder.Entity("Domain.Entities.CompraDetalle", b =>
                {
                    b.HasOne("Domain.Entities.Compra", "Compra")
                        .WithMany("DetallesCompra")
                        .HasForeignKey("CompraId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Producto", "Producto")
                        .WithMany("DetallesCompra")
                        .HasForeignKey("ProductoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Entities.Fabricacion", b =>
                {
                    b.HasOne("Domain.Producto", null)
                        .WithMany("Fabricaciones")
                        .HasForeignKey("ProductoId");

                    b.HasOne("Domain.Entities.Tercero.TerceroEmpleado", "TerceroEmpleado")
                        .WithMany("Fabricaciones")
                        .HasForeignKey("TerceroEmpleadoId");
                });

            modelBuilder.Entity("Domain.Entities.ProductoSubCategoria", b =>
                {
                    b.HasOne("Domain.Entities.ProductoSubCategoria", null)
                        .WithMany("SubCategorias")
                        .HasForeignKey("ProductoSubCategoriaId");
                });

            modelBuilder.Entity("Domain.Entities.Rol", b =>
                {
                    b.HasOne("Domain.Entities.Tercero.TerceroUsuario", null)
                        .WithMany("Roles")
                        .HasForeignKey("TerceroUsuarioId");
                });

            modelBuilder.Entity("Domain.Entities.Tercero.Contacto", b =>
                {
                    b.HasOne("Domain.Entities.Tercero.Tercero", null)
                        .WithMany("Contactos")
                        .HasForeignKey("TerceroId");
                });

            modelBuilder.Entity("Domain.Entities.Tercero.TerceroEmpleado", b =>
                {
                    b.HasOne("Domain.Entities.Tercero.Tercero", "Tercero")
                        .WithMany()
                        .HasForeignKey("TerceroId");
                });

            modelBuilder.Entity("Domain.Entities.Tercero.TerceroPropietario", b =>
                {
                    b.HasOne("Domain.Entities.Tercero.Tercero", "Tercero")
                        .WithMany()
                        .HasForeignKey("TerceroId");
                });

            modelBuilder.Entity("Domain.Entities.Tercero.TerceroProvedor", b =>
                {
                    b.HasOne("Domain.Entities.Tercero.Tercero", "Tercero")
                        .WithMany()
                        .HasForeignKey("TerceroId");
                });

            modelBuilder.Entity("Domain.Entities.Tercero.TerceroUsuario", b =>
                {
                    b.HasOne("Domain.Entities.Tercero.Tercero", "Tercero")
                        .WithMany()
                        .HasForeignKey("TerceroId");
                });

            modelBuilder.Entity("Domain.FabricacionDetalle", b =>
                {
                    b.HasOne("Domain.Entities.Fabricacion", "Fabricacion")
                        .WithMany("FabricacionDetalles")
                        .HasForeignKey("FabricacionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Producto", "MateriaPrima")
                        .WithMany()
                        .HasForeignKey("MateriaPrimaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.ProductoMateriaPrima", null)
                        .WithMany("FabricacionDetalles")
                        .HasForeignKey("ProductoMateriaPrimaId");
                });

            modelBuilder.Entity("Domain.Producto", b =>
                {
                    b.HasOne("Domain.Entities.ProductoSubCategoria", "SubCategoria")
                        .WithMany()
                        .HasForeignKey("SubCategoriaId");

                    b.HasOne("Domain.Entities.Tercero.TerceroPropietario", null)
                        .WithMany("Productos")
                        .HasForeignKey("TerceroPropietarioId");
                });

            modelBuilder.Entity("Domain.ProductoParaVenderDetalle", b =>
                {
                    b.HasOne("Domain.ProductoParaFabricar", "ProductoParaFabricar")
                        .WithMany("ProductoParaVenderDetalles")
                        .HasForeignKey("ProductoParaFabricarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.ProductoParaVender", "ProductoParaVender")
                        .WithMany()
                        .HasForeignKey("ProductoParaVenderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.ProductoParaVender", b =>
                {
                    b.HasOne("Domain.Producto", "EnvoltorioProducto")
                        .WithMany()
                        .HasForeignKey("EnvoltorioProductoId");
                });
#pragma warning restore 612, 618
        }
    }
}
