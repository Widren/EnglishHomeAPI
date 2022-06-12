namespace EnglishHomeAPI.Resources
{
    public class CategoryResource
    {
        public int Id { get; set; }
        public int ParentID { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
    }
}
