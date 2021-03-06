﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Indiana.Data;
using Indiana.Models;
using System.Diagnostics;

namespace Indiana.Controllers
{
    public class MapController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MapController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Map
        public async Task<IActionResult> Index(string latlong)
        {
            string lats = "";
            string lngs = "";
            List<TruckingCompanies> truckingCompanies = await _context.TruckingCompanies.ToListAsync();
            string[] geol;
            for(int i = 0; i < truckingCompanies.Count(); i++)
            {
                geol = truckingCompanies.ElementAt(i).GeoLocation.Split(":");
                if (geol.Length == 2)
                {
                    lats += geol[0] + ",";
                    lngs += geol[1] + ",";
                }
            }
            ViewData["lats"] = lats;
            ViewData["lngs"] = lngs;
            try
            {
                if (latlong.Contains(":") && latlong != null)
                {
                    string[] col = latlong.Split(":");
                    ViewData["lat"] = col[0];
                    ViewData["long"] = col[1];
                }
            }
            catch(Exception e)
            {

            }
            return View();
        }
    }
}
