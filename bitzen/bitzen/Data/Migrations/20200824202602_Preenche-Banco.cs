using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace bitzen.Data.Migrations
{
    public partial class PreencheBanco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Veiculos",
                columns: new[] { "VeiculoId", "Ano", "IdUser", "Imagem", "Km", "Marca", "Modelo", "Placa", "TipoCombustivel", "TipoVeiculo" },
                values: new object[] { 1, 2020, "luizchequini@gmail.com", "\\Uploads\\Imagens\\\\b48951a3-d607-441e-a7b6-020f93d099ba.jpg", 100, "Volkswagem", "Fusca", "XXX-1234", "Gasolina", "Passeio" });

            migrationBuilder.InsertData(
                table: "Veiculos",
                columns: new[] { "VeiculoId", "Ano", "IdUser", "Imagem", "Km", "Marca", "Modelo", "Placa", "TipoCombustivel", "TipoVeiculo" },
                values: new object[] { 2, 2020, "joaoantonio@gmail.com", "\\Uploads\\Imagens\\\\b48951a3-d607-441e-a7b6-020f93d099ba.jpg", 10, "Honda", "Civic", "CDE-4568", "Alcool", "Passeio" });

            migrationBuilder.InsertData(
                table: "Abastecimentos",
                columns: new[] { "Id", "DataAbastecimento", "IdUser", "Km", "Litros", "Posto", "Tipo", "Valor", "VeiculoId" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "luizchequini@gmail.com", 100, 10m, "Posto do Chimbica", "Gasolina", 10m, 1 },
                    { 26, new DateTime(2020, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "luizchequini@gmail.com", 100, 10m, "Posto do Chimbica", "Gasolina", 10m, 1 },
                    { 27, new DateTime(2020, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "luizchequini@gmail.com", 100, 10m, "Posto do Chimbica", "Gasolina", 10m, 1 },
                    { 28, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "luizchequini@gmail.com", 100, 10m, "Posto do Chimbica", "Gasolina", 10m, 1 },
                    { 29, new DateTime(2020, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "luizchequini@gmail.com", 100, 10m, "Posto do Chimbica", "Gasolina", 10m, 1 },
                    { 30, new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "luizchequini@gmail.com", 100, 10m, "Posto do Chimbica", "Gasolina", 10m, 1 },
                    { 31, new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "luizchequini@gmail.com", 100, 10m, "Posto do Chimbica", "Gasolina", 10m, 1 },
                    { 32, new DateTime(2020, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "luizchequini@gmail.com", 100, 10m, "Posto do Chimbica", "Gasolina", 10m, 1 },
                    { 33, new DateTime(2020, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "luizchequini@gmail.com", 100, 10m, "Posto do Chimbica", "Gasolina", 10m, 1 },
                    { 34, new DateTime(2020, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "luizchequini@gmail.com", 100, 10m, "Posto do Chimbica", "Gasolina", 10m, 1 },
                    { 25, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "luizchequini@gmail.com", 100, 10m, "Posto do Chimbica", "Gasolina", 10m, 1 },
                    { 35, new DateTime(2020, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "luizchequini@gmail.com", 100, 10m, "Posto do Chimbica", "Gasolina", 10m, 1 },
                    { 37, new DateTime(2020, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "joaoantonio@gmail.com", 100, 1000m, "Posto do Chimbica", "Gasolina", 35m, 2 },
                    { 38, new DateTime(2020, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "joaoantonio@gmail.com", 100, 90m, "Posto do Chimbica", "Gasolina", 88m, 2 },
                    { 39, new DateTime(2020, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "joaoantonio@gmail.com", 500, 50m, "Posto do Chimbica", "Gasolina", 90m, 2 },
                    { 40, new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "joaoantonio@gmail.com", 900, 100m, "Posto do Chimbica", "Gasolina", 190m, 2 },
                    { 41, new DateTime(2020, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "joaoantonio@gmail.com", 1000, 139m, "Posto do Chimbica", "Gasolina", 290m, 2 },
                    { 42, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "joaoantonio@gmail.com", 1100, 100m, "Posto do Chimbica", "Gasolina", 490m, 2 },
                    { 43, new DateTime(2020, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "joaoantonio@gmail.com", 600, 200m, "Posto do Chimbica", "Gasolina", 290m, 2 },
                    { 44, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "joaoantonio@gmail.com", 300, 230m, "Posto do Chimbica", "Gasolina", 590m, 2 },
                    { 45, new DateTime(2020, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "joaoantonio@gmail.com", 300, 430m, "Posto do Chimbica", "Gasolina", 790m, 2 },
                    { 36, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "joaoantonio@gmail.com", 100, 200m, "Posto do Chimbica", "Gasolina", 830m, 2 },
                    { 46, new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "joaoantonio@gmail.com", 300, 130m, "Posto do Chimbica", "Gasolina", 590m, 2 },
                    { 24, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "luizchequini@gmail.com", 100, 10m, "Posto do Chimbica", "Gasolina", 10m, 1 },
                    { 22, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "luizchequini@gmail.com", 100, 10m, "Posto do Chimbica", "Gasolina", 10m, 1 },
                    { 2, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "luizchequini@gmail.com", 100, 100m, "Posto do Chimbica", "Gasolina", 100m, 1 },
                    { 3, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "luizchequini@gmail.com", 100, 150m, "Posto do Chimbica", "Gasolina", 150m, 1 },
                    { 4, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "luizchequini@gmail.com", 100, 10m, "Posto do Chimbica", "Gasolina", 10m, 1 },
                    { 5, new DateTime(2020, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "luizchequini@gmail.com", 100, 10m, "Posto do Chimbica", "Gasolina", 10m, 1 },
                    { 6, new DateTime(2020, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "luizchequini@gmail.com", 100, 10m, "Posto do Chimbica", "Gasolina", 10m, 1 },
                    { 7, new DateTime(2020, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "luizchequini@gmail.com", 100, 10m, "Posto do Chimbica", "Gasolina", 10m, 1 },
                    { 8, new DateTime(2020, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "luizchequini@gmail.com", 100, 10m, "Posto do Chimbica", "Gasolina", 10m, 1 },
                    { 9, new DateTime(2020, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "luizchequini@gmail.com", 100, 10m, "Posto do Chimbica", "Gasolina", 10m, 1 },
                    { 10, new DateTime(2020, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "luizchequini@gmail.com", 100, 10m, "Posto do Chimbica", "Gasolina", 10m, 1 },
                    { 23, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "luizchequini@gmail.com", 100, 10m, "Posto do Chimbica", "Gasolina", 10m, 1 },
                    { 11, new DateTime(2020, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "luizchequini@gmail.com", 100, 10m, "Posto do Chimbica", "Gasolina", 10m, 1 },
                    { 13, new DateTime(2020, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "luizchequini@gmail.com", 100, 10m, "Posto do Chimbica", "Gasolina", 10m, 1 },
                    { 14, new DateTime(2020, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "luizchequini@gmail.com", 100, 10m, "Posto do Chimbica", "Gasolina", 10m, 1 },
                    { 15, new DateTime(2020, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "luizchequini@gmail.com", 100, 10m, "Posto do Chimbica", "Gasolina", 10m, 1 },
                    { 16, new DateTime(2020, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "luizchequini@gmail.com", 100, 10m, "Posto do Chimbica", "Gasolina", 10m, 1 },
                    { 17, new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "luizchequini@gmail.com", 100, 10m, "Posto do Chimbica", "Gasolina", 10m, 1 },
                    { 18, new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "luizchequini@gmail.com", 100, 10m, "Posto do Chimbica", "Gasolina", 10m, 1 },
                    { 19, new DateTime(2020, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "luizchequini@gmail.com", 100, 10m, "Posto do Chimbica", "Gasolina", 10m, 1 },
                    { 20, new DateTime(2020, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "luizchequini@gmail.com", 100, 10m, "Posto do Chimbica", "Gasolina", 10m, 1 },
                    { 21, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "luizchequini@gmail.com", 100, 10m, "Posto do Chimbica", "Gasolina", 10m, 1 },
                    { 12, new DateTime(2020, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "luizchequini@gmail.com", 100, 10m, "Posto do Chimbica", "Gasolina", 10m, 1 },
                    { 47, new DateTime(2020, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "joaoantonio@gmail.com", 300, 1230m, "Posto do Chimbica", "Gasolina", 1590m, 2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Abastecimentos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Abastecimentos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Abastecimentos",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Abastecimentos",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Abastecimentos",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Abastecimentos",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Abastecimentos",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Abastecimentos",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Abastecimentos",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Abastecimentos",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Abastecimentos",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Abastecimentos",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Abastecimentos",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Abastecimentos",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Abastecimentos",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Abastecimentos",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Abastecimentos",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Abastecimentos",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Abastecimentos",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Abastecimentos",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Abastecimentos",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Abastecimentos",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Abastecimentos",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Abastecimentos",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Abastecimentos",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Abastecimentos",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Abastecimentos",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Abastecimentos",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Abastecimentos",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Abastecimentos",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Abastecimentos",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Abastecimentos",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Abastecimentos",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Abastecimentos",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Abastecimentos",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Abastecimentos",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Abastecimentos",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Abastecimentos",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Abastecimentos",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Abastecimentos",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Abastecimentos",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Abastecimentos",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Abastecimentos",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Abastecimentos",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Abastecimentos",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Abastecimentos",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Abastecimentos",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Veiculos",
                keyColumn: "VeiculoId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Veiculos",
                keyColumn: "VeiculoId",
                keyValue: 2);
        }
    }
}
