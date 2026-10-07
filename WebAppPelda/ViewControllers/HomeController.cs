using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebAppPelda.Models;

namespace WebAppPelda.Controllers
{
    public class HomeController : Controller
    {
        List<Customer> customers = new List<Customer>
            {
                 new Customer()
        {
            Id = 1,
            Name = "John Doe",
            Phone = "123-456-789",
            Score = 75
        },new Customer()
        {
            Id = 2,
            Name = "Bela",
            Phone = "978-456-231",
            Score = 85
        }
            };
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Sajat()
        {
            

            return View(customers);
            

        }
        public IActionResult Vasarlo(int id)
        {
            Customer customer =customers.FirstOrDefault(c => c.Id == id);
            return View(customer);            
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
