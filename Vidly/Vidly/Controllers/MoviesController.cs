using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {

            var movie = new Movie() { Name = "Shrek!" };
            var customers = new List<Customer>
            {
                new Customer {Name = "Customer 1"},
                new Customer {Name = "Customer 2"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };
            return View(viewModel);
            //return Content("Hello World");
            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("Index" ,"Home",new {page = 1 , sortBy = "name"});
        }
        public ActionResult Edit(int id)
        {
            return Content("id= " + id);
        }

        // movies
        public ActionResult Index()
        {
           var movies = GetMovie();
           return View(movies);
        }

        [Route("movies/released/{year}/{month}")]
        public ActionResult ByRelaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
        private IEnumerable<Movie> GetMovie()
        {
            return new List<Movie>
            {
                new Movie() {Name = "Shrek !!"},
                new Movie() {Name = "Wall - e" }
            };
        }
    }
}
