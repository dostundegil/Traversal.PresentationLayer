using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traversal.EntityLayer.Concrate;

namespace Traversal.DataAccessLayer.Abstract
{
    public interface IDestinationDal:IGenericDal<Destination>
    {
        public Destination GetDestinationsWithGuide(int id);

        public List<Destination> GetLast4Destinations();
    }
}
