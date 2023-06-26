using System.Collections.Generic;
using System.Linq;
using Traversal.DataAccessLayer.Concrate;
using Traversal.PresentationLayer.Models;

namespace Traversal.PresentationLayer.Areas.Admin.Models
{
    public class DestinationListViewModel
    {
        public List<DestinationModel> DestinationList()
        {
            List<DestinationModel> destinationModels = new List<DestinationModel>();
            using (var c = new Context())
            {
                destinationModels = c.Destinations.Select(x => new DestinationModel
                {
                    City = x.City,
                    DayNight = x.DayNight,
                    Price = x.Price,
                    Capacity = x.Capacity
                }).ToList();
            }
            return destinationModels;
        }
    }
}
