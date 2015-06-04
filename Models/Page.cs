using MongoDB.Bson.Serialization.Attributes;

namespace Pres.Web.Models
{
	public class Page
	{
		[BsonElement("page_title")]
		public string PageTitle {get;set;}
		[BsonElement("body")]
		public string Body { get; set; }
		[BsonElement("order")]
		public int Order { get; set; }
	}
}

