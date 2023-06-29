using Microsoft.AspNetCore.Mvc;

namespace Traversal.PresentationLayer.Controllers
{
    public class InformationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
