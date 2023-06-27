using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;
using Traversal.PresentationLayer.CQRS.Queries.GuideQueries;
using Traversal.PresentationLayer.CQRS.Results.GuideResults;
using MediatR;
using Traversal.DataAccessLayer.Concrate;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Traversal.PresentationLayer.CQRS.Handlers.GuideHandlers
{
    public class GetAllGuideQueryHandler : IRequestHandler<GetAllGuideQuery, List<GetAllGuideQueryResult>>
    {
        private readonly Context _context;
        public GetAllGuideQueryHandler(Context context)
        {
            _context = context;
        }
        public async Task<List<GetAllGuideQueryResult>> Handle(GetAllGuideQuery request, CancellationToken cancellationToken)
        {
            return await _context.Guides.Select(x => new GetAllGuideQueryResult
            {
                GuideID = x.GuideID,
                Description = x.Description,
                Image = x.Image,
                Name = x.Name
            }).AsNoTracking().ToListAsync();
        }
    }
}
