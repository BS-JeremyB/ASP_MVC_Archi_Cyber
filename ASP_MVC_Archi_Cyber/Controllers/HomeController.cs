using ASP_MVC_Archi_Cyber.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ASP_MVC_Archi_Cyber.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult AboutUs() 
        {
            List<string> team = new List<string> { "John Doe", "Jane Doe", "Steve Lorent", "Donald Trump", "Joe Biden" };
            // retours de db

            return View(team);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
