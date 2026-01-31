using System.Collections.Generic;

namespace HotelProject.EntityLayer.Concrete
{
    public class MessageCategory
    {
        public int MessageCategoryId { get; set; }

        public string MessageCategoryName { get; set; }

        public List<Contact> Contacts { get; set; }
    }
}
