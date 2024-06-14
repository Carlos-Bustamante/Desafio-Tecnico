using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Desafio_Tecnico.Migrations
{
    /// <inheritdoc />
    public partial class COrrectionDescription : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "DESCRIPCION",
                table: "TipoProductos",
                type: "VARCHAR(200)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "DESCRIPCION",
                table: "TipoProductos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(200)",
                oldNullable: true);
        }
    }
}
