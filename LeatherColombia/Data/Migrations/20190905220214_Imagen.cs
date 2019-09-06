using Microsoft.EntityFrameworkCore.Migrations;

namespace LeatherColombia.Data.Migrations
{
    public partial class Imagen : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Imagen",
                table: "Producto",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Imagen",
                table: "Producto");
        }
    }
}
