using Microsoft.AspNetCore.Mvc;
using Portfolio.Data.Context;

namespace Portfolio.ViewComponents.Default_Index
{
    public class _DefaultHeroViewComponent : ViewComponent
    {
        private readonly AppDbContext _context;

        public _DefaultHeroViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var value = _context.Banners.FirstOrDefault();
            return View(value);
        }
    }
}