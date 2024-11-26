using DAL.EF;
using DAL.Interfaces;
using Data.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
	public sealed class DriverRepository : Repository<Driver>, IDriverRepository
	{
        public DriverRepository(MMPTContext context) :  base(context)
        {
        }

        public async Task<IEnumerable<Driver>> GetAllWitchDetails()
		{
			return await DbSet.Include(d => d.Vechicle).ToListAsync();
		}

		public async Task<Driver> GetByVechicleIdAsync(int vechicleId)
		{
			return await DbSet.Include(d => d.Vechicle)
				.FirstOrDefaultAsync(d => d.VechicleId == vechicleId);
		}

		public async Task<Driver> GetWithDetailsAsync(int id)
		{
			return await DbSet.Include(d => d.Vechicle)
				.FirstOrDefaultAsync(d => d.Id == id);
		}
	}
}
