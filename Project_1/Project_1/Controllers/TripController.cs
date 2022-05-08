using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Project_1.Models;

namespace Project_1.Controllers
{
    public class TripController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        private TripContext context { get; set; }

        public TripController(TripContext ctx)
        {
            context = ctx;
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            return View("Edit", new Trip());
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            var movie = context.Trips.Find(id);
            return View(movie);
        }

        [HttpPost]
        public IActionResult Edit(Trip movie)
        {
            if (ModelState.IsValid)
            {
                if (movie.TripId == 0)
                    context.Trips.Add(movie);
                else
                    context.Trips.Update(movie);
                context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Action = (movie.TripId == 0) ? "Add" : "Edit";
                return View(movie);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var movie = context.Trips.Find(id);
            return View(movie);
        }

        [HttpPost]
        public IActionResult Delete(Trip movie)
        {
            context.Trips.Remove(movie);
            context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }

    }
}
