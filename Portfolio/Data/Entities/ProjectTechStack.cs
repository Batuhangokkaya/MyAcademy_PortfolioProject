namespace Portfolio.Data.Entities
{
    public class ProjectTechStack
    {
        public int ID { get; set; }
        public int ProjectID { get; set; }
        // Navigation Property
        public Project Project { get; set; }
        public int TechStackID { get; set; }
        // Navigation Property
        public TechStack TechStack { get; set; }
    }
}