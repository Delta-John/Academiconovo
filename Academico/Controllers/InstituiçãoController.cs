using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Academico.Data;
using Academico.Models;

namespace Academico.Controllers
{
    public class InstituiçãoController : Controller
    {
        private readonly AcademicoContext _context;

        public InstituiçãoController(AcademicoContext context)
        {
            _context = context;
        }

        // GET: Instituição
        public async Task<IActionResult> Index()
        {
            return View(await _context.Instituição.ToListAsync());
        }

        // GET: Instituição/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var instituição = await _context.Instituição
                .FirstOrDefaultAsync(m => m.InstituiçãoId == id);
            if (instituição == null)
            {
                return NotFound();
            }

            return View(instituição);
        }

        // GET: Instituição/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Instituição/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("InstituiçãoId,Nome,Telefone")] Instituição instituição)
        {
            if (ModelState.IsValid)
            {
                _context.Add(instituição);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(instituição);
        }

        // GET: Instituição/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var instituição = await _context.Instituição.FindAsync(id);
            if (instituição == null)
            {
                return NotFound();
            }
            return View(instituição);
        }

        // POST: Instituição/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("InstituiçãoId,Nome,Telefone")] Instituição instituição)
        {
            if (id != instituição.InstituiçãoId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(instituição);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InstituiçãoExists(instituição.InstituiçãoId))
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
            return View(instituição);
        }

        // GET: Instituição/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var instituição = await _context.Instituição
                .FirstOrDefaultAsync(m => m.InstituiçãoId == id);
            if (instituição == null)
            {
                return NotFound();
            }

            return View(instituição);
        }

        // POST: Instituição/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var instituição = await _context.Instituição.FindAsync(id);
            if (instituição != null)
            {
                _context.Instituição.Remove(instituição);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InstituiçãoExists(int id)
        {
            return _context.Instituição.Any(e => e.InstituiçãoId == id);
        }
    }
}
