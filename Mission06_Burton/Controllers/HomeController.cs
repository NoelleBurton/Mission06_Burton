using Microsoft.AspNetCore.Mvc;
using Mission06_Burton.Models;
using System.Diagnostics;

namespace Mission06_Burton.Controllers
{
    public class HomeController : Controller
    {

        private MovieContext _context;

        public HomeController(MovieContext temp)
        {
            _context = temp;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddMovie()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddMovie(AddMovie response)
        {
            _context.Movies.Add(response);
            _context.SaveChanges();

            return View("Response", response);
        }

        public IActionResult MovieTable()
        {
            var movieList = _context.Movies
                .OrderBy(x => x.Title).ToList();

            return View(movieList);
        }

    }
}
