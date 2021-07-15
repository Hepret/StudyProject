using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudyProject.Models
{
    public class CountryArticle
    {
        public int Id { get; set; }
        public string Info { get; set; }
        public string BestTimeToVisit { get; set; }
        public string ThingsToDo { get; set; }
        public string TouristAttractions { get; set; }
        public string PlacesToStay { get; set; }
        public string PlacesToEat { get; set; }
        public string Language { get; set; }
        public string Currency {get ; set;}
        public string ImageLink { get; set; }

        public Country Country { get; set; }
        public int CountryId { get; set; }

    }
}
