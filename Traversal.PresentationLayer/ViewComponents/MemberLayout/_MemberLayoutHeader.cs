using Microsoft.AspNetCore.Mvc;

namespace Traversal.PresentationLayer.ViewComponents.MemberLayout
{
    public class _MemberLayoutHeader:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
