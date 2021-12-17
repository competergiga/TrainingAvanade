﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training.Core.Models;
using Training.Core.Repositories;
using Training.DAL.Base;
using Training.DAL.Context;

namespace Training.DAL.Implementations
{
    public class AlbumRepository : RepositoryBase, IAlbumRepository
    {
        public AlbumRepository(TrainingDbContext trainingDbContext)
         : base(trainingDbContext)
        { }


        public void Create(Album album)
        {
            _trainingDbContext.Albums
                .Add(album);
        }

        public IEnumerable<Album> Get()
        {
            return _trainingDbContext.Albums
                .Where(x => !x.IsDeleted);
        }

        public Album Get(string isbn)
        {
            return _trainingDbContext.Albums
                .FirstOrDefault(x => x.ISBN == isbn);
        }


        public void Update(Album album)
        {
            _trainingDbContext.Albums
                .Update(album);
        }
    }
}
