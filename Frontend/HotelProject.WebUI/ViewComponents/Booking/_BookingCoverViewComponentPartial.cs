using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.ViewComponents.Booking
{
    public class _BookingCoverViewComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
