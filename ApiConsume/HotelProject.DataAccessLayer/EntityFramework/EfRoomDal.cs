using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.Repositories;
using HotelProject.EntityLayer.Concrete;
using System.Linq;

namespace HotelProject.DataAccessLayer.EntityFramework
{
    public class EfRoomDal:GenericRepository<Room>, IRoomDal
    {
        public EfRoomDal(Context context):base(context)
        {
            
        }

        public int RoomCount()
        {
            var context = new Context();
            var value= context.Rooms.Count();
            return value;
        }
    }
}
