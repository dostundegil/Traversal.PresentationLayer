using Microsoft.AspNetCore.Mvc;

namespace Traversal.PresentationLayer.ViewComponents.MemberDashboard
{
    public class _PlatformSettingsPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
