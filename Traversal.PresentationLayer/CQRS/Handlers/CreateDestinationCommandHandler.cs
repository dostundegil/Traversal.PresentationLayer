using Traversal.DataAccessLayer.Concrate;
using Traversal.EntityLayer.Concrate;
using Traversal.PresentationLayer.CQRS.Commands.DestinationCommands;

namespace Traversal.PresentationLayer.CQRS.Handlers
{
    public class CreateDestinationCommandHandler
    {
        private readonly Context _context;

        public CreateDestinationCommandHandler(Context context)
        {
            _context = context;
        }
        
        public void Handle(CreateDestinationCommand command)
        {
            _context.Destinations.Add(new Destination
            {
                City = command.City,
                DayNight = command.DayNight,
                Price = command.Price,
                Status = true,
                Capacity = command.Capacity,
            });
            _context.SaveChanges();
        }
    }
}
