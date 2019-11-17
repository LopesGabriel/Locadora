using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Locadora.Models;

namespace Locadora.Controllers
{
    public class ProdutorasController : Controller
    {
        private readonly LocadoraContext _context;

        public ProdutorasController(LocadoraContext context)
        {
            _context = context;
        }

        // GET: Produtoras
        public async Task<IActionResult> Index()
        {
            return View(await _context.Produtora.ToListAsync());
        }

        // GET: Produtoras/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var produtora = await _context.Produtora
                .FirstOrDefaultAsync(m => m.Id == id);
            if (produtora == null)
            {
                return NotFound();
            }

            return View(produtora);
        }

        // GET: Produtoras/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Produtoras/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome")] Produtora produtora)
        {
            if (ModelState.IsValid)
            {
                _context.Add(produtora);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(produtora);
        }

        // GET: Produtoras/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var produtora = await _context.Produtora.FindAsync(id);
            if (produtora == null)
            {
                return NotFound();
            }
            return View(produtora);
        }

        // POST: Produtoras/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome")] Produtora produtora)
        {
            if (id != produtora.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(produtora);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProdutoraExists(produtora.Id))
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
            return View(produtora);
        }

        // GET: Produtoras/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var produtora = await _context.Produtora
                .FirstOrDefaultAsync(m => m.Id == id);
            if (produtora == null)
            {
                return NotFound();
            }

            return View(produtora);
        }

        // POST: Produtoras/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var produtora = await _context.Produtora.FindAsync(id);
            _context.Produtora.Remove(produtora);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProdutoraExists(int id)
        {
            return _context.Produtora.Any(e => e.Id == id);
        }
    }
}
