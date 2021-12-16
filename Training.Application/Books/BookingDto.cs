using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Application.Books
{
    public class BookingDto
    {
     
        public DateTime DateCreation { get; set; }
        public DateTime DateReturn { get; set; }
        public string UserName { get; set; }
        public string ISBN { get; set; }
        
    }
}

