using Data.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF
{
	public sealed class MMPTContext : DbContext
	{
		public DbSet<Coordinates> Coordinates { get; set; }

		public DbSet<Driver> Drivers { get; set; }

		public DbSet<Route> Routes { get; set; }

		public DbSet<RoutePoint> RoutePoints { get; set; }

		public DbSet<Schedule> Schedules { get; set; }

		public DbSet<Vechicle> Vechicles { get; set; }

        public MMPTContext(DbContextOptions<MMPTContext> opt)
			: base(opt)
        {
        }
    }
}
