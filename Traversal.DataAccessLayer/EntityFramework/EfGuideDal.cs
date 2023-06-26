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
    public class EfGuideDal : GenericRepository<Guide>, IGuideDal
    {
        public void ChangeStatusToFalse(int id)
        {
            Context context = new Context();
            var value = context.Guides.Find(id);
            value.Status = false;
            context.SaveChanges();

        }

        public void ChangeStatusToTrue(int id)
        {
            Context context = new Context();
            var value = context.Guides.Find(id);
            value.Status = true;
            context.SaveChanges();
        }
    }
}
