using ASP_MVC_Archi_Cyber.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP_MVC_Archi_Cyber.Controllers
{
    public class ProductController : Controller
    {
        List<Fruit> fruits = new List<Fruit>
            {
                new Fruit { Id = 1, Name = "Pomme", Price = 1.50m, Origin = "France", IsBio = true },
                new Fruit { Id = 2, Name = "Banane", Price = 0.80m, Origin = "Équateur", IsBio = false },
                new Fruit { Id = 3, Name = "Orange", Price = 1.20m, Origin = "Espagne", IsBio = true },
                new Fruit { Id = 4, Name = "Mangue", Price = 2.50m, Origin = "Inde", IsBio = false },
                new Fruit { Id = 5, Name = "Fraise", Price = 3.00m, Origin = "Belgique", IsBio = true },
                new Fruit { Id = 6, Name = "Raisin", Price = 2.00m, Origin = "Italie", IsBio = false },
                new Fruit { Id = 7, Name = "Kiwi", Price = 1.70m, Origin = "Nouvelle-Zélande", IsBio = true },
                new Fruit { Id = 8, Name = "Ananas", Price = 3.50m, Origin = "Costa Rica", IsBio = false },
                new Fruit { Id = 9, Name = "Cerise", Price = 4.00m, Origin = "France", IsBio = true },
                new Fruit { Id = 10, Name = "Poire", Price = 1.80m, Origin = "Belgique", IsBio = false }

            };
            

    public IActionResult Index()
        {
            //Dictionary<string,decimal> fruits = new Dictionary<string, decimal> 
            //{
            //    { "Pomme", 1.50m },
            //    { "Banane", 0.80m },
            //    { "Orange", 1.20m },
            //    { "Mangue", 2.50m },
            //    { "Fraise", 3.00m },
            //    { "Raisin", 2.00m },
            //    { "Kiwi", 1.70m },
            //    { "Ananas", 3.50m },
            //    { "Cerise", 4.00m },
            //    { "Poire", 1.80m }
            //};

            return View(fruits);
        }

        public IActionResult DetailFruit(int id)
        {
            ViewData["Argent"] = 5.5m;
            ViewBag.Reduction = 5.5m;
            return View(fruits.FirstOrDefault(f => f.Id == id));
        }

        public IActionResult Redirection()
        {
            TempData["Argent"] = "Je suis riche";
            return RedirectToAction("Index"); 
        }


    }
}
