using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingsController : ControllerBase
    {
        private readonly IBookingService _bookingsService;

        public BookingsController(IBookingService bookingsService)
        {
            _bookingsService = bookingsService;
        }
        [HttpGet]
        public IActionResult BookingList()
        {
            var values = _bookingsService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddBooking(Booking booking)
        {
            _bookingsService.TInsert(booking);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteBooking(int id)
        {
            var values = _bookingsService.TGetByID(id);
            _bookingsService.TDelete(values);
            return Ok();
        }
        [HttpPut("UpdateBooking")]
        public IActionResult UpdateBooking(Booking booking)
        {
            _bookingsService.TUpdate(booking);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetBooking(int id)
        {
            var values = _bookingsService.TGetByID(id);
            return Ok(values);

        }
        [HttpPut("UpdateBookingApprovedStatus")]
        public IActionResult UpdateBookingApprovedStatus(Booking booking)
        {
            _bookingsService.TBookingStatusChangeApproved(booking);
            return Ok();
        }

        [HttpGet("Last6Booking")]
        public IActionResult Last6Booking()
        {
            var values = _bookingsService.TLast6Bookings();
            return Ok(values);
        }

        [HttpGet("BookingAproved")]
        public async Task<IActionResult> BookingAproved(int id)
        {
            _bookingsService.TBookingStatusChangeApproved3(id);
            return Ok();
        }

        [HttpGet("BookingCancel")]
        public async Task<IActionResult> BookingCancel(int id)
        {
            _bookingsService.TBookingStatusChangeCancel(id);
            return Ok();
        }
        [HttpGet("BookingWait")]
        public async Task<IActionResult> BookingWait(int id)
        {
            _bookingsService.TBookingStatusChangeWait(id);
            return Ok();
        }
    }
}
