using System.ComponentModel.DataAnnotations;

namespace ASP_MVC_Archi_Cyber.Models
{
    public class Fruit
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        [Range(0, 100, ErrorMessage = "Le prix doit être entre 0 et 100 !")]
        public decimal Price { get; set; }
        public string Origin { get; set; }
        public bool IsBio { get; set; }
       
    }
}
