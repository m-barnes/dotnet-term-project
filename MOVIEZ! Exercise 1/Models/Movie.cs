﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MOVIEZ_.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int releaseYear { get; set; }
        public string description { get; set; }
    }
}