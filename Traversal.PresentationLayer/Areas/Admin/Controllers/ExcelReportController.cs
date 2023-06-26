using Microsoft.AspNetCore.Mvc;
using System;
using Traversal.BusinessLayer.Abstract;
using Traversal.PresentationLayer.Areas.Admin.Models;

namespace Traversal.PresentationLayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]/{id?}")]
    public class ExcelReportController : Controller
    {
        private readonly IExcelService _excelService;

        public ExcelReportController(IExcelService excelService)
        {
            _excelService = excelService;
        }

        public IActionResult DestinationReport()
        {
            DestinationListViewModel list = new DestinationListViewModel();

            var name = Guid.NewGuid();

            return File(_excelService.ExcelList(list.DestinationList()), "application/vnd.openxmlformats-officedocuments.spreadsheetml.sheet", name + ".xlsx");

        }
    }
}
