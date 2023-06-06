using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GamesCollection.Models
{
    public class GameViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "This field can not be empty!")]
        public string Title { get; set; }
        [Required(ErrorMessage = "This field can not be empty!")]
        public string Producer { get; set; }
        [Required(ErrorMessage = "This field can not be empty!")]
        public string Platform { get; set; }
        [Required(ErrorMessage = "This field can not be empty!")]
        public string Region { get; set; }
        [Required(ErrorMessage = "This field can not be empty!")]
        [DataType(DataType.Date)]
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }
        [Required(ErrorMessage = "This field can not be empty!")]
        public string Genre { get; set; }
        [Required(ErrorMessage = "This field can not be empty!")]
        [Column(TypeName = "decimal(18, 2)")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal Price { get; set; }
    }
}
