using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
 
        public ViewResult Index()
        {
            var movies = GetMovies();
            return View(movies);
        }

        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie { Id = 1, Name = "Joker"},
                new Movie { Id = 2, Name = "Two Popes"}
            };
        }

        //GET: Movies/Random

        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Joker" };
            var customers = new List<Customer>
            {
                new Customer { Name = "Rob"},
                new Customer { Name = "Mike"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
        }


    }
}