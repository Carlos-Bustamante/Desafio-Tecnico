﻿// <auto-generated />
using Desafio_Tecnico.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Desafio_Tecnico.Migrations
{
    [DbContext(typeof(TestContext))]
    [Migration("20240614113513_COrrectionDescription")]
    partial class COrrectionDescription
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Desafio_Tecnico.Models.Entities.Producto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("IdTipoProducto")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("VARCHAR(50)")
                        .HasColumnName("NOMBRE");

                    b.Property<float>("Precio")
                        .HasColumnType("real")
                        .HasColumnName("PRECIO");

                    b.HasKey("Id");

                    b.ToTable("Productos");
                });

            modelBuilder.Entity("Desafio_Tecnico.Models.Entities.Stock", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Cantidad")
                        .HasColumnType("int")
                        .HasColumnName("CANTIDAD");

                    b.Property<int>("IdProducto")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdProducto")
                        .IsUnique();

                    b.ToTable("Stocks");
                });

            modelBuilder.Entity("Desafio_Tecnico.Models.Entities.TipoProducto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descripcion")
                        .HasColumnType("VARCHAR(200)")
                        .HasColumnName("DESCRIPCION");

                    b.HasKey("Id");

                    b.ToTable("TipoProductos");
                });

            modelBuilder.Entity("ProductoTipoProducto", b =>
                {
                    b.Property<int>("IdTipoProducto")
                        .HasColumnType("int");

                    b.Property<int>("TipoProductosId")
                        .HasColumnType("int");

                    b.HasKey("IdTipoProducto", "TipoProductosId");

                    b.HasIndex("TipoProductosId");

                    b.ToTable("ProductoTipoProducto");
                });

            modelBuilder.Entity("Desafio_Tecnico.Models.Entities.Stock", b =>
                {
                    b.HasOne("Desafio_Tecnico.Models.Entities.Producto", "Producto")
                        .WithOne("Stock")
                        .HasForeignKey("Desafio_Tecnico.Models.Entities.Stock", "IdProducto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Producto");
                });

            modelBuilder.Entity("ProductoTipoProducto", b =>
                {
                    b.HasOne("Desafio_Tecnico.Models.Entities.Producto", null)
                        .WithMany()
                        .HasForeignKey("IdTipoProducto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Desafio_Tecnico.Models.Entities.TipoProducto", null)
                        .WithMany()
                        .HasForeignKey("TipoProductosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Desafio_Tecnico.Models.Entities.Producto", b =>
                {
                    b.Navigation("Stock");
                });
#pragma warning restore 612, 618
        }
    }
}
