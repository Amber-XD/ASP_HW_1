using System.Diagnostics;
using ASP_HW_1.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP_HW_1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Hobby()
        {
            return View();
        }
        public IActionResult Favorite()
        {
            return View();
        }
        public IActionResult Plans()
        {
            return View();
        }   
        public IActionResult AboutMe()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
