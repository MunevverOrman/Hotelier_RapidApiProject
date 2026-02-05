using HotelProject.EntityLayer.Concrete;
using System.Collections.Generic;

namespace HotelProject.BusinessLayer.Abstract
{
    public interface IBookingService:IGenericService<Booking>
    {
        void TBookingStatusChangeApproved(Booking booking);

        void TBookingStatusChangeApproved2(int id);

        int TGetBookingCount();

        List<Booking> TLast6Bookings();

        void TBookingStatusChangeApproved3(int id);

        void TBookingStatusChangeCancel(int id);

        void TBookingStatusChangeWait(int id);
    }
}
