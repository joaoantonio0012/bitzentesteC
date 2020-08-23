using Microsoft.EntityFrameworkCore.Migrations;

namespace bitzen.Data.Migrations
{
    public partial class Classesveiculosabasteciment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Imagem",
                table: "Veiculos",
                nullable: true,
                oldClrType: typeof(string));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Imagem",
                table: "Veiculos",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
