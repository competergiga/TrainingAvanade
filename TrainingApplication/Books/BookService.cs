using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingCore;

namespace TrainingApplication.Books
{
    public class BookService
    {
        public IEnumerable<Book> Get()
        {
            for (int i = 0; i < 5; i++)
                yield return new Book { Id = i, ISBN = $"xxx-{i}{i}", Author = $"pepito perez {i}", Name = $"El mejor libro {i}" };

        }
    }
}
