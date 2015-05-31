using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;

namespace Pres.Web.Models
{
	public class PresentationRepository : IPresentationRepository
	{
		private readonly IMongoClient _client;
		private readonly IMongoDatabase _database;
		private readonly IMongoCollection<Presentation> _collection;

		public PresentationRepository()
		{
			_client = new MongoClient("mongodb://localhost:27017");
			_database = _client.GetDatabase("presentation");
			_collection = _database.GetCollection<Presentation>("presentation");
		}

		public async void Add(Presentation presentations)
		{
			await _collection.InsertOneAsync(presentations);
		}

		public async Task<List<Presentation>> All()
		{
			var presentationList = await _collection.Find(new BsonDocument()).ToListAsync();
			return presentationList;
		}

		public async Task<Presentation> Get(ObjectId id)
		{
			var filter = Builders<Presentation>.Filter.Eq ("_id", id);
			var presentation = await _collection.Find (filter).FirstAsync ();

			return presentation;
		}

		public async void Update(Presentation presentations)
		{
			var filter = Builders<Presentation>.Filter.Where(x => x.Id == presentations.Id);
			await _collection.ReplaceOneAsync(filter, presentations);
		}

	}
}