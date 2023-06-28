using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traversal.EntityLayer.Concrate;

namespace Traversal.BusinessLayer.Abstract
{
    public interface IDestinationService : IGenericService<Destination>
    {
        public Destination TGetDestinationsWithGuide(int id);
        public List<Destination> TGetLast4Destinations();
    }
}
