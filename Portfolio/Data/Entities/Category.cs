namespace Portfolio.Data.Entities
{
    public class Category
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<TechStack> TechStacks { get; set; }
    }
}