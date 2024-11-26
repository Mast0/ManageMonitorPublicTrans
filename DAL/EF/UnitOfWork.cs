using DAL.Interfaces;
using DAL.Repositories;
using DAL.UnitOfWork;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF
{
	public sealed class UnitOfWork : IUnitOfWork
	{
		private readonly MMPTContext _context;

        public UnitOfWork(MMPTContext context)
        {
            _context = context;
        }

        public IDriverRepository DriverRepository => new DriverRepository(_context);

		public IRouteRepository RouteRepository => new RouteRepository(_context);

		public IScheduleRepository ScheduleRepository => new ScheduleRepository(_context);

		public IVechicleRepository VechicleRepository => new VechicleRepository(_context);

		public async Task SaveAsync()
		{
			await _context.SaveChangesAsync();
		}
	}
}
