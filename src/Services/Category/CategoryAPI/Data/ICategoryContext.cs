using CategoryAPI.Entities;
using MongoDB.Driver;

namespace CategoryAPI.Data
{
    public interface ICategoryContext
    {
        IMongoCollection<Category> Categories { get; }
    }
}
