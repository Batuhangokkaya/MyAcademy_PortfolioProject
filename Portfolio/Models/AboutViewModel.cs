using Portfolio.Data.Entities;

namespace Portfolio.Models
{
    public class AboutViewModel
    {
        public List<About> About { get; set; }
        public List<TechStack> Frontends { get; set; }
        public List<TechStack> Backends { get; set; }
    }
}