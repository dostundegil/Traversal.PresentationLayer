namespace Traversal.PresentationLayer.CQRS.Queries.DestinationQueries
{
    public class GetDestinationByIDQuery
    {
        public int Id { get; set; }

        public GetDestinationByIDQuery(int id)
        {
            Id = id;
        }
    }
}
