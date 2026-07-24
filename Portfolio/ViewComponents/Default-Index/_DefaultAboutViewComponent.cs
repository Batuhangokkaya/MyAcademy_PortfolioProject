using Microsoft.AspNetCore.Mvc;
using Portfolio.Data.Context;
using Portfolio.Models;

namespace Portfolio.ViewComponents.Default_Index
{
    public class _DefaultAboutViewComponent : ViewComponent
    {
        private readonly AppDbContext _context;

        public _DefaultAboutViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var aboutViewModel = new AboutViewModel
            {
                About = _context.Abouts.ToList(),

                Frontends = _context.TechStacks
                .Where(x => x.CategoryID == 1)
                .ToList(),

                Backends = _context.TechStacks
                .Where(x => x.CategoryID == 2)
                .ToList()
            };

            return View(aboutViewModel);
        }
    }
}