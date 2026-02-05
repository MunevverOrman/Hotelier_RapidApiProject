using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.Repositories;
using HotelProject.EntityLayer.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace HotelProject.DataAccessLayer.EntityFramework
{
    public class EfBookingDal : GenericRepository<Booking>, IBookingDal
    {
        public EfBookingDal(Context context) : base(context)
        {
        }

        public void BookingStatusChangeApproved(Booking booking)
        {
            var context = new Context();
            var values=context.Bookings.Where(x => x.BookingId == booking.BookingId).FirstOrDefault();
            values.Status = "Onaylandı";
            context.SaveChanges();
            
        }

        public void BookingStatusChangeApproved2(int id)
        {
            var context = new Context();
            var values= context.Bookings.Find(id);
            values.Status = "Onaylandı";
            context.SaveChanges();
        }

        public void BookingStatusChangeApproved3(int id)
        {
            var context = new Context();
            var values = context.Bookings.Find(id);
            values.Status = "Onaylandı";
            context.SaveChanges();
        }

        public void BookingStatusChangeCancel(int id)
        {
            var context = new Context();
            var values = context.Bookings.Find(id);
            values.Status = "İptal Edildi";
            context.SaveChanges();
        }

        public void BookingStatusChangeWait(int id)
        {
            var context = new Context();
            var values = context.Bookings.Find(id);
            values.Status = "Müşteri aranacak ";
            context.SaveChanges();
        }

        public int GetBookingCount()
        {
            var context = new Context();
            var value=context.Bookings.Count();
            return value;
        }

        public List<Booking> Last6Bookings()
        {
            var context = new Context();
            var values=context.Bookings.OrderByDescending(x=>x.BookingId).Take(6).ToList();
            return values;
        }
    }
}
