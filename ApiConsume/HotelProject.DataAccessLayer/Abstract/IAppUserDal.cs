using HotelProject.EntityLayer.Concrete;
using System.Collections.Generic;

namespace HotelProject.DataAccessLayer.Abstract
{
    public interface IAppUserDal:IGenericDal<AppUser>
    {
        List<AppUser> UserListWithWorklocation();

        List<AppUser> UsersListWithWorklocations();

        int AppUserCount();
    }
}
