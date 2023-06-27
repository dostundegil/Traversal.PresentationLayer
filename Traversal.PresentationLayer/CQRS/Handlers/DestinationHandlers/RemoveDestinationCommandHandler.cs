using Traversal.DataAccessLayer.Concrate;
using Traversal.PresentationLayer.CQRS.Commands.DestinationCommands;

namespace Traversal.PresentationLayer.CQRS.Handlers.DestinationHandlers
{
    public class RemoveDestinationCommandHandler
    {
        private readonly Context _context;

        public RemoveDestinationCommandHandler(Context context)
        {
            _context = context;
        }
        public void Handle(RemoveDestinationCommand command)
        {
            var values = _context.Destinations.Find(command.Id);
            _context.Remove(values);
            _context.SaveChanges();
        }
    }
}
