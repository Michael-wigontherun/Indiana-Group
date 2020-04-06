using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Indiana.Data;
using Indiana.Models;

namespace Indiana.Controllers
{
    public class ChameleonCompaniesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ChameleonCompaniesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ChameleonCompanies
        public async Task<IActionResult> Index()
        {
            return View(await _context.ChameleonCompanies.ToListAsync());
        }

        // GET: ChameleonCompanies/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chameleonCompanies = await _context.ChameleonCompanies
                .FirstOrDefaultAsync(m => m.Usdot == id);
            if (chameleonCompanies == null)
            {
                return NotFound();
            }

            return View(chameleonCompanies);
        }

        // GET: ChameleonCompanies/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ChameleonCompanies/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Usdot,PercentOcham,AddminId")] ChameleonCompanies chameleonCompanies)
        {
            if (ModelState.IsValid)
            {
                _context.Add(chameleonCompanies);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(chameleonCompanies);
        }

        // GET: ChameleonCompanies/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chameleonCompanies = await _context.ChameleonCompanies.FindAsync(id);
            if (chameleonCompanies == null)
            {
                return NotFound();
            }
            return View(chameleonCompanies);
        }

        // POST: ChameleonCompanies/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Usdot,PercentOcham,AddminId")] ChameleonCompanies chameleonCompanies)
        {
            if (id != chameleonCompanies.Usdot)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(chameleonCompanies);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ChameleonCompaniesExists(chameleonCompanies.Usdot))
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
            return View(chameleonCompanies);
        }

        // GET: ChameleonCompanies/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chameleonCompanies = await _context.ChameleonCompanies
                .FirstOrDefaultAsync(m => m.Usdot == id);
            if (chameleonCompanies == null)
            {
                return NotFound();
            }

            return View(chameleonCompanies);
        }

        // POST: ChameleonCompanies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var chameleonCompanies = await _context.ChameleonCompanies.FindAsync(id);
            _context.ChameleonCompanies.Remove(chameleonCompanies);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ChameleonCompaniesExists(string id)
        {
            return _context.ChameleonCompanies.Any(e => e.Usdot == id);
        }
    }
}
