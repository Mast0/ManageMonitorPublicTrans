using Data.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
	public interface IDriverRepository : IRepository<Driver>
	{
		Task<Driver> GetByVechicleIdAsync(int id);

		Task<Driver> GetWithDetailsAsync(int id);

		Task<ICollection<Driver>> GetAllWitchDetails();
	}
}
