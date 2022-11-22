using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace VegetarianMovieList.Models
{
    public class Movie
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MovieId { get; set; }
        [Required]
        public string Title { get; set; } = "Title";
        [DataType(DataType.Date)]
        public DateTime Released { get; set; } = DateTime.Now;
        [Range(0, 10)]
        public double Rating { get; set; } = 5;
        [DataType(DataType.ImageUrl)]
        public string ImageUrl { get; set; } = "URL";
        public List<MovieDetails> MoviesDetails { get; set; } = new List<MovieDetails>();
    }
}
