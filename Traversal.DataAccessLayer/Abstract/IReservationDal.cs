﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traversal.EntityLayer.Concrate;

namespace Traversal.DataAccessLayer.Abstract
{
    public interface IReservationDal:IGenericDal<Reservation>
    {
        List<Reservation> GetListWithReservationByWaitApproval(int id);
        List<Reservation> GetListWithReservationByAccepted(int id);
        List<Reservation> GetListWithReservationByPrevious(int id);
        List<Reservation> GetPreviousReservations();
        List<Reservation> GetWaitingApprovalReservations();
        List<Reservation> GetOldReservations();
        void ApproveReservation(int id);
    }
}
