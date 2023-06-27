using MediatR;
using System.Threading.Tasks;
using System.Threading;
using Traversal.DataAccessLayer.Concrate;
using Traversal.PresentationLayer.CQRS.Commands.GuideCommands;
using Traversal.EntityLayer.Concrate;

namespace Traversal.PresentationLayer.CQRS.Handlers.GuideHandlers
{
    public class CreateGuideCommanHandler
    {
        private readonly Context _context;
        public CreateGuideCommanHandler(Context context)
        {
            _context = context;
        }
        public async Task<Unit> Handle(CreateGuideCommand request, CancellationToken cancellationToken)
        {
            _context.Guides.Add(new Guide
            {
                Name = request.Name,
                Description = request.Description,
                Status = true
            });
            await _context.SaveChangesAsync();
            return Unit.Value;
        }

    }
}
