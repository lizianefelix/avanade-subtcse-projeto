using MongoDB.Driver;

namespace Avanade.SubTCSE.Projeto.Domain.Base.Repository.MongoDB
{
    public interface IMongoDBContext
    {
        IMongoCollection<TEntity> GetColletction<TEntity>(string collection);
    }
}
