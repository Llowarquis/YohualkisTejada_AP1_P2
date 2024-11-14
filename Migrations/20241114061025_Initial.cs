using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YohualkisTejada_AP1_P2.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MyProperty",
                columns: table => new
                {
                    ModeloId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sueldo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MyProperty", x => x.ModeloId);
                });

            migrationBuilder.CreateTable(
                name: "ModeloDetalles",
                columns: table => new
                {
                    DetalleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    ModelosModeloId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModeloDetalles", x => x.DetalleId);
                    table.ForeignKey(
                        name: "FK_ModeloDetalles_MyProperty_ModelosModeloId",
                        column: x => x.ModelosModeloId,
                        principalTable: "MyProperty",
                        principalColumn: "ModeloId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ModeloDetalles_ModelosModeloId",
                table: "ModeloDetalles",
                column: "ModelosModeloId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ModeloDetalles");

            migrationBuilder.DropTable(
                name: "MyProperty");
        }
    }
}
