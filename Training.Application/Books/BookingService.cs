using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training.Core.Models;
using Training.Core.Repositories;

namespace Training.Application.Books
{
    public class BookingService: IBookingService
    {
        private readonly IBookingRepository _bookingRepository;
           

        public BookingService(IBookingRepository bookingRepository)
        {
            _bookingRepository = bookingRepository;            
        }

 
        public void Create(BookingDto dto)
        {
          //  var book = 

            //var booking = Map(dto);

            //booking.Id = Guid.NewGuid();

            //_bookingRepository.Create(booking);
        }


        private Booking Map(BookingDto dto)
        {
            return new Booking
            {
                DateReturn = dto.DateReturn,
                DateCreation = dto.DateCreation,
             //   UserId = dto.UserName,
               // BookId = dto.ISBN
            };
        }

        private BookingDto MapEntity(Booking dto)
        {
            return new BookingDto
            {
                DateReturn = dto.DateReturn,
                DateCreation = dto.DateCreation,
//UserId = dto.UserId,
            //    BookId = dto.BookId

            };
        }


    }



}
