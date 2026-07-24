using Microsoft.AspNetCore.Mvc;

namespace Portfolio.ViewComponents.Default_Index
{
    public class _DefaultTestimonialCommentViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}