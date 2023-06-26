using Microsoft.AspNetCore.Mvc;

namespace Traversal.PresentationLayer.ViewComponents.Default
{
    public class _SliderPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
