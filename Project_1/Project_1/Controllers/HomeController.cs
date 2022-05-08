using Microsoft.AspNetCore.Mvc;
using Project_1.Models;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using System.Linq;


namespace Project_1.Controllers
{
    public class HomeController : Controller
    {
        private TripContext context { get; set; }


        public HomeController(TripContext ctx)
        {
            context = ctx;
        }

        public IActionResult Index()
        {
            var trips = context.Trips
            .OrderBy(m => m.Destination)
            .ToList();

            return View();
        }

    }
}