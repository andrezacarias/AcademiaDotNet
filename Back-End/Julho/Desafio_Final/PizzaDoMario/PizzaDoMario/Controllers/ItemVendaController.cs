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
    public class ItemVendaController : Controller
    {
        private readonly PizzaDoMarioContext _context;

        public ItemVendaController(PizzaDoMarioContext context)
        {
            _context = context;
        }

        // GET: ItemVenda
        public async Task<IActionResult> Index()
        {
            var pizzaDoMarioContext = _context.ItemVenda.Include(i => i.CadastroCliente).Include(i => i.CadastroProduto);
            return View(await pizzaDoMarioContext.ToListAsync());
        }

        // GET: ItemVenda/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.ItemVenda == null)
            {
                return NotFound();
            }

            var itemVenda = await _context.ItemVenda
                .Include(i => i.CadastroCliente)
                .Include(i => i.CadastroProduto)
                .FirstOrDefaultAsync(m => m.IdItemVenda == id);
            if (itemVenda == null)
            {
                return NotFound();
            }

            return View(itemVenda);
        }

        // GET: ItemVenda/Create
        public IActionResult Create()
        {
            ViewData["IdCliente"] = new SelectList(_context.CadastroCliente, "IdCliente", "telefone");
            ViewData["IdProduto"] = new SelectList(_context.CadastroProduto, "IdProduto", "nomeProduto");
            return View();
        }

        // POST: ItemVenda/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdItemVenda,IdCliente,IdVenda,IdProduto,preco,subTotal,quantidade,dataCompra")] ItemVenda itemVenda)
        {
            itemVenda.subTotal = itemVenda.preco * itemVenda.quantidade;

            _context.Add(itemVenda);
                await _context.SaveChangesAsync();
            //AtualizarVenda(itemVenda.IdVenda);
            return RedirectToAction(nameof(Index));
            
            ViewData["IdCliente"] = new SelectList(_context.CadastroCliente, "IdCliente", "telefone", itemVenda.IdCliente);
            ViewData["IdProduto"] = new SelectList(_context.CadastroProduto, "IdProduto", "nomeProduto", itemVenda.IdProduto);
            return View(itemVenda);
        }

        // GET: ItemVenda/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.ItemVenda == null)
            {
                return NotFound();
            }

            var itemVenda = await _context.ItemVenda.FindAsync(id);
            if (itemVenda == null)
            {
                return NotFound();
            }
            ViewData["IdCliente"] = new SelectList(_context.CadastroCliente, "IdCliente", "telefone", itemVenda.IdCliente);
            ViewData["IdProduto"] = new SelectList(_context.CadastroProduto, "IdProduto", "nomeProduto", itemVenda.IdProduto);
            return View(itemVenda);
        }

        // POST: ItemVenda/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id,  ItemVenda itemVenda)
        {
            if (id != itemVenda.IdItemVenda)
            {
                return NotFound();
            }

            
                try
                {
                    _context.Update(itemVenda);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ItemVendaExists(itemVenda.IdItemVenda))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdCliente"] = new SelectList(_context.CadastroCliente, "IdCliente", "bairro", itemVenda.IdCliente);
            ViewData["IdProduto"] = new SelectList(_context.CadastroProduto, "IdProduto", "descricao", itemVenda.IdProduto);
            return View(itemVenda);
        }

        // GET: ItemVenda/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.ItemVenda == null)
            {
                return NotFound();
            }

            var itemVenda = await _context.ItemVenda
                .Include(i => i.CadastroCliente)
                .Include(i => i.CadastroProduto)
                .FirstOrDefaultAsync(m => m.IdItemVenda == id);
            if (itemVenda == null)
            {
                return NotFound();
            }

            return View(itemVenda);
        }

        // POST: ItemVenda/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.ItemVenda == null)
            {
                return Problem("Entity set 'PizzaDoMarioContext.ItemVenda'  is null.");
            }
            var itemVenda = await _context.ItemVenda.FindAsync(id);
            if (itemVenda != null)
            {
                _context.ItemVenda.Remove(itemVenda);
            }
            
            await _context.SaveChangesAsync();
            //AtualizarVenda(itemVenda.IdVenda);
            return RedirectToAction(nameof(Index));
        }

        private bool ItemVendaExists(int id)
        {
          return (_context.ItemVenda?.Any(e => e.IdItemVenda == id)).GetValueOrDefault();
        }

        //public void AtualizarVenda(int idVenda)
        //{
        //    var venda = _context.Venda.FirstOrDefault(v => v.IdVenda == idVenda);
        //    var itensVendas = _context.ItemVenda.Where(i => i.IdVenda == idVenda);
        //    venda.valorTotal = itensVendas.Sum(i => i.quantidade * i.preco);
        //    //venda.valorTotal = 150;
        //    _context.Update(venda);
        //    _context.SaveChanges();
        //}
    }
}
