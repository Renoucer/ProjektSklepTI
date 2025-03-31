using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjektSklepTI.Models
{
    public class Film
    {
        public int FilmId { get; set; }
        [Required]
        public string Title { get; set; }

        public string Director { get; set;}
        [MaxLength(500)]
        public string Desc { get; set;}

        public decimal Price { get; set;}
        public string Poster { get; set;}

        [ForeignKey("Category")]
        public int CategoryId { get; set;}

        public Category Category { get; set;}

    }
}
