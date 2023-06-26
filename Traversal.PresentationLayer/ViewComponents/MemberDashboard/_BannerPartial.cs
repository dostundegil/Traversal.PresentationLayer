using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Traversal.EntityLayer.Concrate;

namespace Traversal.PresentationLayer.ViewComponents.MemberDashboard
{
    public class _BannerPartial:ViewComponent
    {
        private readonly UserManager<AppUser> _userManager;

        public _BannerPartial(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.name = values.Name;
            ViewBag.userimage = values.ImageUrl;
            return View();
        }
    }
}
