﻿using Avanade.SubTCSE.Projeto.Domain.Aggregates;
using Avanade.SubTCSE.Projeto.Domain.Base.Repository;
using MongoDB.Driver;
using System.Threading.Tasks;

namespace Avanade.SubTCSE.Projeto.Data.Repositories.Base
{
    public abstract class BaseRepository<TEntity, Tid>
        : IBaseRepository<TEntity, Tid> where TEntity : BaseEntity<Tid>
    {
        private readonly IMongoCollection<TEntity> _collection;

        public async Task<TEntity> Add(TEntity entity)
        {
           await _collection.InsertOneAsync(entity);

            return entity;
        }

        public async Task<TEntity> FindById(Tid id)
        {
            throw new System.NotImplementedException();
        }
    }
}
