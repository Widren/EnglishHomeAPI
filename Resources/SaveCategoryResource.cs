using System.ComponentModel.DataAnnotations;

namespace BaseAPI.Resources
{
    public class SaveCategoryResource
    {
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        public string ParentID { get; set; }
        public string Icon { get; set; }
    }
}
