﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using YohualkisTejada_AP1_P2.DAL;

#nullable disable

namespace YohualkisTejada_AP1_P2.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("YohualkisTejada_AP1_P2.Models.ModeloDetalles", b =>
                {
                    b.Property<int>("DetalleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DetalleId"));

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<int?>("ModelosModeloId")
                        .HasColumnType("int");

                    b.HasKey("DetalleId");

                    b.HasIndex("ModelosModeloId");

                    b.ToTable("ModeloDetalles");
                });

            modelBuilder.Entity("YohualkisTejada_AP1_P2.Models.Modelos", b =>
                {
                    b.Property<int>("ModeloId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ModeloId"));

                    b.Property<string>("Nombres")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Sueldo")
                        .HasColumnType("int");

                    b.HasKey("ModeloId");

                    b.ToTable("MyProperty");
                });

            modelBuilder.Entity("YohualkisTejada_AP1_P2.Models.ModeloDetalles", b =>
                {
                    b.HasOne("YohualkisTejada_AP1_P2.Models.Modelos", null)
                        .WithMany("Detalles")
                        .HasForeignKey("ModelosModeloId");
                });

            modelBuilder.Entity("YohualkisTejada_AP1_P2.Models.Modelos", b =>
                {
                    b.Navigation("Detalles");
                });
#pragma warning restore 612, 618
        }
    }
}