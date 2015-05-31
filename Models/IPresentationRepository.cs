using MongoDB.Bson;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pres.Web.Models
{
	public interface IPresentationRepository
	{
		Task<List<Presentation>> All();

		Task<Presentation> Get(ObjectId id);

		void Add(Presentation presentations);

		void Update(Presentation presentations);

	}
}
