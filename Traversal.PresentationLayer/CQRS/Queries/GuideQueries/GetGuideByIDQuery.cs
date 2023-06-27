using MediatR;
using Traversal.PresentationLayer.CQRS.Results.GuideResults;

namespace Traversal.PresentationLayer.CQRS.Queries.GuideQueries
{
    public class GetGuideByIDQuery : IRequest<GetGuideByIDQueryResult>
    {
        public GetGuideByIDQuery(int ıd)
        {
            Id = ıd;
        }

        public int Id { get; set; }
    }
}
