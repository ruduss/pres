using MongoDB.Bson;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pres.Web.Models
{
	public interface IPresentationRepository
	{
		Task<List<Presentation>> All();

		void Add(Presentation presentations);

		void Update(Presentation presentations);

		Task<Page> GetPage(ObjectId id, int? pageNumber);

	}
}
