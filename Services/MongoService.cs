using MongoDB.Driver;
using cosmos_samples.Models;

namespace cosmos_samples.Services
{
    public class MongoService
    {
        private static MongoClient _client;

        public MongoService(IDatabaseSettings settings)
        {
            _client = new MongoClient(settings.MongoConnectionString);
        }

        public MongoClient GetClient()
        {
            return _client;
        }
    }
}