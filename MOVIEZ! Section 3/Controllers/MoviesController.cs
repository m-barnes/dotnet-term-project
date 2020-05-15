using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MOVIEZ_.Models;
using MOVIEZ_.ViewModels;


namespace MOVIEZ_.Controllers
{
    public class MoviesController : Controller
    {

        public ViewResult Index()
        {
            var movies = GetMovies();

            return View(movies);
        }

        public ActionResult Details(int id)
        {
            var movie = GetMovies().SingleOrDefault(c => c.Id == id);

            if (movie == null)
                return HttpNotFound();

            return View(movie);
        }

        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie { Id = 1, Name = "Die Hard", releaseYear= 1988, description = "Die Hard is a 1988 American action thriller film directed by John McTiernan and written by Steven E. de Souza and Jeb Stuart, based on Roderick Thorp's 1979 novel Nothing Lasts Forever. It was produced by the Gordon Company and Silver Pictures, and distributed by 20th Century Fox. The film follows off-duty New York City Police Department officer John McClane (Bruce Willis) who is caught in a Los Angeles skyscraper during a heist led by Hans Gruber (Alan Rickman)."  },
                new Movie { Id = 2, Name = "The Fast and the Furious", releaseYear=2001, description="The Fast and the Furious is a 2001 crime action adventure film directed by Rob Cohen and written by Gary Scott Thompson and David Ayer. It is the first installment in The Fast and the Furious franchise. It was released in the United States on June 22, 2001. The Fast and the Furious follows Brian O'Conner (Paul Walker), an undercover cop tasked with discovering the identities of a group of unknown automobile hijackers led by Dominic Toretto (Vin Diesel)."}
            };
        }



        public ViewResult Random()
        {
            var movie = new Movie() { Name = "Star Wars: The Empire Strikes Back", Id = 23165497 };

            var customers = new List<Customer>
            {
                new Customer {Name = "Customer 1" },
                new Customer {Name = "Customer 2" }

            };

            var ViewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(ViewModel);
        }









    }
}

//localhost:44320/Movies/Random