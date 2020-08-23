using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace bitzen.Data.Migrations
{
    public partial class Classesveiculosabastecimento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Veiculos",
                columns: table => new
                {
                    VeiculoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Marca = table.Column<string>(maxLength: 100, nullable: false),
                    Modelo = table.Column<string>(maxLength: 100, nullable: false),
                    Ano = table.Column<int>(maxLength: 4, nullable: false),
                    Placa = table.Column<string>(maxLength: 8, nullable: false),
                    TipoVeiculo = table.Column<string>(maxLength: 100, nullable: false),
                    TipoCombustivel = table.Column<string>(maxLength: 100, nullable: false),
                    Imagem = table.Column<string>(nullable: false),
                    Km = table.Column<int>(maxLength: 10, nullable: false),
                    IdUser = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Veiculos", x => x.VeiculoId);
                });

            migrationBuilder.CreateTable(
                name: "Abastecimentos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Km = table.Column<int>(maxLength: 10, nullable: false),
                    Litros = table.Column<decimal>(maxLength: 10, nullable: false),
                    Valor = table.Column<decimal>(maxLength: 10, nullable: false),
                    DataAbastecimento = table.Column<DateTime>(nullable: false),
                    Posto = table.Column<string>(maxLength: 100, nullable: false),
                    IdUser = table.Column<string>(nullable: true),
                    Tipo = table.Column<string>(maxLength: 100, nullable: false),
                    VeiculoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abastecimentos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Abastecimentos_Veiculos_VeiculoId",
                        column: x => x.VeiculoId,
                        principalTable: "Veiculos",
                        principalColumn: "VeiculoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Abastecimentos_VeiculoId",
                table: "Abastecimentos",
                column: "VeiculoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Abastecimentos");

            migrationBuilder.DropTable(
                name: "Veiculos");
        }
    }
}
