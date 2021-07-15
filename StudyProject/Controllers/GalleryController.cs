using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudyProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudyProject.Controllers
{
    public class GalleryController : Controller
    {
        CountryContext db;

        public GalleryController(CountryContext context)
        {
            db = context;
        }


        public IActionResult Index()
        {
            var country = db.Countries.Where(c => c.GalleryImages.Count != 0).Include(c => c.GalleryImages).ToList();
            return View(country);
        }
    }
}
