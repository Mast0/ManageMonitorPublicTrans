using DAL.EF;
using DAL.Interfaces;
using Data.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
	public sealed class RouteRepository : Repository<Route>, IRouteRepository
	{
        public RouteRepository(MMPTContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Route>> GetAllWitchDetails()
		{
			return await DbSet.Include(r => r.Schedule).ToListAsync();
		}

		public async Task<Route> GetWithDetailsAsync(int id)
		{
			return await DbSet.Include(r => r.Schedule)
				.FirstOrDefaultAsync(x => x.Id == id);
		}
	}
}
