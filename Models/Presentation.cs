using MongoDB.Bson;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;

namespace Pres.Web.Models
{
	
	public class Presentation : IPresentation 
	{
		[BsonId]
		public ObjectId Id { get; set; }
		[BsonElement("presentation_title")]
		public string Title { get; set; }
		[BsonElement("author")]
		public string Author { get; set; }
		[BsonElement("pages")]
		public List<Page> Pages { get; set; }
	}

}

