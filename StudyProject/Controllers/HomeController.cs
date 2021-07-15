using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using StudyProject.Models;
using System.Linq;

namespace StudyProject.Controllers
{
    public class HomeController : Controller
    {
         
        private readonly ILogger<HomeController> _logger;

        CountryContext db;

        public HomeController(CountryContext context, ILogger<HomeController> logger)
        {
                db = context;
                _logger = logger;
        }
        public IActionResult Index()
        {
            return View(db.Countries.ToList());
        }

        public IActionResult Countries()
        {
            return View(db.Countries.ToList());
        }
        public IActionResult AboutUs()
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
    