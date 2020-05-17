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
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        [Required]
        public Genre Genre { get; set; }
        public byte GenreId { get; set; }


        public int ReleaseDate { get; set; }
        public string Description { get; set; }
        public DateTime DateAdded { get; set; }
        public int InStock { get; set; }
    }
}