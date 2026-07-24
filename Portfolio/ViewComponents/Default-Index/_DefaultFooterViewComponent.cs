using Microsoft.AspNetCore.Mvc;

namespace Portfolio.ViewComponents.Default_Index
{
    public class _DefaultFooterViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}