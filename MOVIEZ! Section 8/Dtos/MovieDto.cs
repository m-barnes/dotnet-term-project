using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using MOVIEZ_.Models;

namespace MOVIEZ_.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "The movie name is required.")]
        [StringLength(255)]
        public string Name { get; set; }

        public GenreDto Genre { get; set; }
        [Required(ErrorMessage = "Please select a Genre.")]
        public byte GenreId { get; set; }

        [Required(ErrorMessage = "A release date is required.")]
        public DateTime? ReleaseDate { get; set; }
        [Required(ErrorMessage = "A description is required.")]
        public string Description { get; set; }
        [Required]
        public DateTime DateAdded { get; set; }
        [Required]
        [Range(1, 20, ErrorMessage = ("Value must be between 1 and 20"))]
        public int InStock { get; set; }
    }
}