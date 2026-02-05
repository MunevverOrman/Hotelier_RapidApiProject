using HotelProject.EntityLayer.Concrete;
using System.Collections.Generic;

namespace HotelProject.BusinessLayer.Abstract
{
    public interface IStaffService:IGenericService<Staff>
    {
        int TGetStaffCount();

        List<Staff> TLast4Staff();
    }
}
