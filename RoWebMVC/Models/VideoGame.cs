using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RoWebMVC.Models
{
    public class VideoGame
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(150)]
        [DisplayName("Name")]
        public string Title { get; set; }
        [Required]
        public string Category { get; set; }
        public int? YearReleased { get; set; }
        public string Company { get; set; }
        public List<Review> Reviews { get; set; } = new List<Review>();
    }
}
