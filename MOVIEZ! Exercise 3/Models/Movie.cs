﻿using System;
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
        [Display(Name = "Genre")]
        public Genre Genre { get; set; }
        public byte GenreId { get; set; }

        [Display(Name = "Release Date")]
        public int ReleaseDate { get; set; }
        public string Description { get; set; }
        public DateTime DateAdded { get; set; }
        [Display(Name = "Number in Stock")]
        public int InStock { get; set; }
    }
}