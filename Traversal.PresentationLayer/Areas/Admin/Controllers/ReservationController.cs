using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Traversal.BusinessLayer.Abstract;

namespace Traversal.PresentationLayer.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    [Route("Admin/[controller]/[action]/{id?}")]
    public class ReservationController : Controller
    {
        private readonly IDestinationService _destinationService;

        private readonly IReservationService _reservationService;

        public ReservationController(IDestinationService destinationService, IReservationService reservationService)
        {
            _destinationService = destinationService;
            _reservationService = reservationService;
        }

        public IActionResult Index()
        {
            var values = _reservationService.TGetWaitingApprovalReservations();
            return View(values);
        }

        public IActionResult ApproveReservation(int id)
        {
            _reservationService.TApproveReservation(id);
            return RedirectToAction("Index");
        }

        public IActionResult ApprovedReservations()
        {
            var values = _reservationService.TGetPreviousReservations();
            return View(values);
        }
        public IActionResult OldReservations()
        {
            var values = _reservationService.TGetOldReservations();
            return View(values);
        }
    }
}
