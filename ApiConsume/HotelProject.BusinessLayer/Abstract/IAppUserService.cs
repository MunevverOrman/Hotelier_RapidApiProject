using HotelProject.EntityLayer.Concrete;
using System.Collections.Generic;

namespace HotelProject.BusinessLayer.Abstract
{
    public interface IAppUserService:IGenericService<AppUser>
    {
        List<AppUser> TUserListWithWorklocation();

        List<AppUser> TUsersListWithWorklocations();
    }
}
