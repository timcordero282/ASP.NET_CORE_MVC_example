using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Assignment3.Models;

namespace Assignment3.Controllers
{
    public class HomeController : Controller
    {
        private ProfessorContext context { get; set; }
        public HomeController(ProfessorContext ctx)
        {
            context = ctx;
        }

        public IActionResult Index()
        {
            var professors = context.Professors.OrderBy(p => p.LastName).ToList();
            return View(professors);
        }
        public IActionResult Add()
        {
            return View();
        }
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
