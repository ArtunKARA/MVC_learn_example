using LrnMvcMovie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LrnMvcMovie.Controllers
{
    public class HomeController : Controller
    {
        private MovieDBContext db = new MovieDBContext();
        public ActionResult Index(string searchString)
        {
            var movies = from m in db.Movies select m;
            if (!String.IsNullOrEmpty(searchString))
            {
                movies = movies.Where(s => s.Title.Contains(searchString));
            }
            return View(db.Movies.ToList());
           
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}