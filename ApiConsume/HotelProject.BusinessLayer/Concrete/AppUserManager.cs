using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using System.Collections.Generic;

namespace HotelProject.BusinessLayer.Concrete
{
    public class AppUserManager : IAppUserService
    {
        private readonly IAppUserDal _appUserDal;

        public AppUserManager(IAppUserDal appUserDal)
        {
            _appUserDal = appUserDal;
        }

        public void TDelete(AppUser t)
        {
            throw new System.NotImplementedException();
        }

        public AppUser TGetByID(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<AppUser> TGetList()
        {
           return _appUserDal.GetList();
        }

        public void TInsert(AppUser t)
        {
            throw new System.NotImplementedException();
        }

        public void TUpdate(AppUser t)
        {
            throw new System.NotImplementedException();
        }

        public List<AppUser> TUserListWithWorklocation()
        {
            return _appUserDal.UserListWithWorklocation();
        }

        public List<AppUser> TUsersListWithWorklocations()
        {
            return _appUserDal.UsersListWithWorklocations();
        }
    }
}
