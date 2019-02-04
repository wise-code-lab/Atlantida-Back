using Atlantida.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace Atlantida.Services
{
    public class NoteContext : MongoDbContext
    {
        public NoteContext(IOptions<MongoConnectionSettings> settings) : base(settings) { }

        public IMongoCollection<Note> Notes
        {
            get
            {
                return _database.GetCollection<Note>("Note");
            }
        }
    }
}
