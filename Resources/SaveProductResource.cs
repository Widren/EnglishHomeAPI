using System.ComponentModel.DataAnnotations;

namespace BaseAPI.Resources
{
    public class SaveProductResource
    {
        [Required]
        [MaxLength(30)]
        public int Id { get; set; }
        public string Name { get; set; }
        public double Cost { get; set; }
        public int CategoryID { get; set; }
        public int SubCategoryID { get; set; }
        public string ImageURL { get; set; }
        public string Color { get; set; }
        public double rating { get; set; }
    }
}
