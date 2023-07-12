namespace GestaoDeArquivo
{
    public class Class
    {
    }
}
/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GestaoDeArquivo.Data;
using GestaoDeArquivo.Models;

namespace GestaoDeArquivo.Controllers
{
    public class ArquivoesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ArquivoesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Arquivoes
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Arquivo.Include(a => a.Person_Name).Include(a => a.Place_Name).Include(a => a.Type_Name);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Arquivoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Arquivo == null)
            {
                return NotFound();
            }

            var arquivo = await _context.Arquivo
                .Include(a => a.Person_Name)
                .Include(a => a.Place_Name)
                .Include(a => a.Type_Name)
                .FirstOrDefaultAsync(m => m.Arquive_Id == id);
            if (arquivo == null)
            {
                return NotFound();
            }

            return View(arquivo);
        }

        // GET: Arquivoes/Create
        public IActionResult Create()
        {
            ViewData["Person_Id"] = new SelectList(_context.Pessoas, "Person_Id", "Person_Name");
            ViewData["Person_Id"] = new SelectList(_context.Local, "Place_Id", "Place_Name");
            ViewData["Type_Id"] = new SelectList(_context.Tipos, "Type_Id", "Type_Name");
            return View();
        }

        // POST: Arquivoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Arquive_Id,Arquive_Name,Type_Id,Person_Id,Place_Id,Arquive_Descricao,CreateDateTime")] Arquivo arquivo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(arquivo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Person_Id"] = new SelectList(_context.Pessoas, "Person_Id", "Person_Name", arquivo.Person_Id);
            ViewData["Person_Id"] = new SelectList(_context.Local, "Place_Id", "Place_Name", arquivo.Person_Id);
            ViewData["Type_Id"] = new SelectList(_context.Tipos, "Type_Id", "Type_Name", arquivo.Type_Id);
            return View(arquivo);
        }

        // GET: Arquivoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Arquivo == null)
            {
                return NotFound();
            }

            var arquivo = await _context.Arquivo.FindAsync(id);
            if (arquivo == null)
            {
                return NotFound();
            }
            ViewData["Person_Id"] = new SelectList(_context.Pessoas, "Person_Id", "Person_Name", arquivo.Person_Id);
            ViewData["Person_Id"] = new SelectList(_context.Local, "Place_Id", "Place_Name", arquivo.Person_Id);
            ViewData["Type_Id"] = new SelectList(_context.Tipos, "Type_Id", "Type_Name", arquivo.Type_Id);
            return View(arquivo);
        }

        // POST: Arquivoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Arquive_Id,Arquive_Name,Type_Id,Person_Id,Place_Id,Arquive_Descricao,CreateDateTime")] Arquivo arquivo)
        {
            if (id != arquivo.Arquive_Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(arquivo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ArquivoExists(arquivo.Arquive_Id))
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
            ViewData["Person_Id"] = new SelectList(_context.Pessoas, "Person_Id", "Person_Name", arquivo.Person_Id);
            ViewData["Person_Id"] = new SelectList(_context.Local, "Place_Id", "Place_Name", arquivo.Person_Id);
            ViewData["Type_Id"] = new SelectList(_context.Tipos, "Type_Id", "Type_Name", arquivo.Type_Id);
            return View(arquivo);
        }

        // GET: Arquivoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Arquivo == null)
            {
                return NotFound();
            }

            var arquivo = await _context.Arquivo
                .Include(a => a.Person_Name)
                .Include(a => a.Place_Name)
                .Include(a => a.Type_Name)
                .FirstOrDefaultAsync(m => m.Arquive_Id == id);
            if (arquivo == null)
            {
                return NotFound();
            }

            return View(arquivo);
        }

        // POST: Arquivoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Arquivo == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Arquivo'  is null.");
            }
            var arquivo = await _context.Arquivo.FindAsync(id);
            if (arquivo != null)
            {
                _context.Arquivo.Remove(arquivo);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ArquivoExists(int id)
        {
          return (_context.Arquivo?.Any(e => e.Arquive_Id == id)).GetValueOrDefault();
        }
    }
}
*/
