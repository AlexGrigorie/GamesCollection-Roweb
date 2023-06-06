using GamesCollection.Data.DbModels;
using System.ComponentModel.DataAnnotations;

namespace GamesCollection.Models
{
    public class ReviewViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "This field can not be empty!")]
        [Display(Name = "Your Name")]
        public string Username { get; set; }
        [Required(ErrorMessage = "This field can not be empty!")]
        [Display(Name = "Your opinion")]
        public string Review { get; set; }
        public DateTime ReviewDate { get; set; }
        public GameDbModel Game { get; set; }
        public int? GameId { get; set; }
    }
}
