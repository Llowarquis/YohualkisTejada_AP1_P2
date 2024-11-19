﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using YohualkisTejada_AP1_P2.DAL;

#nullable disable

namespace YohualkisTejada_AP1_P2.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20241118234412_2doParcial")]
    partial class _2doParcial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("YohualkisTejada_AP1_P2.Models.ArticulosPC", b =>
                {
                    b.Property<int>("ArticuloId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ArticuloId"));

                    b.Property<double>("Costo")
                        .HasColumnType("float");

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Existencia")
                        .HasColumnType("int");

                    b.Property<double>("Precio")
                        .HasColumnType("float");

                    b.HasKey("ArticuloId");

                    b.ToTable("ArticulosModelos");

                    b.HasData(
                        new
                        {
                            ArticuloId = 1,
                            Costo = 1999.99,
                            Descripcion = "Modulos RAM",
                            Existencia = 51,
                            Precio = 1999.99
                        },
                        new
                        {
                            ArticuloId = 2,
                            Costo = 3999.9899999999998,
                            Descripcion = "CPU",
                            Existencia = 64,
                            Precio = 9999.9899999999998
                        },
                        new
                        {
                            ArticuloId = 3,
                            Costo = 559.99000000000001,
                            Descripcion = "Motherboards",
                            Existencia = 85,
                            Precio = 5449.9899999999998
                        },
                        new
                        {
                            ArticuloId = 4,
                            Costo = 7599.9899999999998,
                            Descripcion = "Power Suplies",
                            Existencia = 71,
                            Precio = 4599.9899999999998
                        },
                        new
                        {
                            ArticuloId = 5,
                            Costo = 5769.8000000000002,
                            Descripcion = "Tarjetas de Video",
                            Existencia = 84,
                            Precio = 2699.5
                        },
                        new
                        {
                            ArticuloId = 6,
                            Costo = 1500.0,
                            Descripcion = "Cases",
                            Existencia = 125,
                            Precio = 3700.0
                        });
                });

            modelBuilder.Entity("YohualkisTejada_AP1_P2.Models.Combos", b =>
                {
                    b.Property<int>("ComboId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ComboId"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EstaVendido")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<double>("Precio")
                        .HasColumnType("float");

                    b.HasKey("ComboId");

                    b.ToTable("Modelos");
                });

            modelBuilder.Entity("YohualkisTejada_AP1_P2.Models.CombosDetalles", b =>
                {
                    b.Property<int>("DetalleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DetalleId"));

                    b.Property<int>("ArticuloId")
                        .HasColumnType("int");

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<int>("ComboId")
                        .HasColumnType("int");

                    b.Property<double>("Precio")
                        .HasColumnType("float");

                    b.HasKey("DetalleId");

                    b.HasIndex("ComboId");

                    b.ToTable("ModelosDetalles");
                });

            modelBuilder.Entity("YohualkisTejada_AP1_P2.Models.CombosDetalles", b =>
                {
                    b.HasOne("YohualkisTejada_AP1_P2.Models.Combos", null)
                        .WithMany("Detalles")
                        .HasForeignKey("ComboId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("YohualkisTejada_AP1_P2.Models.Combos", b =>
                {
                    b.Navigation("Detalles");
                });
#pragma warning restore 612, 618
        }
    }
}
