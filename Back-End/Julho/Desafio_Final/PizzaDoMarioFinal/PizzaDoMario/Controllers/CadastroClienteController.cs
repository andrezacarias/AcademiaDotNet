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
    public class CadastroClienteController : Controller
    {
        private readonly PizzaDoMarioContext _context;

        public CadastroClienteController(PizzaDoMarioContext context)
        {
            _context = context;
        }

        // GET: CadastroCliente
        public async Task<IActionResult> Index()
        {
              return _context.CadastroCliente != null ? 
                          View(await _context.CadastroCliente.ToListAsync()) :
                          Problem("Entity set 'PizzaDoMarioContext.CadastroCliente'  is null.");
        }

        // GET: CadastroCliente/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.CadastroCliente == null)
            {
                return NotFound();
            }

            var cadastroCliente = await _context.CadastroCliente
                .FirstOrDefaultAsync(m => m.IdCliente == id);
            if (cadastroCliente == null)
            {
                return NotFound();
            }

            return View(cadastroCliente);
        }

        // GET: CadastroCliente/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CadastroCliente/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdCliente,nome,endereco,complemento,bairro,telefone")] CadastroCliente cadastroCliente)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cadastroCliente);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cadastroCliente);
        }

        // GET: CadastroCliente/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.CadastroCliente == null)
            {
                return NotFound();
            }

            var cadastroCliente = await _context.CadastroCliente.FindAsync(id);
            if (cadastroCliente == null)
            {
                return NotFound();
            }
            return View(cadastroCliente);
        }

        // POST: CadastroCliente/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdCliente,nome,endereco,complemento,bairro,telefone")] CadastroCliente cadastroCliente)
        {
            if (id != cadastroCliente.IdCliente)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cadastroCliente);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CadastroClienteExists(cadastroCliente.IdCliente))
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
            return View(cadastroCliente);
        }

        // GET: CadastroCliente/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.CadastroCliente == null)
            {
                return NotFound();
            }

            var cadastroCliente = await _context.CadastroCliente
                .FirstOrDefaultAsync(m => m.IdCliente == id);
            if (cadastroCliente == null)
            {
                return NotFound();
            }

            return View(cadastroCliente);
        }

        // POST: CadastroCliente/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.CadastroCliente == null)
            {
                return Problem("Entity set 'PizzaDoMarioContext.CadastroCliente'  is null.");
            }
            var cadastroCliente = await _context.CadastroCliente.FindAsync(id);
            if (cadastroCliente != null)
            {
                _context.CadastroCliente.Remove(cadastroCliente);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CadastroClienteExists(int id)
        {
          return (_context.CadastroCliente?.Any(e => e.IdCliente == id)).GetValueOrDefault();
        }
    }
}
