using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Application.Albums
{
    public interface IAlbumService
    {
        IEnumerable<AlbumDto> Get();
        AlbumDto Get(string isbn);
        void Create(AlbumDto book);
        void Update(AlbumDto book);
        void Delete(string isbn);
    }
}
