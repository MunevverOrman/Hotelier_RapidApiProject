using HotelProject.EntityLayer.Concrete;
using System.Collections.Generic;

namespace HotelProject.DataAccessLayer.Abstract
{
    public interface IStaffDal:IGenericDal<Staff>
    {
        int GetStaffCount();
        List<Staff> Last4Staff();
    }
}
