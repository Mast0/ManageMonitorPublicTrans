using Data.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
	public interface IRouteRepository : IRepository<Route>
	{
		Task<Route> GetWithDetailsAsync(int id);

		Task<ICollection<Route>> GetAllWitchDetails();
	}
}
