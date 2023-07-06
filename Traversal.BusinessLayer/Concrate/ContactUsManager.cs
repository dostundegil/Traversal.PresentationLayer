using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traversal.BusinessLayer.Abstract;
using Traversal.DataAccessLayer.Abstract;
using Traversal.EntityLayer.Concrate;

namespace Traversal.BusinessLayer.Concrate
{
    public class ContactUsManager : IContactUsService
    {
        private readonly IContactUsDal _contactUsDal;

        public ContactUsManager(IContactUsDal contactUsDal)
        {
            _contactUsDal = contactUsDal;
        }

        public void TAdd(ContactUs t)
        {
            _contactUsDal.Insert(t);
        }

        public void TContactUsStatusChangeToFalse(int id)
        {
            _contactUsDal.ContactUsStatusChangeToFalse(id);
        }

        public void TContactUsStatusChangeToTrue(int id)
        {
            _contactUsDal.ContactUsStatusChangeToTrue(id);
        }

        public void TDelete(ContactUs t)
        {
            _contactUsDal.Delete(t);
        }

        public ContactUs TGetById(int id)
        {
            return _contactUsDal.GetByID(id);
        }

        public List<ContactUs> TGetDeletedMessages()
        {
            return _contactUsDal.GetDeletedMessages();
        }

        public List<ContactUs> TGetList()
        {
            return _contactUsDal.GetList();
        }

        public List<ContactUs> TGetMessages()
        {
            return _contactUsDal.GetMessages(); 
        }

        public List<ContactUs> TGetReceivedMessages()
        {
            return _contactUsDal.GetReceivedMessages();
        }

        public List<ContactUs> TGetSentMessages()
        {
            return _contactUsDal.GetSentMessages();
        }

        public void TUpdate(ContactUs t)
        {
            _contactUsDal.Update(t);
        }
    }
}
