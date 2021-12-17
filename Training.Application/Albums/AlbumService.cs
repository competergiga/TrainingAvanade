using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training.Application.Base;
using Training.Core.Models;
using Training.Core.Repositories;

namespace Training.Application.Albums
{
    public class AlbumService : ServiceBase, IAlbumService
    {

        private readonly IAlbumRepository _albumRepository;


        public AlbumService(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
            _albumRepository = unitOfWork.AlbumRepository;
        }


        public void Create(AlbumDto dto)
        {
            var book = Map(dto);

            book.Id = Guid.NewGuid();

            _albumRepository.Create(book);
            _unitOfWork.CommitTransaction();
        }

        public IEnumerable<AlbumDto> Get()
        {
            return _albumRepository.Get()
                .Select(MapEntity);
        }

        public AlbumDto Get(string isbn)
        {
            return MapEntity(_albumRepository.Get(isbn));
        }

        public void Update(AlbumDto dto)
        {
            var book = _albumRepository.Get(dto.ISBN);

            book.Author = dto.Author;
            book.Name = dto.Name;

            _albumRepository.Update(book);
            _unitOfWork.CommitTransaction();
        }

        public void Delete(string isbn)
        {
            var book = _albumRepository.Get(isbn);

            book.IsDeleted = true;

            _albumRepository.Update(book);
            _unitOfWork.CommitTransaction();
        }


        private Album Map(AlbumDto dto)
        {
            return new Album
            {
                ISBN = dto.ISBN,
                Name = dto.Name,
                Author = dto.Author,
                Genre = dto.Genre
            };
        }

        private AlbumDto MapEntity(Album dto)
        {
            return new AlbumDto
            {
                ISBN = dto.ISBN,
                Name = dto.Name,
                Author = dto.Author,
                Genre = dto.Genre,
            };
        }
    }
}
