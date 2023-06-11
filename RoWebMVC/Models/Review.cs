using System.ComponentModel.DataAnnotations;

namespace RoWebMVC.Models
{
    public class Review
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string UserName { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy HH:mm:ss}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; } = DateTime.Now;
        public string Description { get; set; }

        public int VideoGameId { get; set; }
        public VideoGame VideoGame { get; set; }

    }
}
