namespace ASP_MVC_Archi_Cyber.Models
{
    public class Vegetable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Origin { get; set; }
        public bool IsBio { get; set; }
        public bool IsRaw { get; set; } 
    }
}
