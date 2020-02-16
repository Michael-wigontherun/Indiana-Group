using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Indiana.Data;
using Indiana.Models;
using System.Security.Claims;
using System.Diagnostics;

namespace Indiana.Controllers
{
    public class TruckingCompaniesController : Controller
    {
        private readonly ApplicationDbContext Database;

        public TruckingCompaniesController(ApplicationDbContext context)
        {
            Database = context;
        }

        // GET: TruckingCompanies
        public async Task<IActionResult> Index()
        {
            //ViewData["list"] = await Database.TruckingCompanies.Take(20).ToListAsync();

            ViewData["UserID"] = getCurrentUserID();
            var applicationDbContext = Database.TruckingCompanies;
            List<TruckingCompanies> list = await applicationDbContext.ToListAsync();
            //list = addUserNames(list);
            //ViewData["SearchString"] = "";
            ViewData["Page"] = 1;
            ViewData["pages"] = GetPageAmount(list.Count());
            ViewData["SelectedPlatform"] = -1;
            ViewData["SelectedGame"] = -1;
            ViewData["list"] =
                getCurrentPage(list, (int)ViewData["Page"], (int)ViewData["pages"]);
            getPageOptions((int)ViewData["Page"], (int)ViewData["pages"]);
            return View();
        }


        // GET: TruckingCompanies/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var truckingCompanies = await Database.TruckingCompanies
                .FirstOrDefaultAsync(m => m.Usdot == id);
            if (truckingCompanies == null)
            {
                return NotFound();
            }

            return View(truckingCompanies);
        }

        // GET: TruckingCompanies/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TruckingCompanies/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Usdot,LegalName,Dbaname,CARRIER_OPERATION_,HM_FLAG_,PC_FLAG_,PHY_STREET_,PHY_CITY_,PHY_STATE_,PHY_ZIP_,PHY_COUNTRY_,MAILING_STREET_,MAILING_CITY_,MAILING_STATE_,MAILING_ZIP_,MAILING_COUNTRY_,TELEPHONE_,FAX_,EMAIL_ADDRESS_,MCS150_DATE_,MCS150_MILEAGE_,MCS150_MILEAGE_YEAR_,ADD_DATE_,OIC_STATE_,NBR_POWER_UNIT_,DRIVER_TOTAL_,GeoLocation,addminID")] TruckingCompanies truckingCompanies)
        {
            if (ModelState.IsValid)
            {
                Database.Add(truckingCompanies);
                await Database.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(truckingCompanies);
        }

        // GET: TruckingCompanies/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var truckingCompanies = await Database.TruckingCompanies.FindAsync(id);
            if (truckingCompanies == null)
            {
                return NotFound();
            }
            return View(truckingCompanies);
        }

        // POST: TruckingCompanies/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Usdot,LegalName,Dbaname,CARRIER_OPERATION_,HM_FLAG_,PC_FLAG_,PHY_STREET_,PHY_CITY_,PHY_STATE_,PHY_ZIP_,PHY_COUNTRY_,MAILING_STREET_,MAILING_CITY_,MAILING_STATE_,MAILING_ZIP_,MAILING_COUNTRY_,TELEPHONE_,FAX_,EMAIL_ADDRESS_,MCS150_DATE_,MCS150_MILEAGE_,MCS150_MILEAGE_YEAR_,ADD_DATE_,OIC_STATE_,NBR_POWER_UNIT_,DRIVER_TOTAL_,GeoLocation,addminID")] TruckingCompanies truckingCompanies)
        {
            if (id != truckingCompanies.Usdot)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    Database.Update(truckingCompanies);
                    await Database.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TruckingCompaniesExists(truckingCompanies.Usdot))
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
            return View(truckingCompanies);
        }

        // GET: TruckingCompanies/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var truckingCompanies = await Database.TruckingCompanies
                .FirstOrDefaultAsync(m => m.Usdot == id);
            if (truckingCompanies == null)
            {
                return NotFound();
            }

            return View(truckingCompanies);
        }

        // POST: TruckingCompanies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var truckingCompanies = await Database.TruckingCompanies.FindAsync(id);
            Database.TruckingCompanies.Remove(truckingCompanies);
            await Database.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TruckingCompaniesExists(string id)
        {
            return Database.TruckingCompanies.Any(e => e.Usdot == id);
        }
        public string getCurrentUserID()
        {
            var claimsIdentity = (ClaimsIdentity)this.User.Identity;
            var claim = claimsIdentity.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier);
            return claim?.Value;
        }
        public string getCurrentUserName()
        {
            var claimsIdentity = (ClaimsIdentity)this.User.Identity;
            var claim = claimsIdentity.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier);
            var claimID = claim?.Value;
            return Database.Users.Where(u => u.Id == claimID).Single().UserName;
        }
        public List<T> getCurrentPage<T>(List<T> list, int page, int pages)
        {
            if (page == 0 || page > pages)
            {
                page = 1;
            }
            int pageStart = (page - 1) * 100;
            int pageEnd = page * 100;
            List<T> temp = new List<T>();
            if (page <= 1)
            {
                pageStart = 0;
            }
            if (page == pages)
            {
                pageEnd = list.Count();
            }
            for (int i = pageStart; i < pageEnd; i++)
            {
                temp.Add(list.ElementAt(i));

            }
            return temp;
        }
        public List<int> getPageOptions(int page, int pages)
        {
            List<int> list = new List<int>();
            if (page < 10)
            {
                page -= 5;
                page = Clamp(page, 1, pages);
                for (int i = page; i <= page + 10; i++)
                {
                    list.Add(i);
                }
            }
            else if (page > pages - 10)
            {
                page += 5;
                page = Clamp(page, 1, pages);
                for (int i = page - 10; i <= page; i++)
                {
                    list.Add(i);
                }
            }
            else
            {
                page -= 5;
                for (int i = page; i <= page + 10; i++)
                {
                    list.Add(i);
                }
            }
            return list;
        }
        public int Clamp(int value, int min, int max)
        {
            if (min <= value && value <= max)
            {
                return value;
            }
            else if (value < min)
            {
                return min;
            }
            else
            {
                return max;
            }
        }

        public int GetPageAmount(int listCount)
        {
            int i = listCount / 10;
            if (listCount % 10 != 0)
            {
                i += 1;
            }
            return i;
        }
    }
    }


