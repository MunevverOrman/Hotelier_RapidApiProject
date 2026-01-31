using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.Repositories;
using HotelProject.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace HotelProject.DataAccessLayer.EntityFramework
{
    public class EfAppUserDal : GenericRepository<AppUser>, IAppUserDal
    {
        public EfAppUserDal(Context context) : base(context)
        {
        }

        public List<AppUser> UserListWithWorklocation()
        {
            var context = new Context();
            return context.Users.Include(x=>x.WorkLocation).ToList();
        }

        public List<AppUser> UsersListWithWorklocations()
        {
            var context = new Context();
            var values= context.Users.Include(x => x.WorkLocation).ToList();
            return values;
        }
    }
}
