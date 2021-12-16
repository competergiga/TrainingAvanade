using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Application.Books
{
    public interface IBookingService
    {
        void Create(BookingDto booking);
    }
}
