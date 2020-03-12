using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Indiana.Controllers
{
    public class MapController : Controller
    {
        public IActionResult Index(string latlong)
        {
            ViewData["latlong"] = latlong;
            return View();
        }
    }
}