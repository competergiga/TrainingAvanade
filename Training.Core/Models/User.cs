using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training.Core.Contracts;

namespace Training.Core.Models
{
    public class User : IRemovable
    {

        public Guid Id { get; set; }
        public string DNI { get; set; }
        public string Name { get; set; }        
        public bool IsDeleted { get; set; }
    }
}
