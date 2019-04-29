using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using aspnetcore_filter.Models;
using aspnetcore_filter.Filters;

namespace aspnetcore_filter.Controllers
{
    public class HomeController : Controller
    {
        [ResultFilterSample]
        public IActionResult Index()
        {
            return View();
        }

        [ResultFilterSample("Author-X", "Aykut Asil - X")]
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
