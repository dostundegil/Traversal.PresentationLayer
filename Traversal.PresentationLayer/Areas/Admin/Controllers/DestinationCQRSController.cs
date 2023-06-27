using Microsoft.AspNetCore.Mvc;
using Traversal.PresentationLayer.CQRS.Commands.DestinationCommands;
using Traversal.PresentationLayer.CQRS.Handlers;
using Traversal.PresentationLayer.CQRS.Handlers.DestinationHandlers;
using Traversal.PresentationLayer.CQRS.Queries.DestinationQueries;

namespace Traversal.PresentationLayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]/{id?}")]
    public class DestinationCQRSController : Controller
    {
        private readonly GetAllDestinationQueryHandler _handler;
        private readonly GetDestinationByIdQueryHandler _getDestinationByIDQueryHandler;
        private readonly CreateDestinationCommandHandler _createDestinationCommandHandler;
        private readonly RemoveDestinationCommandHandler _removeDestinationCommandHandler;
        private readonly UpdateDestinationCommandHandler _updateDestinationCommandHandler;
        public DestinationCQRSController(GetAllDestinationQueryHandler handler, GetDestinationByIdQueryHandler getDestinationByIDQueryHandler, CreateDestinationCommandHandler createDestinationCommandHandler, RemoveDestinationCommandHandler removeDestinationCommandHandler, UpdateDestinationCommandHandler updateDestinationCommandHandler)
        {
            _handler = handler;
            _getDestinationByIDQueryHandler = getDestinationByIDQueryHandler;
            _createDestinationCommandHandler = createDestinationCommandHandler;
            _removeDestinationCommandHandler = removeDestinationCommandHandler;
            _updateDestinationCommandHandler = updateDestinationCommandHandler;
        }

        public IActionResult Index()
        {
            var values = _handler.Handle();
            return View(values);
        }
        [HttpGet]
        public IActionResult GetDestination(int id)
        {
            var values = _getDestinationByIDQueryHandler.Handle(new GetDestinationByIDQuery(id));
            return View(values);
        }

        [HttpPost]
        public IActionResult GetDestination(UpdateDestinationCommand command)
        {
            _updateDestinationCommandHandler.Handle(command);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult AddDestination()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddDestination(CreateDestinationCommand command)
        {
            _createDestinationCommandHandler.Handle(command);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteDestination(int id)
        {
            _removeDestinationCommandHandler.Handle(new RemoveDestinationCommand(id));
            return RedirectToAction("Index");
        }
    }
}
