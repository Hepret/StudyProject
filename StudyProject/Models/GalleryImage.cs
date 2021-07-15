using System.ComponentModel.DataAnnotations;

namespace StudyProject.Models
{
    public class GalleryImage
    {
        [Key]
        public int ImageId { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
        public string ImageLink { get; set; }

        public string Description { get; set; }


    }
}