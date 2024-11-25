using Data.Entites;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
	public interface IVechicleRepository : IRepository<Vechicle>
	{
		Task<Route> GetWithDetailsAsync(int id);

		Task<IEnumerable<Route>> GetAllWitchDetails();
	}
}
