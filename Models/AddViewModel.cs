using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjektSklepTI.Models
{
        public class AddViewModel
        {
            public Film NewFilm { get; set; }
            public IFormFile Poster { get; set; }
            public List<Category> AllCategories { get; set; }
        }
    
}
