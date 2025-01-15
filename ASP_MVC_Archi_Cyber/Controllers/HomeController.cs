using ASP_MVC_Archi_Cyber.Models;
using Elfie.Serialization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Diagnostics;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ASP_MVC_Archi_Cyber.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly string connectionString = "Data Source = (localdb)\\BStormLocalDB; Initial Catalog = db_asp_archi; Integrated Security = True; Connect Timeout = 60; Encrypt = True; Trust Server Certificate = False; Application Intent = ReadWrite; Multi Subnet Failover = False";

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            using(SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                ViewBag.Connection = conn.State;

                using(SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT GETDATE() as DATE";
                    cmd.CommandType = CommandType.Text;

                    DateTime dateServer = (DateTime)cmd.ExecuteScalar();
                    conn.Close();

                    ViewData["Date"] = dateServer;

                }
            }

            // ExecuteScalar - Permet de récupérer une seule cellule (equivalent de A-1
            // ExecuteNonQuery - Permet de récupérer le nombre de lignes affectées
            // Reader - Permet de récupérer des lignes entières

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
