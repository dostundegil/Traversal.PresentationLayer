using DocumentFormat.OpenXml.Office2010.ExcelAc;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using Traversal.PresentationLayer.Models;

namespace Traversal.PresentationLayer.Areas.Admin.Controllers
{
    public class CityController : Controller
    {
        [Area("Admin")]
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CityList()
        {
            var jsonCity = JsonConvert.SerializeObject(cities);
            return Json(jsonCity);
        }

        public static List<CityClass> cities = new List<CityClass>
        {
            new CityClass
            {
                CityID=1,
                CityName="Üsküp",
                CityCountry="Makedonya"
            },
            new CityClass
            {
                CityID=2,
                CityName="Roma",
                CityCountry="İtalya"
            },
            new CityClass
            {
                CityID=3,
                CityName="Londra",
                CityCountry="İngiltere"
            }
        };
    }
}
