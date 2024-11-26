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
	public sealed class VechicleRepository : Repository<Vechicle>, IVechicleRepository
	{
        public VechicleRepository(MMPTContext context) : base(context)
        {
        }
        public async Task<IEnumerable<Vechicle>> GetAllWitchDetails()
		{
			return await DbSet.Include(v => v.Location)
				.Include(v => v.Route)
				.Include(v => v.History)
				.ToListAsync();
		}

		public async Task<Vechicle> GetWithDetailsAsync(int id)
		{
			return await DbSet.Include(v => v.Location)
				.Include(v => v.Route)
				.Include(v => v.History)
				.FirstOrDefaultAsync(x => x.Id == id);
		}
	}
}
