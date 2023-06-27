using Traversal.DataAccessLayer.Concrate;
using Traversal.PresentationLayer.CQRS.Queries.DestinationQueries;
using Traversal.PresentationLayer.CQRS.Results.DestinationResults;

namespace Traversal.PresentationLayer.CQRS.Handlers.DestinationHandlers
{
    public class GetDestinationByIdQueryHandler
    {
        private readonly Context _context;

        public GetDestinationByIdQueryHandler(Context context)
        {
            _context = context;
        }

        public GetDestinationByIDQueryResult Handle(GetDestinationByIDQuery query)
        {
            var values = _context.Destinations.Find(query.Id);
            return new GetDestinationByIDQueryResult
            {
                City = values.City,
                DayNight = values.DayNight,
                DestinationId = values.DestinationID,
                Price=values.Price
            };
        }
    }
}
