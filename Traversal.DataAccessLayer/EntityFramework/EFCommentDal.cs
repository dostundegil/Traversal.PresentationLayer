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
    public class EFCommentDal : GenericRepository<Comment>, ICommentDal
    {
        public List<Comment> GetCommentsWithDestination()
        {
            using (var c = new Context())
            {
                return c.Comments.Include(x => x.Destination).ToList();
            }
        }

        public List<Comment> GetCommentsWithDestinationandUser(int id)
        {
            using (var c = new Context())
            {
                return c.Comments.Where(x=>x.DestinationID==id).Include(x => x.AppUser).ToList();
            }
        }
    }
}
