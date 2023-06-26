using Microsoft.AspNetCore.Mvc;

namespace Traversal.PresentationLayer.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
