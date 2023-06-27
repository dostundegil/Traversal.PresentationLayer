
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using Traversal.DataAccessLayer.Concrate;
using Traversal.PresentationLayer.CQRS.Queries.DestinationQueries;
using Traversal.PresentationLayer.CQRS.Results.DestinationResults;

namespace Traversal.PresentationLayer.CQRS.Handlers.DestinationHandlers
{
    public class GetAllDestinationQueryHandler
    {
        private readonly Context _context;

        public GetAllDestinationQueryHandler(Context context)
        {
            _context = context;
        }

        public List<GetAllDestinationQueryResult> Handle()
        {
            var values = _context.Destinations.Select(x => new GetAllDestinationQueryResult
            {
                capacity = x.Capacity,
                id = x.DestinationID,
                city = x.City,
                dayNight = x.DayNight,
                price = x.Price
            }).AsNoTracking().ToList();
            return values;
        }
    }
}
