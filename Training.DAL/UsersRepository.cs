using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training.Core.Models;
using Training.Core.Repositories;

namespace Training.DAL
{
    public class UsersRepository : IUsersRepository
    {

        private List<User> _users;


        public UsersRepository()
        {
            _users = new List<User>();

            for (int i = 0; i < 5; i++)
                _users.Add(new User { Id = Guid.NewGuid(), Name = $"USER-{i}{i}", DNI = $"dni xx{i}",IsDeleted=false});
        }


        public IEnumerable<User> Get()
        {
            return _users.Where(x => !x.IsDeleted);
        }


    }
}
