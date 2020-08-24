using bitzen.Data;
using bitzen.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bitzen.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class AbastecimentosController : ControllerBase
    {
        private readonly ApplicationDbContext _context;



        public AbastecimentosController(ApplicationDbContext context)
        {
            _context = context;
        }

        public string RetornaMeses(int numeroMes)
        {
            string mes;

            switch (numeroMes)
            {
                case 1:
                    mes = "Janeiro";
                    break;
                case 2:
                    mes = "Fevereiro";
                    break;
                case 3:
                    mes = "Março";
                    break;
                case 4:
                    mes = "Abril";
                    break;
                case 5:
                    mes = "Maio";
                    break;
                case 6:
                    mes = "Junho";
                    break;
                case 7:
                    mes = "Julho";
                    break;
                case 8:
                    mes = "Agosto";
                    break;
                case 9:
                    mes = "Setembro";
                    break;
                case 10:
                    mes = "Outubro";
                    break;
                case 11:
                    mes = "Novembro";
                    break;
                case 12:
                    mes = "Dezembro";
                    break;
                default:
                    mes = "Mês inexistente";
                    break;
            }

            return mes;
        }

        [HttpGet("GetTotalLitrosPorAno/{ano}")]
        public async Task<ActionResult<IEnumerable<Veiculo>>> GetTotalLitrosPorAno(string ano)
        {
            DateTime d = new DateTime(int.Parse(ano), 1, 1);

            List<Relatorio> lista = new List<Relatorio>();

            //AQUI GROUPBY FUNCIONA MAS NÃO CONSEGUI FAZER SOMATÓRIO DE CADA MÊS
            var dados = await _context.Abastecimentos
                             .Where(v => v.DataAbastecimento.Year == d.Year)
                             .GroupBy(x => new
                             {
                                 Month = x.DataAbastecimento.Month
                             })
                             .ToListAsync();

            var mes = "";
            decimal valor = 0;
            foreach (var item in dados)
            {
                valor = 0;

                mes = RetornaMeses(item.Key.Month);

                foreach (var k in item)
                {
                    valor = valor + k.Litros;
                }

                lista.Add(new Relatorio { Mes = mes, Valor = valor });
            }
            return Ok(lista);
        }

        [HttpGet("GetTotalValorPagoPorAno/{ano}")]
        public async Task<ActionResult<IEnumerable<Veiculo>>> GetTotalValorPagoPorAno(string ano)
        {
            DateTime d = new DateTime(int.Parse(ano), 1, 1);

            List<Relatorio> lista = new List<Relatorio>();

            //AQUI GROUPBY FUNCIONA MAS NÃO CONSEGUI FAZER SOMATÓRIO DE CADA MÊS
            var dados = await _context.Abastecimentos
                             .Where(v => v.DataAbastecimento.Year == d.Year)
                             .GroupBy(x => new
                             {
                                 Month = x.DataAbastecimento.Month
                             })
                             .ToListAsync();

            var mes = "";
            decimal valor = 0;
            foreach (var item in dados)
            {
                valor = 0;

                mes = RetornaMeses(item.Key.Month);

                foreach (var k in item)
                {
                    valor = valor + k.Valor;
                }

                lista.Add(new Relatorio { Mes = mes, Valor = valor });
            }
            return Ok(lista);
        }




        [HttpGet("GetTotalQuilometrosRodadosPorAno/{ano}")]
        public async Task<ActionResult<IEnumerable<Veiculo>>> GetTotalQuilometrosRodadosPorAno(string ano)
        {
            DateTime d = new DateTime(int.Parse(ano), 1, 1);

            List<Relatorio> lista = new List<Relatorio>();

            //AQUI GROUPBY FUNCIONA MAS NÃO CONSEGUI FAZER SOMATÓRIO DE CADA MÊS
            var dados = await _context.Abastecimentos
                             .Where(v => v.DataAbastecimento.Year == d.Year)
                             .GroupBy(x => new
                             {
                                 Month = x.DataAbastecimento.Month
                             })
                             .ToListAsync();

            var mes = "";
            decimal valor = 0;
            foreach (var item in dados)
            {
                valor = 0;

                mes = RetornaMeses(item.Key.Month);

                foreach (var k in item)
                {
                    valor = valor + k.Km;
                }

                lista.Add(new Relatorio { Mes = mes, Valor = valor });
            }
            return Ok(lista);
        }

        [HttpGet("GetMediaMensalPorCarroKmPorLitros/{ano}")]
        public async Task<ActionResult<IEnumerable<Veiculo>>> GetMediaMensalPorCarroKmPorLitros(string ano)
        {
            DateTime d = new DateTime(int.Parse(ano), 1, 1);

            List<RelatorioMediaMensalPorCarro> lista = new List<RelatorioMediaMensalPorCarro>();
            List<MediaLitros> medias = new List<MediaLitros>();
            //AQUI GROUPBY FUNCIONA MAS NÃO CONSEGUI FAZER SOMATÓRIO DE CADA MÊS
            var dados = await _context.Abastecimentos
                             .Where(v => v.DataAbastecimento.Year == d.Year)
                             .GroupBy(x => new
                             {
                                 Carro = x.Veiculo.Placa
                                 //Mes = x.DataAbastecimento.Month
                             })
                             .ToListAsync();

            var mes = "";
            decimal valor = 0;
            int carroId = 0;
            decimal somaLitros = 0, somaKm = 0, media = 0;

            foreach (var item in dados)
            {
                valor = 0;
                somaLitros = 0; somaKm = 0; media = 0;


                for (int i = 1; i <= 12; i++)
                    {
                        somaLitros = item.Where(x => x.DataAbastecimento.Month == i).Sum(x => x.Litros);
                        somaKm = item.Where(x => x.DataAbastecimento.Month == i).Sum(x => x.Km);
                        try
                        {
                            media = somaKm / somaLitros;
                        }
                        catch { media = 0; }
                        medias.Add(new MediaLitros { Mes = RetornaMeses(i), Media = media });
                    }
                 
                

                lista.Add(new RelatorioMediaMensalPorCarro { Placa  = item.Key.Carro , media = medias });
            }
            return Ok(lista);
        }
    

        // GET: api/Abastecimentos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Abastecimento>>> GetAbastecimentos()
        {
            return await _context.Abastecimentos.ToListAsync();
        }

        [HttpGet("GetLitrosPorAno/{ano}")]
        public async Task<ActionResult<Abastecimento>> GetLitrosPorAno(int ano)
        {
            var soma = await _context.Abastecimentos.Where(a => a.DataAbastecimento.Date.Year == ano).ToListAsync();

            return Ok(soma.Sum(a => a.Litros));

        }



        // GET: api/Abastecimentos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Abastecimento>> GetAbastecimento(int id)
        {
            var abastecimento = await _context.Abastecimentos.FindAsync(id);

            if (abastecimento == null)
            {
                return NotFound();
            }

            return abastecimento;
        }

        // PUT: api/Abastecimentos/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAbastecimento(int id, Abastecimento abastecimento)
        {
            if (id != abastecimento.Id)
            {
                return BadRequest();
            }

            _context.Entry(abastecimento).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AbastecimentoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Abastecimentos
        [HttpPost]
        public async Task<ActionResult<Abastecimento>> PostAbastecimento(Abastecimento abastecimento)
        {
            _context.Abastecimentos.Add(abastecimento);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAbastecimento", new { id = abastecimento.Id }, abastecimento);
        }

        // DELETE: api/Abastecimentos/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Abastecimento>> DeleteAbastecimento(int id)
        {
            var abastecimento = await _context.Abastecimentos.FindAsync(id);
            if (abastecimento == null)
            {
                return NotFound();
            }

            _context.Abastecimentos.Remove(abastecimento);
            await _context.SaveChangesAsync();

            return abastecimento;
        }

        private bool AbastecimentoExists(int id)
        {
            return _context.Abastecimentos.Any(e => e.Id == id);
        }
    }
}