using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebNotas.Migrations
{
    /// <inheritdoc />
    public partial class AgregamosImagenALasNotas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "Imagen",
                table: "Notas",
                type: "longblob",
                nullable: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Imagen",
                table: "Notas");
        }
    }
}
