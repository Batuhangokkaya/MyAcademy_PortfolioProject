using Portfolio.Data.Entities;

namespace Portfolio.Models
{
    public class DashboardViewModel
    {
        public List<Project> Projects { get; set; }
        public List<UserMessage> userMessages { get; set; }
        public List<Skill> Skills { get; set; }
    }
}