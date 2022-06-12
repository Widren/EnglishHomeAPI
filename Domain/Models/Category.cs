using System.Collections.Generic;

namespace EnglishHomeAPI.Domain.Models
{
    public class Category
    {
        public int Id { get; set; }
        public int ParentID { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
    }
}
