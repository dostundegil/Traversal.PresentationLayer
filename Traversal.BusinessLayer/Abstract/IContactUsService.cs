using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traversal.EntityLayer.Concrate;

namespace Traversal.BusinessLayer.Abstract
{
    public interface IContactUsService:IGenericService<ContactUs>
    {
        public List<ContactUs> TGetSentMessages();
        public List<ContactUs> TGetReceivedMessages();
        public List<ContactUs> TGetMessages();
        public List<ContactUs> TGetDeletedMessages();
        void TContactUsStatusChangeToFalse(int id);
        void TContactUsStatusChangeToTrue(int id);
    }
}
