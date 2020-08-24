using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bitzen.Models
{
    public static class InserirDadosAutomaticos
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Veiculo>().HasData(
                new Veiculo { VeiculoId = 1, Ano = 2020, IdUser = "luizchequini@gmail.com", Imagem = @"\Uploads\Imagens\\b48951a3-d607-441e-a7b6-020f93d099ba.jpg", Km = 100, Marca = "Volkswagem", Modelo = "Fusca", Placa = "XXX-1234", TipoCombustivel = "Gasolina", TipoVeiculo = "Passeio" },
                new Veiculo { VeiculoId = 2, Ano = 2020, IdUser = "joaoantonio@gmail.com", Imagem = @"\Uploads\Imagens\\b48951a3-d607-441e-a7b6-020f93d099ba.jpg", Km = 10, Marca = "Honda", Modelo = "Civic", Placa = "CDE-4568", TipoCombustivel = "Alcool", TipoVeiculo = "Passeio" }
            );

            modelBuilder.Entity<Abastecimento>().HasData(
                new Abastecimento { Id = 1, VeiculoId = 1, DataAbastecimento = new DateTime(2020, 1, 1), IdUser = "luizchequini@gmail.com", Km = 100, Litros = 10, Posto = "Posto do Chimbica", Tipo = "Gasolina", Valor = 10 },
                new Abastecimento { Id = 2, VeiculoId = 1, DataAbastecimento = new DateTime(2020, 1, 1), IdUser = "luizchequini@gmail.com", Km = 100, Litros = 100, Posto = "Posto do Chimbica", Tipo = "Gasolina", Valor = 100 },
                new Abastecimento { Id = 3, VeiculoId = 1, DataAbastecimento = new DateTime(2020, 1, 1), IdUser = "luizchequini@gmail.com", Km = 100, Litros = 150, Posto = "Posto do Chimbica", Tipo = "Gasolina", Valor = 150 },
                new Abastecimento { Id = 4, VeiculoId = 1, DataAbastecimento = new DateTime(2020, 1, 1), IdUser = "luizchequini@gmail.com", Km = 100, Litros = 10, Posto = "Posto do Chimbica", Tipo = "Gasolina", Valor = 10 },
                new Abastecimento { Id = 5, VeiculoId = 1, DataAbastecimento = new DateTime(2020, 2, 1), IdUser = "luizchequini@gmail.com", Km = 100, Litros = 10, Posto = "Posto do Chimbica", Tipo = "Gasolina", Valor = 10 },
                new Abastecimento { Id = 6, VeiculoId = 1, DataAbastecimento = new DateTime(2020, 2, 1), IdUser = "luizchequini@gmail.com", Km = 100, Litros = 10, Posto = "Posto do Chimbica", Tipo = "Gasolina", Valor = 10 },
                new Abastecimento { Id = 7, VeiculoId = 1, DataAbastecimento = new DateTime(2020, 2, 1), IdUser = "luizchequini@gmail.com", Km = 100, Litros = 10, Posto = "Posto do Chimbica", Tipo = "Gasolina", Valor = 10 },
                new Abastecimento { Id = 8, VeiculoId = 1, DataAbastecimento = new DateTime(2020, 2, 1), IdUser = "luizchequini@gmail.com", Km = 100, Litros = 10, Posto = "Posto do Chimbica", Tipo = "Gasolina", Valor = 10 },
                new Abastecimento { Id = 9, VeiculoId = 1, DataAbastecimento = new DateTime(2020, 2, 1), IdUser = "luizchequini@gmail.com", Km = 100, Litros = 10, Posto = "Posto do Chimbica", Tipo = "Gasolina", Valor = 10 },
                new Abastecimento { Id = 10, VeiculoId = 1, DataAbastecimento = new DateTime(2020, 3, 1), IdUser = "luizchequini@gmail.com", Km = 100, Litros = 10, Posto = "Posto do Chimbica", Tipo = "Gasolina", Valor = 10 },
                new Abastecimento { Id = 11, VeiculoId = 1, DataAbastecimento = new DateTime(2020, 3, 1), IdUser = "luizchequini@gmail.com", Km = 100, Litros = 10, Posto = "Posto do Chimbica", Tipo = "Gasolina", Valor = 10 },
                new Abastecimento { Id = 12, VeiculoId = 1, DataAbastecimento = new DateTime(2020, 3, 1), IdUser = "luizchequini@gmail.com", Km = 100, Litros = 10, Posto = "Posto do Chimbica", Tipo = "Gasolina", Valor = 10 },
                new Abastecimento { Id = 13, VeiculoId = 1, DataAbastecimento = new DateTime(2020, 3, 1), IdUser = "luizchequini@gmail.com", Km = 100, Litros = 10, Posto = "Posto do Chimbica", Tipo = "Gasolina", Valor = 10 },
                new Abastecimento { Id = 14, VeiculoId = 1, DataAbastecimento = new DateTime(2020, 4, 1), IdUser = "luizchequini@gmail.com", Km = 100, Litros = 10, Posto = "Posto do Chimbica", Tipo = "Gasolina", Valor = 10 },
                new Abastecimento { Id = 15, VeiculoId = 1, DataAbastecimento = new DateTime(2020, 4, 1), IdUser = "luizchequini@gmail.com", Km = 100, Litros = 10, Posto = "Posto do Chimbica", Tipo = "Gasolina", Valor = 10 },
                new Abastecimento { Id = 16, VeiculoId = 1, DataAbastecimento = new DateTime(2020, 4, 1), IdUser = "luizchequini@gmail.com", Km = 100, Litros = 10, Posto = "Posto do Chimbica", Tipo = "Gasolina", Valor = 10 },
                new Abastecimento { Id = 17, VeiculoId = 1, DataAbastecimento = new DateTime(2020, 5, 1), IdUser = "luizchequini@gmail.com", Km = 100, Litros = 10, Posto = "Posto do Chimbica", Tipo = "Gasolina", Valor = 10 },
                new Abastecimento { Id = 18, VeiculoId = 1, DataAbastecimento = new DateTime(2020, 5, 1), IdUser = "luizchequini@gmail.com", Km = 100, Litros = 10, Posto = "Posto do Chimbica", Tipo = "Gasolina", Valor = 10 },
                new Abastecimento { Id = 19, VeiculoId = 1, DataAbastecimento = new DateTime(2020, 6, 1), IdUser = "luizchequini@gmail.com", Km = 100, Litros = 10, Posto = "Posto do Chimbica", Tipo = "Gasolina", Valor = 10 },
                new Abastecimento { Id = 20, VeiculoId = 1, DataAbastecimento = new DateTime(2020, 6, 1), IdUser = "luizchequini@gmail.com", Km = 100, Litros = 10, Posto = "Posto do Chimbica", Tipo = "Gasolina", Valor = 10 },
                new Abastecimento { Id = 21, VeiculoId = 1, DataAbastecimento = new DateTime(2020, 7, 1), IdUser = "luizchequini@gmail.com", Km = 100, Litros = 10, Posto = "Posto do Chimbica", Tipo = "Gasolina", Valor = 10 },
                new Abastecimento { Id = 22, VeiculoId = 1, DataAbastecimento = new DateTime(2020, 7, 1), IdUser = "luizchequini@gmail.com", Km = 100, Litros = 10, Posto = "Posto do Chimbica", Tipo = "Gasolina", Valor = 10 },
                new Abastecimento { Id = 23, VeiculoId = 1, DataAbastecimento = new DateTime(2020, 7, 1), IdUser = "luizchequini@gmail.com", Km = 100, Litros = 10, Posto = "Posto do Chimbica", Tipo = "Gasolina", Valor = 10 },
                new Abastecimento { Id = 24, VeiculoId = 1, DataAbastecimento = new DateTime(2020, 7, 1), IdUser = "luizchequini@gmail.com", Km = 100, Litros = 10, Posto = "Posto do Chimbica", Tipo = "Gasolina", Valor = 10 },
                new Abastecimento { Id = 25, VeiculoId = 1, DataAbastecimento = new DateTime(2020, 7, 1), IdUser = "luizchequini@gmail.com", Km = 100, Litros = 10, Posto = "Posto do Chimbica", Tipo = "Gasolina", Valor = 10 },
                new Abastecimento { Id = 26, VeiculoId = 1, DataAbastecimento = new DateTime(2020, 8, 1), IdUser = "luizchequini@gmail.com", Km = 100, Litros = 10, Posto = "Posto do Chimbica", Tipo = "Gasolina", Valor = 10 },
                new Abastecimento { Id = 27, VeiculoId = 1, DataAbastecimento = new DateTime(2020, 8, 1), IdUser = "luizchequini@gmail.com", Km = 100, Litros = 10, Posto = "Posto do Chimbica", Tipo = "Gasolina", Valor = 10 },
                new Abastecimento { Id = 28, VeiculoId = 1, DataAbastecimento = new DateTime(2020, 9, 1), IdUser = "luizchequini@gmail.com", Km = 100, Litros = 10, Posto = "Posto do Chimbica", Tipo = "Gasolina", Valor = 10 },
                new Abastecimento { Id = 29, VeiculoId = 1, DataAbastecimento = new DateTime(2020, 10, 1), IdUser = "luizchequini@gmail.com", Km = 100, Litros = 10, Posto = "Posto do Chimbica", Tipo = "Gasolina", Valor = 10 },
                new Abastecimento { Id = 30, VeiculoId = 1, DataAbastecimento = new DateTime(2020, 11, 1), IdUser = "luizchequini@gmail.com", Km = 100, Litros = 10, Posto = "Posto do Chimbica", Tipo = "Gasolina", Valor = 10 },
                new Abastecimento { Id = 31, VeiculoId = 1, DataAbastecimento = new DateTime(2020, 11, 1), IdUser = "luizchequini@gmail.com", Km = 100, Litros = 10, Posto = "Posto do Chimbica", Tipo = "Gasolina", Valor = 10 },
                new Abastecimento { Id = 32, VeiculoId = 1, DataAbastecimento = new DateTime(2020, 12, 1), IdUser = "luizchequini@gmail.com", Km = 100, Litros = 10, Posto = "Posto do Chimbica", Tipo = "Gasolina", Valor = 10 },
                new Abastecimento { Id = 33, VeiculoId = 1, DataAbastecimento = new DateTime(2020, 12, 1), IdUser = "luizchequini@gmail.com", Km = 100, Litros = 10, Posto = "Posto do Chimbica", Tipo = "Gasolina", Valor = 10 },
                new Abastecimento { Id = 34, VeiculoId = 1, DataAbastecimento = new DateTime(2020, 12, 1), IdUser = "luizchequini@gmail.com", Km = 100, Litros = 10, Posto = "Posto do Chimbica", Tipo = "Gasolina", Valor = 10 },
                new Abastecimento { Id = 35, VeiculoId = 1, DataAbastecimento = new DateTime(2020, 12, 1), IdUser = "luizchequini@gmail.com", Km = 100, Litros = 10, Posto = "Posto do Chimbica", Tipo = "Gasolina", Valor = 10 },
                new Abastecimento { Id = 36, VeiculoId = 2, DataAbastecimento = new DateTime(2020, 1, 1), IdUser = "joaoantonio@gmail.com", Km = 100, Litros = 200, Posto = "Posto do Chimbica", Tipo = "Gasolina", Valor = 830 },
                new Abastecimento { Id = 37, VeiculoId = 2, DataAbastecimento = new DateTime(2020, 2, 1), IdUser = "joaoantonio@gmail.com", Km = 100, Litros = 1000, Posto = "Posto do Chimbica", Tipo = "Gasolina", Valor = 35 },
                new Abastecimento { Id = 38, VeiculoId = 2, DataAbastecimento = new DateTime(2020, 3, 1), IdUser = "joaoantonio@gmail.com", Km = 100, Litros = 90, Posto = "Posto do Chimbica", Tipo = "Gasolina", Valor = 88 },
                new Abastecimento { Id = 39, VeiculoId = 2, DataAbastecimento = new DateTime(2020, 4, 1), IdUser = "joaoantonio@gmail.com", Km = 500, Litros = 50, Posto = "Posto do Chimbica", Tipo = "Gasolina", Valor = 90 },
                new Abastecimento { Id = 40, VeiculoId = 2, DataAbastecimento = new DateTime(2020, 5, 1), IdUser = "joaoantonio@gmail.com", Km = 900, Litros = 100, Posto = "Posto do Chimbica", Tipo = "Gasolina", Valor = 190 },
                new Abastecimento { Id = 41, VeiculoId = 2, DataAbastecimento = new DateTime(2020, 6, 1), IdUser = "joaoantonio@gmail.com", Km = 1000, Litros = 139, Posto = "Posto do Chimbica", Tipo = "Gasolina", Valor = 290 },
                new Abastecimento { Id = 42, VeiculoId = 2, DataAbastecimento = new DateTime(2020, 7, 1), IdUser = "joaoantonio@gmail.com", Km = 1100, Litros = 100, Posto = "Posto do Chimbica", Tipo = "Gasolina", Valor = 490 },
                new Abastecimento { Id = 43, VeiculoId = 2, DataAbastecimento = new DateTime(2020, 8, 1), IdUser = "joaoantonio@gmail.com", Km = 600, Litros = 200, Posto = "Posto do Chimbica", Tipo = "Gasolina", Valor = 290 },
                new Abastecimento { Id = 44, VeiculoId = 2, DataAbastecimento = new DateTime(2020, 9, 1), IdUser = "joaoantonio@gmail.com", Km = 300, Litros = 230, Posto = "Posto do Chimbica", Tipo = "Gasolina", Valor = 590 },
                new Abastecimento { Id = 45, VeiculoId = 2, DataAbastecimento = new DateTime(2020, 10, 1), IdUser = "joaoantonio@gmail.com", Km = 300, Litros = 430, Posto = "Posto do Chimbica", Tipo = "Gasolina", Valor = 790 },
                new Abastecimento { Id = 46, VeiculoId = 2, DataAbastecimento = new DateTime(2020, 11, 1), IdUser = "joaoantonio@gmail.com", Km = 300, Litros = 130, Posto = "Posto do Chimbica", Tipo = "Gasolina", Valor = 590 },
                new Abastecimento { Id = 47, VeiculoId = 2, DataAbastecimento = new DateTime(2020, 12, 1), IdUser = "joaoantonio@gmail.com", Km = 300, Litros = 1230, Posto = "Posto do Chimbica", Tipo = "Gasolina", Valor = 1590 }
            );
        }
    }
}