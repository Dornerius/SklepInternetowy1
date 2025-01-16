using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SklepIntranet.Data;
using SklepIntranet.Models.Finance;

namespace SklepIntranet.Controllers
{
    public class FacturesController : Controller
    {
        private readonly SklepIntranetContext _context;

        public FacturesController(SklepIntranetContext context)
        {
            _context = context;
        }

        // GET: Factures
        public async Task<IActionResult> Index()
        {
            return View(await _context.Factures.ToListAsync());
        }

        // GET: Factures/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var factures = await _context.Factures
                .FirstOrDefaultAsync(m => m.IdFacture == id);
            if (factures == null)
            {
                return NotFound();
            }

            return View(factures);
        }

        // GET: Factures/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Factures/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdFacture,NrFacture,DateFacture,DateSale,Department,ClientNdName,ClientNdSurname,ClientAdressCity,ClientAdressStreetNr,ClientContact,ProductName,PriceNetto,PriceVAT,PriceBrutto")] Factures factures)
        {
            if (ModelState.IsValid)
            {
                _context.Add(factures);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(factures);
        }

        // GET: Factures/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var factures = await _context.Factures.FindAsync(id);
            if (factures == null)
            {
                return NotFound();
            }
            return View(factures);
        }

        // POST: Factures/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdFacture,NrFacture,DateFacture,DateSale,Department,ClientNdName,ClientNdSurname,ClientAdressCity,ClientAdressStreetNr,ClientContact,ProductName,PriceNetto,PriceVAT,PriceBrutto")] Factures factures)
        {
            if (id != factures.IdFacture)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(factures);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FacturesExists(factures.IdFacture))
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
            return View(factures);
        }

        // GET: Factures/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var factures = await _context.Factures
                .FirstOrDefaultAsync(m => m.IdFacture == id);
            if (factures == null)
            {
                return NotFound();
            }

            return View(factures);
        }

        // POST: Factures/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var factures = await _context.Factures.FindAsync(id);
            if (factures != null)
            {
                _context.Factures.Remove(factures);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FacturesExists(int id)
        {
            return _context.Factures.Any(e => e.IdFacture == id);
        }
    }
}
