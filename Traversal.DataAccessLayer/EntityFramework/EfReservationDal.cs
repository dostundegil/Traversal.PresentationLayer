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
    public class EfReservationDal : GenericRepository<Reservation>, IReservationDal
    {
        public void ApproveReservation(int id)
        {
            var context = new Context();
            var values = context.Reservations.Where(x => x.ReservationID == id).FirstOrDefault();
            values.Status = "Onaylandı";
            context.Update(values);
            context.SaveChanges();
        }

        public List<Reservation> GetListWithReservationByAccepted(int id)
        {
            using (var context = new Context())
            {
                return context.Reservations.Include(x => x.Destination).Where(x => x.Status == "Onaylandı" && x.AppUserId == id).ToList();
            };
        }

        public List<Reservation> GetListWithReservationByPrevious(int id)
        {
            using (var context = new Context())
            {
                return context.Reservations.Include(x => x.Destination).Where(x => x.Status == "Geçmiş Rezervasyon" && x.AppUserId == id).ToList();
            };
        }

        public List<Reservation> GetListWithReservationByWaitApproval(int id)
        {
           
            using (var context = new Context())
            {
                return context.Reservations.Include(x => x.Destination).Where(x=>x.Status=="Onay Bekliyor" && x.AppUserId==id).ToList();
            };
        }

        public List<Reservation> GetOldReservations()
        {
            using (var context = new Context())
            {
                return context.Reservations.Include(x => x.Destination).Where(x => x.Status == "Geçmiş Rezervasyon").Include(x => x.AppUser).ToList();
            };
        }

        public List<Reservation> GetPreviousReservations()
        {
            using (var context = new Context())
            {
                return context.Reservations.Include(x => x.Destination).Where(x => x.Status == "Onaylandı").Include(x => x.AppUser).ToList();
            };
        }

        public List<Reservation> GetWaitingApprovalReservations()
        {
            using (var context = new Context())
            {
                return context.Reservations.Include(x => x.Destination).Where(x => x.Status == "Onay Bekliyor").Include(x => x.AppUser).ToList();
            };
        }
    }
}
