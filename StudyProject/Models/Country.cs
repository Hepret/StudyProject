using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudyProject.Models
{
    public class Country
    {
        [Key]
        public int CountryId { get; set; }
        public string Name { get; set; }
        public string CardDescription { get; set; }

        public string CardTagline { get; set; }

        public string CardPhotoLink { get; set; }

        public bool IsHot { get; set; }
        public CountryArticle CountryArticle { get; set; }

        public ICollection<GalleryImage> GalleryImages {get; set;}
        

    }
}
