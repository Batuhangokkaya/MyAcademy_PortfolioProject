namespace Portfolio.Data.Entities
{
    public class TechStack
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<ProjectTechStack> ProjectTechStacks { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }
    }
}