using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.UnitOfWork
{
	public interface IUnitOfWork
	{
		IDriverRepository DriverRepository { get; }

		IRouteRepository RouteRepository { get; }

		IScheduleRepository ScheduleRepository { get; }

		IVechicleRepository VechicleRepository { get; }

		Task SaveAsync();
	}
}
