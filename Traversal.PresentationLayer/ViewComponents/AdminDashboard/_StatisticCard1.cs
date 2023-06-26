using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Traversal.DataAccessLayer.Concrate;

namespace Traversal.PresentationLayer.ViewComponents.AdminDashboard
{
    public class _StatisticCard1:ViewComponent
    {
        Context context = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.totalRoute = context.Destinations.Count();
            ViewBag.totalUser = context.Users.Count();
            return View();
        }
    }
}
