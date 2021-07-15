using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudyProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudyProject.Controllers
{
    public class CountriesController : Controller
    {
        CountryContext db;
        public CountriesController(CountryContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            return View(db.Countries.ToList());
        }

        public async Task<IActionResult> Get (int? id)
        {
            if (id != null)
            {
                Country country = await db.Countries.Include(c => c.CountryArticle).FirstOrDefaultAsync(p => p.CountryId == id);
                if (country != null)
                {
                    return View(country.CountryArticle);
                }
            }
            return NotFound();
        }
    }
}
