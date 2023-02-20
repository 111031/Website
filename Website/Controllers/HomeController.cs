using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Website.Models;

namespace Website.Controllers
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
            return View();
        }
        [Route("privacy")]
        public IActionResult Privacy()
        {
            return View();
        }
        [Route("kaart")]
        public IActionResult Kaart()
        {
            return View();
        }
        [Route("activiteiten")]
        public IActionResult Activiteiten()
        {
            return View();
        }
        [Route("openingstijden")]
        public IActionResult Openingstijden()
        {
            return View();
        }
        [Route("contact")]
        public IActionResult Contact()
        {
            return View();
        }
        [Route("winkelwagen")]
        public IActionResult Winkelwagen()
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