﻿using Avanade.SubTCSE.Projeto.Domain.Base.Repository.MongoDB;
using MongoDB.Driver;

namespace Avanade.SubTCSE.Projeto.Data.Repositories.Base.MongoDB
{
    public class MongoDBContext : IMongoDBContext
    {
        public IMongoCollection<TEntity> GetColletction<TEntity>(string collection)
        {
            throw new System.NotImplementedException();
        }
    }
}