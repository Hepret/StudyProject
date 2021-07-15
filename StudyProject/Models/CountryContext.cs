using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudyProject.Models
{
    public class CountryContext : DbContext
    {
        public DbSet<Country> Countries { get; set; }

        public DbSet<CountryArticle> CountryArtciles { get; set; }

        public DbSet<GalleryImage> GalleryImages { get; set; }
        public CountryContext(DbContextOptions<CountryContext> options)
            : base(options)
        {
        Database.EnsureCreated();
        }

    }
}
