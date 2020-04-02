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

namespace Indiana.Controllers
{
    public class TruckingCompaniesController : Controller
    {
        private readonly ApplicationDbContext Database;

        public TruckingCompaniesController(ApplicationDbContext context)
        {
            Database = context;
        }

        //this is a variable to change the amount of rows per page
        public int countPerPage = 100;
        public async Task<IActionResult> Index()
        {
            //if you add something here you must do it in post index

            //below is for pagination
            //do not touch below
            ViewData["currenthmflag"] = "";
            ViewData["hmflaglist"] = new List<string>() { "Y", "N" };
            ViewData["currentpcflag"] = "";
            ViewData["pcflaglist"] = new List<string>() { "Y", "N" };
            ViewData["SearchString"] = "";
            ViewData["UserID"] = GetCurrentUserID();
            List<TruckingCompanies> list = await Database.TruckingCompanies.ToListAsync();
            ViewData["Page"] = 1;
            ViewData["pages"] = GetPageAmount(list.Count(), countPerPage);
            ViewData["pageList"] = getPageOptions((int)ViewData["Page"], (int)ViewData["pages"]);
            ViewData["list"] =
                getCurrentPage(list, (int)ViewData["Page"], (int)ViewData["pages"], countPerPage);
            return View();
            //do not touch above
        }
        [HttpPost]
        public async Task<IActionResult> Index(int page, string keyword, String hmflag, String pcflag)
        {
            //if you add something here you must do it in main index

            //below is for pagination
            //do not touch below
            if (keyword == null)
            {
                keyword = "";
            }
            if (hmflag == null)
            {
                hmflag = "";
            }
            if (pcflag == null)
            {
                pcflag = "";
            }
            List<TruckingCompanies> list;
            if (keyword != "" && hmflag != "" && pcflag != "")
            {
                list = await Database.TruckingCompanies
                    .Where(b => b.LegalName.Contains(keyword) == true ||
                    b.Dbaname.Contains(keyword) == true)
                    .Where(b => b.HmFlag == hmflag)
                    .Where(b => b.PcFlag == pcflag).ToListAsync();
            }
            else if (keyword == "" && hmflag == "" && pcflag != "")
            {
                list = await Database.TruckingCompanies
                    .Where(b => b.PcFlag == pcflag).ToListAsync();
            }
            else if (keyword == "" && hmflag != "" && pcflag == "")
            {
                list = await Database.TruckingCompanies
                    .Where(b => b.HmFlag == hmflag).ToListAsync();
            }
            else if (keyword != "" && hmflag != "" && pcflag == "")
            {
                list = await Database.TruckingCompanies
                    .Where(b => b.LegalName.Contains(keyword) == true ||
                    b.Dbaname.Contains(keyword) == true)
                    .Where(b => b.HmFlag == hmflag).ToListAsync();
            }
            else if (keyword != "" && hmflag == "" && pcflag != "")
            {
                list = await Database.TruckingCompanies
                    .Where(b => b.LegalName.Contains(keyword) == true ||
                    b.Dbaname.Contains(keyword) == true)
                    .Where(b => b.PcFlag == pcflag).ToListAsync();
            }
            else if (keyword != "" && hmflag == "" && pcflag == "")
            {
                list = await Database.TruckingCompanies
                    .Where(b => b.LegalName.Contains(keyword) == true ||
                    b.Dbaname.Contains(keyword) == true).ToListAsync();
            }
            else
            {
                list = await Database.TruckingCompanies.ToListAsync();
            }
            ViewData["currenthmflag"] = hmflag;
            ViewData["hmflaglist"] = new List<string>() { "Y", "N" };
            ViewData["currentpcflag"] = pcflag;
            ViewData["pcflaglist"] = new List<string>() { "Y", "N" };
            ViewData["SearchString"] = keyword;
            ViewData["UserID"] = GetCurrentUserID();
            ViewData["Page"] = page;
            ViewData["pages"] = GetPageAmount(list.Count(), countPerPage);
            ViewData["pageList"] = getPageOptions((int)ViewData["Page"], (int)ViewData["pages"]);
            ViewData["list"] =
                getCurrentPage(list, (int)ViewData["Page"], (int)ViewData["pages"], countPerPage);
            return View();
            //do not touch above
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
        public async Task<IActionResult> Create([Bind("Usdot,LegalName,Dbaname,CarrierOperation,HmFlag,PcFlag,PhyStreet,PhyCity,PhyState,PhyZip,PhyCountry,MailingStreet,MailingCity,MailingState,MailingZip,MailingCountry,Telephone,Fax,EmailAddress,Mcs150Date,Mcs150Mileage,Mcs150MileageYear,AddDate,OicState,NbrPowerUnit,DriverTotal,GeoLocation,AddminId")] TruckingCompanies truckingCompanies)
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
        public async Task<IActionResult> Edit(string id, [Bind("Usdot,LegalName,Dbaname,CarrierOperation,HmFlag,PcFlag,PhyStreet,PhyCity,PhyState,PhyZip,PhyCountry,MailingStreet,MailingCity,MailingState,MailingZip,MailingCountry,Telephone,Fax,EmailAddress,Mcs150Date,Mcs150Mileage,Mcs150MileageYear,AddDate,OicState,NbrPowerUnit,DriverTotal,GeoLocation,AddminId")] TruckingCompanies truckingCompanies)
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
        public string GetCurrentUserID()
        {
            var claimsIdentity = (ClaimsIdentity)this.User.Identity;
            var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
            return claim?.Value;
        }
        public string GetCurrentUserName()
        {
            var claimsIdentity = (ClaimsIdentity)this.User.Identity;
            var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
            var claimID = claim?.Value;
            return Database.Users.Where(u => u.Id == claimID).Single().UserName;
        }
        public List<T> getCurrentPage<T>(List<T> list, int page, int pages, int countPerPage)
        {
            if (page == 0 || page > pages)
            {
                page = 1;
            }
            int pageStart = (page - 1) * countPerPage;
            List<T> temp = new List<T>();
            if (page == 1)
            {
                pageStart = 0;
            }
            for (int i = pageStart; i < list.Count(); i++)
            {
                temp.Add(list.ElementAt(i));
                if (temp.Count() == countPerPage)
                {
                    break;
                }
            }
            return temp;
        }
        public List<int> getPageOptions(int page, int pages)
        {
            int start;
            int controller;
            if (page < 10)
            {
                page -= 5;
                page = Clamp(page, 1, pages);
                start = page;
                controller = page + 10;
            }
            else if (page > pages - 10)
            {
                page += 5;
                page = Clamp(page, 1, pages);
                start = page - 10;
                controller = page;
            }
            else
            {
                page -= 5;
                start = page;
                controller = page + 10;
            }
            List<int> list = new List<int>();
            for (int i = start; i <= controller; i++)
            {
                list.Add(i);
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

        public int GetPageAmount(int listCount, int countPerPage)
        {
            int i = listCount / countPerPage;
            if (listCount % countPerPage != 0)
            {
                i += 1;
            }
            return i;
        }
    }
}
