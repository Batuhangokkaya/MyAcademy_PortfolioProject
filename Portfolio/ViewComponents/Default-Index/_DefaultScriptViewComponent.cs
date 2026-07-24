using Microsoft.AspNetCore.Mvc;

namespace Portfolio.ViewComponents.Default_Index
{
    public class _DefaultScriptViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}