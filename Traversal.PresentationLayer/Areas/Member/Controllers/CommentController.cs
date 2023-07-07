using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Traversal.PresentationLayer.Areas.Member.Controllers
{
    [Area("Member")]
    public class CommentController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
    }
}
