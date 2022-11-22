using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VegetarianMovieList.Models
{
    public class MovieDetails
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MovieDetailsId { get; set; }
        public string Description { get; set; }
        public string Actor { get; set; }
        public int Budget { get; set; }
        [ForeignKey(nameof(MovieClassId))]
        public int MovieClassId { get; set; }
        public Movie Movie { get; set; }
        
    }
}
