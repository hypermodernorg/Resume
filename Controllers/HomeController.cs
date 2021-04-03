using Resume.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace Resume.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewData["Title"] = "Home";
            ViewBag.IsHome = true;
            ViewData["Description"] = "HTML Resume creation site.";
            ViewData["Keywords"] = "Resume, Conspectus, Abstract, Lander's Resume";
            return View();
        }
        public IActionResult About()
        {
            ViewData["Title"] = "About Lander";
            ViewData["Description"] = "About the creator of Lander's Resume";
            ViewData["Keywords"] = "Lander's Resume, Lander, Aspirations, Goals, Cats, Hobbies";
            return View();
        }

        public IActionResult Privacy()
        {
            ViewData["Title"] = "Privacy";
            ViewData["Description"] = "Privacy";
            ViewData["Keywords"] = "Privacy";
            return View();
        }
        public IActionResult ResumeNotFound()
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
