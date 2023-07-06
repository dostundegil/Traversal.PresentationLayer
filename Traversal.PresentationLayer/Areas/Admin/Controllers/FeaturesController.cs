using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Traversal.BusinessLayer.Abstract;
using Traversal.EntityLayer.Concrate;

namespace Traversal.PresentationLayer.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    [Route("Admin/[controller]/[action]/{id?}")]
    public class FeaturesController : Controller
    {
        private readonly IFeatureService _featureService;

        public FeaturesController(IFeatureService featureService)
        {
            _featureService = featureService;
        }

        public IActionResult Index()
        {
            var values = _featureService.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult UpdateFeature(int id)
        {
            var values = _featureService.TGetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateFeature(Feature feature)
        {
            _featureService.TUpdate(feature);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult AddFeature()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddFeature(Feature feature)
        {
            _featureService.TAdd(feature);
            return RedirectToAction("Index");
        }
    }
}
