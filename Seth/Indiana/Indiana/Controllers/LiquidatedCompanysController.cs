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
    public class LiquidatedCompanysController : Controller
    {
        private readonly ApplicationDbContext _context;

        public LiquidatedCompanysController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: LiquidatedCompanys
        public async Task<IActionResult> Index()
        {
            return View(await _context.LiquidatedCompanys.ToListAsync());
        }

        // GET: LiquidatedCompanys/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var liquidatedCompanys = await _context.LiquidatedCompanys
                .FirstOrDefaultAsync(m => m.Usdot == id);
            if (liquidatedCompanys == null)
            {
                return NotFound();
            }

            return View(liquidatedCompanys);
        }

        // GET: LiquidatedCompanys/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: LiquidatedCompanys/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Usdot,LegalName,Dbaname,Address,Oosreason,Oosdate,Status,GeoLocation,addminID")] LiquidatedCompanys liquidatedCompanys)
        {
            if (ModelState.IsValid)
            {
                _context.Add(liquidatedCompanys);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(liquidatedCompanys);
        }

        // GET: LiquidatedCompanys/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var liquidatedCompanys = await _context.LiquidatedCompanys.FindAsync(id);
            if (liquidatedCompanys == null)
            {
                return NotFound();
            }
            return View(liquidatedCompanys);
        }

        // POST: LiquidatedCompanys/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Usdot,LegalName,Dbaname,Address,Oosreason,Oosdate,Status,GeoLocation,addminID")] LiquidatedCompanys liquidatedCompanys)
        {
            if (id != liquidatedCompanys.Usdot)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(liquidatedCompanys);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LiquidatedCompanysExists(liquidatedCompanys.Usdot))
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
            return View(liquidatedCompanys);
        }

        // GET: LiquidatedCompanys/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var liquidatedCompanys = await _context.LiquidatedCompanys
                .FirstOrDefaultAsync(m => m.Usdot == id);
            if (liquidatedCompanys == null)
            {
                return NotFound();
            }

            return View(liquidatedCompanys);
        }

        // POST: LiquidatedCompanys/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var liquidatedCompanys = await _context.LiquidatedCompanys.FindAsync(id);
            _context.LiquidatedCompanys.Remove(liquidatedCompanys);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LiquidatedCompanysExists(string id)
        {
            return _context.LiquidatedCompanys.Any(e => e.Usdot == id);
        }
    }
}
