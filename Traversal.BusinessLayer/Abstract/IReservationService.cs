﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traversal.EntityLayer.Concrate;

namespace Traversal.BusinessLayer.Abstract
{
    public interface IReservationService:IGenericService<Reservation>
    {
        List<Reservation> GetListWithReservationByWaitApproval(int id);
        List<Reservation> GetListWithReservationByAccepted(int id);
        List<Reservation> GetListWithReservationByPrevious(int id);
        List<Reservation> TGetPreviousReservations();
        List<Reservation> TGetWaitingApprovalReservations();
        List<Reservation> TGetOldReservations();
        void TApproveReservation(int id);
    }
}
