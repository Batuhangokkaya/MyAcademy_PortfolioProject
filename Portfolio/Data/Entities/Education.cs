namespace Portfolio.Data.Entities
{
    public class Education
    {
        public int ID { get; set; }
        public string? SchoolName { get; set; }
        public string Department { get; set; }
        public double GPA { get; set; }
        public int StartDate { get; set; }
        public string? GraduationYear { get; set; }
        public string Description { get; set; }
    }
}