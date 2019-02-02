using Atlantida.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace Atlantida.Services
{
    public class MongoDbContext
    {
        protected readonly IMongoDatabase _database = null;

        public MongoDbContext(IOptions<MongoConnectionSettings> settings)
        {
            var client = new MongoClient(settings.Value.ConnectionString);
            if (client != null)
                _database = client.GetDatabase(settings.Value.Database);
        }

    }
}
