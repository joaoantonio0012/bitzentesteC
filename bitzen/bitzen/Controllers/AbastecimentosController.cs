using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using bitzen.Data;
using bitzen.Models;
using Microsoft.AspNetCore.Authorization;

namespace bitzen.Controllers
{
    [Authorize]
    public class AbastecimentosController : Controller
    {
        
        private readonly ApplicationDbContext _context;

        public AbastecimentosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Abastecimentos
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Abastecimentos.Include(a => a.Veiculo).Where( a => a.IdUser == User.Identity.Name);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Abastecimentos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var abastecimento = await _context.Abastecimentos
                .Include(a => a.Veiculo)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (abastecimento == null)
            {
                return NotFound();
            }

            return View(abastecimento);
        }

        // GET: Abastecimentos/Create
        public IActionResult Create()
        {
            ViewData["VeiculoId"] = new SelectList(_context.Veiculos.Where(v => v.IdUser == User.Identity.Name ), "VeiculoId", "Placa");
            return View();
        }

        // POST: Abastecimentos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Km,Litros,Valor,DataAbastecimento,Posto,IdUser,Tipo,VeiculoId")] Abastecimento abastecimento)
        {
            abastecimento.IdUser = User.Identity.Name;

            if (ModelState.IsValid)
            {
                _context.Add(abastecimento);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["VeiculoId"] = new SelectList(_context.Veiculos, "VeiculoId", "Placa", abastecimento.VeiculoId);
            return View(abastecimento);
        }

        // GET: Abastecimentos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            

            if (id == null)
            {
                return NotFound();
            }

            var abastecimento = await _context.Abastecimentos.FindAsync(id);

            abastecimento.IdUser = User.Identity.Name;
            if (abastecimento == null)
            {
                return NotFound();
            }
            ViewData["VeiculoId"] = new SelectList(_context.Veiculos, "VeiculoId", "Placa", abastecimento.VeiculoId);
            return View(abastecimento);
        }

        // POST: Abastecimentos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Km,Litros,Valor,DataAbastecimento,Posto,IdUser,Tipo,VeiculoId")] Abastecimento abastecimento)
        {
            if (id != abastecimento.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(abastecimento);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AbastecimentoExists(abastecimento.Id))
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
            ViewData["VeiculoId"] = new SelectList(_context.Veiculos, "VeiculoId", "Placa", abastecimento.VeiculoId);
            return View(abastecimento);
        }

        // GET: Abastecimentos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var abastecimento = await _context.Abastecimentos
                .Include(a => a.Veiculo)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (abastecimento == null)
            {
                return NotFound();
            }

            return View(abastecimento);
        }

        // POST: Abastecimentos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var abastecimento = await _context.Abastecimentos.FindAsync(id);
            _context.Abastecimentos.Remove(abastecimento);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AbastecimentoExists(int id)
        {
            return _context.Abastecimentos.Any(e => e.Id == id);
        }
    }
}
