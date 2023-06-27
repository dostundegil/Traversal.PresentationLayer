using MediatR;
using System.Collections.Generic;
using Traversal.PresentationLayer.CQRS.Results.GuideResults;

namespace Traversal.PresentationLayer.CQRS.Queries.GuideQueries
{
    public class GetAllGuideQuery : IRequest<List<GetAllGuideQueryResult>>
    {
    }
}
