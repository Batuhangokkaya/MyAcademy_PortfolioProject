using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace Portfolio.Models
{
    public class ProjectUpdateViewModel
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Lütfen Görsel URL'i Giriniz!")]

        public string ImageURL { get; set; }

        [Required(ErrorMessage = "Lütfen Proje Adı Giriniz!")]

        [MinLength(3, ErrorMessage = "Proje Adı en az 3 karakter olmalıdır!")]

        public string Name { get; set; }

        [Required(ErrorMessage = "Lütfen Proje Açıklaması Giriniz!")]

        [MaxLength(400, ErrorMessage = "Proje açıklaması en fazla 400 karakter olmalıdır!")]

        public string Description { get; set; }

        [Required(ErrorMessage = "Lütfen GitHub Linki Giriniz!")]

        public string GithubURL { get; set; }

        public List<int> SelectedTechStackIds { get; set; } = new();

        public List<SelectListItem> TechStacks { get; set; } = new();
    }
}