using Microsoft.AspNetCore.Mvc;
using Training.Application.Books;

namespace Training.WebAPI.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class BookingController : ControllerBase
    {

        private readonly IBookingService _bookingService;


        public BookingController(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }



        [HttpPost]
        public IActionResult Post(BookingDto booking)
        {
            _bookingService.Create(booking);

            return Ok();
        }
    }
}
