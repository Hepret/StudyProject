using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudyProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudyProject.Controllers
{
    public class AdminController : Controller
    {
        CountryContext db;
        public AdminController(CountryContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            return View(db.Countries.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Country country)
        {
            db.Countries.Add(country);
            await db.SaveChangesAsync();
            return RedirectToAction("index");
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id != null)
            {
                Country country = await db.Countries.FirstOrDefaultAsync(p => p.CountryId == id);
                if (country != null)
                    return View(country);
            }
            return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Country country)
        {
            db.Countries.Update(country);
            await db.SaveChangesAsync();
            return RedirectToAction("index");
        }
        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id != null)
            {
                Country country = await db.Countries.FirstOrDefaultAsync(p => p.CountryId == id);
                if (country != null)
                    return View(country);
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Country country)
        {
            db.Remove(country);
            await db.SaveChangesAsync();
            return RedirectToAction("index");

        }
        
        [HttpGet]
        public async Task<IActionResult> AddToHot(int? id)
        {
            if (id != null)
            {
                Country country = await db.Countries.FirstOrDefaultAsync(p => p.CountryId == id);
                if (country != null)
                {
                    if (country.IsHot) country.IsHot = false;
                    else country.IsHot = true;

                    db.Countries.Update(country);
                    db.SaveChanges();

                    return RedirectToAction("index");

                }
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> AddToHot(Country country)
        {
            
            db.Countries.Update(country);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult CreateArticle(int? id)
        {
            if (id != null)
            {
                Country country = db.Countries.FirstOrDefault(c => c.CountryId == id);
                if (country != null)
                {
                    return View();
                }
            }

            return NotFound();   
        }

        [HttpPost]
        public IActionResult CreateArticle(int id, CountryArticle article)
        {
            article.Id = 0;
            article.CountryId = id;

            db.CountryArtciles.Add(article);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult AddImage(int? id)
        {
            if (id != null)
            {
                Country country = db.Countries.FirstOrDefault(c => c.CountryId == id);
                if (country != null)
                {
                    return View();
                }
            }
            return NotFound();
        }

        [HttpPost]
        public IActionResult AddImage(int id, GalleryImage image)
        {
            image.ImageId = 0;
            image.CountryId = id;

            db.GalleryImages.Add(image);
            db.SaveChanges();
            return RedirectToAction("index");
        }
    }
}
