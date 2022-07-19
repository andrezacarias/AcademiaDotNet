using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PizzaDoMario.Data;
using PizzaDoMario.Models;

namespace PizzaDoMario.Controllers
{
    public class CadastroProdutoController : Controller
    {
        private readonly PizzaDoMarioContext _context;

        public CadastroProdutoController(PizzaDoMarioContext context)
        {
            _context = context;
        }

        // GET: CadastroProduto
        public async Task<IActionResult> Index()
        {
            return _context.CadastroProduto != null ?
                        View(await _context.CadastroProduto.ToListAsync()) :
                        Problem("Entity set 'PizzaDoMarioContext.CadastroProduto'  is null.");
        }

        // GET: CadastroProduto/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.CadastroProduto == null)
            {
                return NotFound();
            }

            var cadastroProduto = await _context.CadastroProduto
                .FirstOrDefaultAsync(m => m.IdProduto == id);
            if (cadastroProduto == null)
            {
                return NotFound();
            }

            return View(cadastroProduto);
        }

        // GET: CadastroProduto/Create
        public IActionResult Create()
        {
           
            return View();
        }

        // POST: CadastroProduto/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdProduto,nomeProduto,preco,descricao")] CadastroProduto cadastroProduto)
        {
           
                _context.Add(cadastroProduto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            //ViewData["nomeProduto"] = new SelectList(_context.CadastroProduto, "nomeProduto", "nomeProduto", cadastroProduto.IdProduto);
            return View(cadastroProduto);
        }

        // GET: CadastroProduto/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.CadastroProduto == null)
            {
                return NotFound();
            }

            var cadastroProduto = await _context.CadastroProduto.FindAsync(id);
            if (cadastroProduto == null)
            {
                return NotFound();
            }
            return View(cadastroProduto);
        }

        // POST: CadastroProduto/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdProduto,nomeProduto,preco,descricao")] CadastroProduto cadastroProduto)
        {
            if (id != cadastroProduto.IdProduto)
            {
                return NotFound();
            }

           
                try
                {
                    _context.Update(cadastroProduto);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CadastroProdutoExists(cadastroProduto.IdProduto))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            
            return View(cadastroProduto);
        }

        // GET: CadastroProduto/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.CadastroProduto == null)
            {
                return NotFound();
            }

            var cadastroProduto = await _context.CadastroProduto
                .FirstOrDefaultAsync(m => m.IdProduto == id);
            if (cadastroProduto == null)
            {
                return NotFound();
            }

            return View(cadastroProduto);
        }

        // POST: CadastroProduto/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.CadastroProduto == null)
            {
                return Problem("Entity set 'PizzaDoMarioContext.CadastroProduto'  is null.");
            }
            var cadastroProduto = await _context.CadastroProduto.FindAsync(id);
            if (cadastroProduto != null)
            {
                _context.CadastroProduto.Remove(cadastroProduto);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CadastroProdutoExists(int id)
        {
          return (_context.CadastroProduto?.Any(e => e.IdProduto == id)).GetValueOrDefault();
        }
    }
}
