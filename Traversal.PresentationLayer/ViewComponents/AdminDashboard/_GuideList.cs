using Microsoft.AspNetCore.Mvc;

namespace Traversal.PresentationLayer.ViewComponents.AdminDashboard
{
    public class _GuideList:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
