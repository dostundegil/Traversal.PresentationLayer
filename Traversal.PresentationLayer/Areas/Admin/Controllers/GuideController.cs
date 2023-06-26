using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System;
using Traversal.BusinessLayer.Abstract;
using Traversal.EntityLayer.Concrate;
using Traversal.PresentationLayer.Areas.Admin.Models;
using System.Threading.Tasks;
using Traversal.BusinessLayer.ValidationRules;
using FluentValidation.Results;
using FluentValidation;

namespace Traversal.PresentationLayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]/{id?}")]
    public class GuideController : Controller
    {
        private readonly IGuideService _guideService;

        public GuideController(IGuideService guideService)
        {
            _guideService = guideService;
        }

        public IActionResult Index()
        {
            var values = _guideService.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddGuide()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddGuide(GuideViewModel p)
        {

            Guide guide = new Guide();
            if (p.Image != null)
            {
                var resource = Directory.GetCurrentDirectory();
                var extension = Path.GetExtension(p.Image.FileName);
                var imagename = Guid.NewGuid() + extension;
                var saveLocation = resource + "/wwwroot/images/guideimages/" + imagename;
                var stream = new FileStream(saveLocation, FileMode.Create);
                await p.Image.CopyToAsync(stream);
                guide.Image = "/images/guideimages/" + imagename;
            }
            else
            {
                guide.Image = "/sneat-1.0.0/assets/img/avatars/man.png";
            }
            guide.Name = p.Name;
            guide.TwitterUrl = p.TwitterUrl;
            guide.InstagramUrl = p.InstagramUrl;
            guide.Description= p.Description;
            GuideValidator validationRules = new GuideValidator();
            ValidationResult result = validationRules.Validate(guide);
            if (result.IsValid)
            {
                _guideService.TAdd(guide);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View();
            }
        }

        [HttpGet]
        public IActionResult EditGuide(int id)
        {
           var value= _guideService.TGetById(id);
            GuideViewModel guide = new GuideViewModel();
            guide.Name = value.Name;
            guide.ImageUrl = value.Image;
            guide.TwitterUrl = value.TwitterUrl;
            guide.InstagramUrl = value.InstagramUrl;
            guide.Description = value.Description;
            TempData["id"] = id;

            return View(guide);
        }
        [HttpPost]
        public async Task<IActionResult> EditGuide(GuideViewModel p)
        {
            var id = TempData["id"];
            var guide = _guideService.TGetById(Convert.ToInt32(id));
            if (p.Image != null)
            {
                var resource = Directory.GetCurrentDirectory();
                var extension = Path.GetExtension(p.Image.FileName);
                var imagename = Guid.NewGuid() + extension;
                var saveLocation = resource + "/wwwroot/images/guideimages/" + imagename;
                var stream = new FileStream(saveLocation, FileMode.Create);
                await p.Image.CopyToAsync(stream);
                guide.Image = "/images/guideimages/" + imagename;
            }
            guide.Name = p.Name;
            guide.TwitterUrl = p.TwitterUrl;
            guide.InstagramUrl = p.InstagramUrl;
            guide.Description = p.Description;
            _guideService.TUpdate(guide);
            return RedirectToAction("Index");
        }
        public IActionResult ChangeToTrue(int id)
        {
            _guideService.TChangeStatusToTrue(id);
            return RedirectToAction("Index");
        }
        public IActionResult ChangeToFalse(int id)
        {
            _guideService.TChangeStatusToFalse(id);
            return RedirectToAction("Index");
        }
    }
}
