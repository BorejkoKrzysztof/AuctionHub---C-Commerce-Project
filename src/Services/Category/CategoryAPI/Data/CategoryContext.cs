using CategoryAPI.Entities;
using MongoDB.Driver;

namespace CategoryAPI.Data
{
    public class CategoryContext : ICategoryContext
    {
        public CategoryContext(IConfiguration configuration)
        {
            var client = new MongoClient(configuration.GetValue<string>("DatabaseSettings:ConnectionString"));
            var database = client.GetDatabase(configuration.GetValue<string>("DatabaseSettings:DatabaseName"));

            Categories = database.GetCollection<Category>(configuration.GetValue<string>("DatabaseSettings:CollectionName"));

            //CategoriesContext.Seed()  TU BEDE SEEDOWAŁ
        }
        public IMongoCollection<Category> Categories { get; }
    }
}
