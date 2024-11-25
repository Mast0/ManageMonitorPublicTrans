using Data.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
	public interface ISchedule : IRepository<Schedule>
	{
		Task<Schedule> GetWithDetailsAsync(int id);

		Task<IEnumerable<Schedule>> GetAllWitchDetails();
	}
}
