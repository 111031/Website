using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Website.Models;
using Website.Database;

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
            // lijst met producten ophalen
            var products = GetAllProducts();

            // de lijst met producten in de html stoppen
            return View(products);
        }

        public List<Product> GetAllProducts()
        {
            // alle producten ophalen uit de database
            var rows = DatabaseConnector.GetRows("select * from product");

            // lijst maken om alle producten in te stoppen
            List<Product> products = new List<Product>();

            foreach (var row in rows)
            {
                // Voor elke rij maken we nu een product
                Product p = new Product();
                p.naam = (string)row["naam"];
                p.prijs = (decimal)row["prijs"];
                p.omschrijving = (string)row["omschrijving"];
                p.id = Convert.ToInt32(row["id"]);

                // en dat product voegen we toe aan de lijst met producten
                products.Add(p);
            }

            return products;
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