using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Traversal.DataAccessLayer.Abstract;
using Traversal.DataAccessLayer.Concrate;
using Traversal.DataAccessLayer.Repository;
using Traversal.EntityLayer.Concrate;

namespace Traversal.DataAccessLayer.EntityFramework
{
    public class EfContactUsDal:GenericRepository<ContactUs>, IContactUsDal
    {
        public void ContactUsStatusChangeToFalse(int id)
        {
            var context = new Context();
            var values = context.ContactsUses.Where(x => x.ContactUsID == id).FirstOrDefault();
            values.Status = false;
            context.Update(values);
            context.SaveChanges();
        }

        public void ContactUsStatusChangeToTrue(int id)
        {
            var context = new Context();
            var values = context.ContactsUses.Where(x => x.ContactUsID == id).FirstOrDefault();
            values.Status = true;
            context.Update(values);
            context.SaveChanges();
        }

        public List<ContactUs> GetDeletedMessages()
        {
            var context = new Context();
            return context.ContactsUses.Where(x => x.Status == false).ToList();
        }

        public List<ContactUs> GetMessages()
        {
            var context = new Context();
            return context.ContactsUses.Where(x => x.Status == true).ToList();
        }

        public List<ContactUs> GetReceivedMessages()
        {
            var context = new Context();
            return context.ContactsUses.Where(x => x.MessageType == "Gelen Mesajlar" && x.Status==true).ToList();
        }

        public List<ContactUs> GetSentMessages()
        {
            var context = new Context();
            return context.ContactsUses.Where(x => x.MessageType == "Gönderilen Mesajlar" && x.Status == true).ToList();
        }
    }
}
