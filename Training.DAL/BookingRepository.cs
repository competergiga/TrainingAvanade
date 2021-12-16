using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training.Core.Models;
using Training.Core.Repositories;

namespace Training.DAL
{
    public class BookingRepository :IBookingRepository
    {

        private List<Booking> _bookings;


        public void Create(Booking booking)
        {
            _bookings.Add(booking);
        }
    }
}
