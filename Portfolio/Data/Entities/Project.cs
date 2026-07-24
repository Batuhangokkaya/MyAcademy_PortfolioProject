using System.ComponentModel.DataAnnotations;

namespace Portfolio.Data.Entities
{
    public class Project
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Lütfen Görsel URL'i Giriniz!")]
        public string ImageURL { get; set; }
        [Required(ErrorMessage = "Lütfen Proje Adı Giriniz!")]
        [MinLength(3, ErrorMessage = "Proje Adı en az 3 karakter olmalıdır!")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Lütfen Proje Açıklaması Giriniz!")]
        [MaxLength(400, ErrorMessage = "Proje Adı en fazla 100 karakter olmalıdır!")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Lütfen GitHub Linki Giriniz!")]
        public string GithubURL { get; set; }
        public List<ProjectTechStack>? ProjectTechStacks { get; set; }
    }
}