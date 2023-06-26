using Microsoft.AspNetCore.Mvc;
using Traversal.DataAccessLayer.Concrate;

namespace Traversal.PresentationLayer.ViewComponents.AdminDashboard
{
    public class _TotalRevenue:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
