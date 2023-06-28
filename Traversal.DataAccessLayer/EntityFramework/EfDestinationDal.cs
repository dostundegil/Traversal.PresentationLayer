using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traversal.DataAccessLayer.Abstract;
using Traversal.DataAccessLayer.Concrate;
using Traversal.DataAccessLayer.Repository;
using Traversal.EntityLayer.Concrate;

namespace Traversal.DataAccessLayer.EntityFramework
{
    public class EfDestinationDal : GenericRepository<Destination>, IDestinationDal
    {
        public Destination GetDestinationsWithGuide(int id)
        {
            using (var c = new Context())
            {
                return c.Destinations.Where(x=>x.DestinationID==id).Include(x => x.Guide).FirstOrDefault();
            }
        }

        public List<Destination> GetLast4Destinations()
        {
            using (var c = new Context())
            {
                return c.Destinations.Take(4).OrderByDescending(x => x.DestinationID).ToList();
            }
        }
    }
}
