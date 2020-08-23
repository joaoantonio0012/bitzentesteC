using bitzen.Data;
using bitzen.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks; 

namespace bitzen.Controllers
{
    [Authorize]
    public class VeiculosController : Controller
    {
        private readonly ApplicationDbContext _context;
        private IHostingEnvironment _env;
        public VeiculosController(ApplicationDbContext context, IHostingEnvironment env )
        {
            _context = context;
            _env = env;
        }

        // GET: Veiculos
        public async Task<IActionResult> Index()
        {
            return View(await _context.Veiculos.Where(v => v.IdUser == User.Identity.Name).ToListAsync());
        }

        // GET: Veiculos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var veiculo = await _context.Veiculos
                .FirstOrDefaultAsync(m => m.VeiculoId == id);
            if (veiculo == null)
            {
                return NotFound();
            }

            return View(veiculo);
        }

        // GET: Veiculos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Veiculos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create( Veiculo veiculo, IFormFile Imagem)
        {

            veiculo.IdUser = User.Identity.Name;

            if (Imagem != null && Imagem.Length > 0)
            {
                var caminhoDaImagem = @"\Uploads\Imagens\";
                var uploadCaminho = _env.WebRootPath + caminhoDaImagem;

                //Criar pasta Imagens
                if (!Directory.Exists(uploadCaminho))
                {
                    Directory.CreateDirectory(uploadCaminho);
                }

                //Criar nomes únicos nas imagens
                var nomeUnico = Guid.NewGuid().ToString();
                var NomeDoArquivo = Path.GetFileName(nomeUnico + "." + Imagem.FileName.Split('.')[1].ToLower());
                string CaminhoCompleto = uploadCaminho + NomeDoArquivo;

                caminhoDaImagem = caminhoDaImagem + @"\";
                var Arquivo = @".." + Path.Combine(caminhoDaImagem, NomeDoArquivo);

                using (var fileStream = new FileStream(CaminhoCompleto, FileMode.Create))
                {
                    await Imagem.CopyToAsync(fileStream);
                }

                veiculo.Imagem = caminhoDaImagem + NomeDoArquivo;

            }



            if (ModelState.IsValid)
            {
                _context.Add(veiculo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(veiculo);
        }

        // GET: Veiculos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var veiculo = await _context.Veiculos.FindAsync(id);
            if (veiculo == null)
            {
                return NotFound();
            }
            return View(veiculo);
        }

        // POST: Veiculos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("VeiculoId,Marca,Modelo,Ano,Placa,TipoVeiculo,TipoCombustivel,Imagem,Km,IdUser")] Veiculo veiculo, IFormFile Imagem)
        {

            veiculo.IdUser = User.Identity.Name;

            if (Imagem != null && Imagem.Length > 0)
            {
                var caminhoDaImagem = @"\Uploads\Imagens\";
                var uploadCaminho = _env.WebRootPath + caminhoDaImagem;

                //Criar pasta Imagens
                if (!Directory.Exists(uploadCaminho))
                {
                    Directory.CreateDirectory(uploadCaminho);
                }

                //Criar nomes únicos nas imagens
                var nomeUnico = Guid.NewGuid().ToString();
                var NomeDoArquivo = Path.GetFileName(nomeUnico + "." + Imagem.FileName.Split('.')[1].ToLower());
                string CaminhoCompleto = uploadCaminho + NomeDoArquivo;

                caminhoDaImagem = caminhoDaImagem + @"\";
                var Arquivo = @".." + Path.Combine(caminhoDaImagem, NomeDoArquivo);

                using (var fileStream = new FileStream(CaminhoCompleto, FileMode.Create))
                {
                    await Imagem.CopyToAsync(fileStream);
                }

                veiculo.Imagem = caminhoDaImagem + NomeDoArquivo;

            }


            if (id != veiculo.VeiculoId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(veiculo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VeiculoExists(veiculo.VeiculoId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(veiculo);
        }

        // GET: Veiculos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var veiculo = await _context.Veiculos
                .FirstOrDefaultAsync(m => m.VeiculoId == id);
            if (veiculo == null)
            {
                return NotFound();
            }

            return View(veiculo);
        }

        // POST: Veiculos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var veiculo = await _context.Veiculos.FindAsync(id);
            _context.Veiculos.Remove(veiculo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VeiculoExists(int id)
        {
            return _context.Veiculos.Any(e => e.VeiculoId == id);
        }
    }
}
