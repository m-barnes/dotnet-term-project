using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MOVIEZ_.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "The movie name is required.")]
        [StringLength(255)]
        public string Name { get; set; }

        public Genre Genre { get; set; }
        [Display(Name = "Genre")]
        [Required(ErrorMessage = "Please select a Genre.")]
        public byte GenreId { get; set; }

        [Display(Name = "Release Date")]
        [Required(ErrorMessage = "A release date is required.")]
        public DateTime? ReleaseDate { get; set; }
        [Required(ErrorMessage = "A description is required.")]
        public string Description { get; set; }
        public DateTime DateAdded { get; set; }
        [Required]
        [Display(Name = "Number in Stock")]
        [Range(1, 20, ErrorMessage = ("Value must be between 1 and 20"))]
        public int InStock { get; set; }
    }
}