using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace YohualkisTejada_AP1_P2.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ArticulosModelos",
                columns: table => new
                {
                    ArticuloId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Costo = table.Column<double>(type: "float", nullable: false),
                    Precio = table.Column<double>(type: "float", nullable: false),
                    Existencia = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticulosModelos", x => x.ArticuloId);
                });

            migrationBuilder.CreateTable(
                name: "Modelos",
                columns: table => new
                {
                    ModeloId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sueldo = table.Column<int>(type: "int", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modelos", x => x.ModeloId);
                });

            migrationBuilder.CreateTable(
                name: "ModelosDetalles",
                columns: table => new
                {
                    DetalleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    Precio = table.Column<double>(type: "float", nullable: false),
                    ArticuloId = table.Column<int>(type: "int", nullable: false),
                    ModeloId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModelosDetalles", x => x.DetalleId);
                    table.ForeignKey(
                        name: "FK_ModelosDetalles_ArticulosModelos_ArticuloId",
                        column: x => x.ArticuloId,
                        principalTable: "ArticulosModelos",
                        principalColumn: "ArticuloId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ModelosDetalles_Modelos_ModeloId",
                        column: x => x.ModeloId,
                        principalTable: "Modelos",
                        principalColumn: "ModeloId");
                });

            migrationBuilder.InsertData(
                table: "ArticulosModelos",
                columns: new[] { "ArticuloId", "Costo", "Descripcion", "Existencia", "Precio" },
                values: new object[,]
                {
                    { 1, 1999.99, "Articulo 1", 51, 1999.99 },
                    { 2, 3999.9899999999998, "Articulo 2", 64, 9999.9899999999998 },
                    { 3, 559.99000000000001, "Articulo 3", 85, 5449.9899999999998 },
                    { 4, 7599.9899999999998, "Articulo 4", 71, 4599.9899999999998 },
                    { 5, 5769.8000000000002, "Articulo 5", 84, 2699.5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ModelosDetalles_ArticuloId",
                table: "ModelosDetalles",
                column: "ArticuloId");

            migrationBuilder.CreateIndex(
                name: "IX_ModelosDetalles_ModeloId",
                table: "ModelosDetalles",
                column: "ModeloId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ModelosDetalles");

            migrationBuilder.DropTable(
                name: "ArticulosModelos");

            migrationBuilder.DropTable(
                name: "Modelos");
        }
    }
}
