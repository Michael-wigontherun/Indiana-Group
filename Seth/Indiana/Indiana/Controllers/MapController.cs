using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Indiana.Controllers
{
    public class MapController : Controller
    {
        public IActionResult Index(string latlong)
        {
            ViewData["latlong"] = latlong;
            Debug.WriteLine($"\n\n{latlong}\n\n\n");
            return View();
        }
    }
}