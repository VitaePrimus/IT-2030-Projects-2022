using Microsoft.AspNetCore.Mvc;
using Project_2.Models;
using System.Diagnostics;

namespace Project_2.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Discount = "";
            ViewBag.Total = "";
            return View();
        }

        [HttpPost]
        public IActionResult Index(PriceQuotation fv)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Discount = fv.CalculateDiscount().ToString("c2");
                ViewBag.Total = fv.CalculateTotal().ToString("c2");
            }
            else
            {
                ViewBag.FutureValue = "";
            }

            return View();
        }
    }
}