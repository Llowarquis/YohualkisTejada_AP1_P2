using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YohualkisTejada_AP1_P2.Migrations
{
    /// <inheritdoc />
    public partial class _2doParcial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ModelosDetalles_ArticulosModelos_ArticuloId",
                table: "ModelosDetalles");

            migrationBuilder.DropForeignKey(
                name: "FK_ModelosDetalles_Modelos_ModeloId",
                table: "ModelosDetalles");

            migrationBuilder.DropIndex(
                name: "IX_ModelosDetalles_ArticuloId",
                table: "ModelosDetalles");

            migrationBuilder.DropIndex(
                name: "IX_ModelosDetalles_ModeloId",
                table: "ModelosDetalles");

            migrationBuilder.DropColumn(
                name: "ModeloId",
                table: "ModelosDetalles");

            migrationBuilder.DropColumn(
                name: "Sueldo",
                table: "Modelos");

            migrationBuilder.RenameColumn(
                name: "Nombres",
                table: "Modelos",
                newName: "Descripcion");

            migrationBuilder.RenameColumn(
                name: "ModeloId",
                table: "Modelos",
                newName: "ComboId");

            migrationBuilder.AddColumn<int>(
                name: "ComboId",
                table: "ModelosDetalles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "EstaVendido",
                table: "Modelos",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<double>(
                name: "Precio",
                table: "Modelos",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.UpdateData(
                table: "ArticulosModelos",
                keyColumn: "ArticuloId",
                keyValue: 1,
                column: "Descripcion",
                value: "Modulos RAM");

            migrationBuilder.UpdateData(
                table: "ArticulosModelos",
                keyColumn: "ArticuloId",
                keyValue: 2,
                column: "Descripcion",
                value: "CPU");

            migrationBuilder.UpdateData(
                table: "ArticulosModelos",
                keyColumn: "ArticuloId",
                keyValue: 3,
                column: "Descripcion",
                value: "Motherboards");

            migrationBuilder.UpdateData(
                table: "ArticulosModelos",
                keyColumn: "ArticuloId",
                keyValue: 4,
                column: "Descripcion",
                value: "Power Suplies");

            migrationBuilder.UpdateData(
                table: "ArticulosModelos",
                keyColumn: "ArticuloId",
                keyValue: 5,
                column: "Descripcion",
                value: "Tarjetas de Video");

            migrationBuilder.InsertData(
                table: "ArticulosModelos",
                columns: new[] { "ArticuloId", "Costo", "Descripcion", "Existencia", "Precio" },
                values: new object[] { 6, 1500.0, "Cases", 125, 3700.0 });

            migrationBuilder.CreateIndex(
                name: "IX_ModelosDetalles_ComboId",
                table: "ModelosDetalles",
                column: "ComboId");

            migrationBuilder.AddForeignKey(
                name: "FK_ModelosDetalles_Modelos_ComboId",
                table: "ModelosDetalles",
                column: "ComboId",
                principalTable: "Modelos",
                principalColumn: "ComboId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ModelosDetalles_Modelos_ComboId",
                table: "ModelosDetalles");

            migrationBuilder.DropIndex(
                name: "IX_ModelosDetalles_ComboId",
                table: "ModelosDetalles");

            migrationBuilder.DeleteData(
                table: "ArticulosModelos",
                keyColumn: "ArticuloId",
                keyValue: 6);

            migrationBuilder.DropColumn(
                name: "ComboId",
                table: "ModelosDetalles");

            migrationBuilder.DropColumn(
                name: "EstaVendido",
                table: "Modelos");

            migrationBuilder.DropColumn(
                name: "Precio",
                table: "Modelos");

            migrationBuilder.RenameColumn(
                name: "Descripcion",
                table: "Modelos",
                newName: "Nombres");

            migrationBuilder.RenameColumn(
                name: "ComboId",
                table: "Modelos",
                newName: "ModeloId");

            migrationBuilder.AddColumn<int>(
                name: "ModeloId",
                table: "ModelosDetalles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Sueldo",
                table: "Modelos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "ArticulosModelos",
                keyColumn: "ArticuloId",
                keyValue: 1,
                column: "Descripcion",
                value: "Articulo 1");

            migrationBuilder.UpdateData(
                table: "ArticulosModelos",
                keyColumn: "ArticuloId",
                keyValue: 2,
                column: "Descripcion",
                value: "Articulo 2");

            migrationBuilder.UpdateData(
                table: "ArticulosModelos",
                keyColumn: "ArticuloId",
                keyValue: 3,
                column: "Descripcion",
                value: "Articulo 3");

            migrationBuilder.UpdateData(
                table: "ArticulosModelos",
                keyColumn: "ArticuloId",
                keyValue: 4,
                column: "Descripcion",
                value: "Articulo 4");

            migrationBuilder.UpdateData(
                table: "ArticulosModelos",
                keyColumn: "ArticuloId",
                keyValue: 5,
                column: "Descripcion",
                value: "Articulo 5");

            migrationBuilder.CreateIndex(
                name: "IX_ModelosDetalles_ArticuloId",
                table: "ModelosDetalles",
                column: "ArticuloId");

            migrationBuilder.CreateIndex(
                name: "IX_ModelosDetalles_ModeloId",
                table: "ModelosDetalles",
                column: "ModeloId");

            migrationBuilder.AddForeignKey(
                name: "FK_ModelosDetalles_ArticulosModelos_ArticuloId",
                table: "ModelosDetalles",
                column: "ArticuloId",
                principalTable: "ArticulosModelos",
                principalColumn: "ArticuloId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ModelosDetalles_Modelos_ModeloId",
                table: "ModelosDetalles",
                column: "ModeloId",
                principalTable: "Modelos",
                principalColumn: "ModeloId");
        }
    }
}
