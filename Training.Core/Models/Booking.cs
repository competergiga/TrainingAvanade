using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training.Core.Contracts;

namespace Training.Core.Models
{
    public class Booking : IRemovable
    {

        public Guid Id { get; set; }
        public DateTime DateCreation { get; set; }
        public DateTime DateReturn { get; set; }
        public Guid UserId { get; set; }
        public Guid BookId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
