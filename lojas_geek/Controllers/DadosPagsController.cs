using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using lojas_geek.Data;
using lojas_geek.Models;

namespace lojas_geek.Controllers
{
    public class DadosPagsController : Controller
    {
        private readonly lojas_geekContext _context;

        public DadosPagsController(lojas_geekContext context)
        {
            _context = context;
        }

        // GET: DadosPags
        public async Task<IActionResult> Index()
        {
              return _context.DadosPag != null ? 
                          View(await _context.DadosPag.ToListAsync()) :
                          Problem("Entity set 'lojas_geekContext.DadosPag'  is null.");
        }

        // GET: DadosPags/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.DadosPag == null)
            {
                return NotFound();
            }

            var dadosPag = await _context.DadosPag
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dadosPag == null)
            {
                return NotFound();
            }

            return View(dadosPag);
        }

        // GET: DadosPags/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DadosPags/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Tipo,Valor,DataPagamento")] DadosPag dadosPag)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dadosPag);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(dadosPag);
        }

        // GET: DadosPags/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.DadosPag == null)
            {
                return NotFound();
            }

            var dadosPag = await _context.DadosPag.FindAsync(id);
            if (dadosPag == null)
            {
                return NotFound();
            }
            return View(dadosPag);
        }

        // POST: DadosPags/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Tipo,Valor,DataPagamento")] DadosPag dadosPag)
        {
            if (id != dadosPag.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dadosPag);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DadosPagExists(dadosPag.Id))
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
            return View(dadosPag);
        }

        // GET: DadosPags/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.DadosPag == null)
            {
                return NotFound();
            }

            var dadosPag = await _context.DadosPag
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dadosPag == null)
            {
                return NotFound();
            }

            return View(dadosPag);
        }

        // POST: DadosPags/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.DadosPag == null)
            {
                return Problem("Entity set 'lojas_geekContext.DadosPag'  is null.");
            }
            var dadosPag = await _context.DadosPag.FindAsync(id);
            if (dadosPag != null)
            {
                _context.DadosPag.Remove(dadosPag);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DadosPagExists(int id)
        {
          return (_context.DadosPag?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
