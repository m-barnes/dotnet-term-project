using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MOVIEZ_.Models;

namespace MOVIEZ_.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Star Wars: The Empire Strikes Back", Id = 23165497};

            return View(movie);
        }
    }
}

//localhost:44320/Movies/Random