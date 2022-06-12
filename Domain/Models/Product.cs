using System.Collections.Generic;

namespace EnglishHomeAPI.Domain.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Cost { get; set; }
        public int CategoryID { get; set; }
        public string ImageURL { get; set; }
        public string Color { get; set; }
        public double rating { get; set; }
    }
}
