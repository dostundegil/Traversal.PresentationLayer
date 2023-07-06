using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traversal.EntityLayer.Concrate;

namespace Traversal.DataAccessLayer.Abstract
{
    public interface IContactUsDal:IGenericDal<ContactUs>
    {
        public List<ContactUs> GetSentMessages();
        public List<ContactUs> GetReceivedMessages();

        public List<ContactUs> GetMessages();
        public List<ContactUs> GetDeletedMessages();

        void ContactUsStatusChangeToFalse(int id);
        void ContactUsStatusChangeToTrue(int id);
    }
}
