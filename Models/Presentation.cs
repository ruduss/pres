using System;
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
		public List<Pages> Pages { get; set; }
	}

	public class Pages
	{
		[BsonElement("page_title")]
		public string PageTitle {get;set;}
		[BsonElement("body")]
		public string Body { get; set; }
		[BsonElement("order")]
		public int Order { get; set; }
	}
}

