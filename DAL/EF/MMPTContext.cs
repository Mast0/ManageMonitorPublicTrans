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

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Coordinates>()
				.HasKey(c => c.Id);

			modelBuilder.Entity<Driver>()
				.HasKey(d => d.Id);

			modelBuilder.Entity<Driver>()
				.HasOne(d => d.Vechicle)
				.WithMany()
				.HasForeignKey(d => d.VechicleId);

			modelBuilder.Entity<Route>()
				.HasKey(r => r.Id);

			modelBuilder.Entity<Route>()
				.HasOne(r => r.Schedule)
				.WithMany()
				.HasForeignKey(r => r.ScheduleId);

			modelBuilder.Entity<RoutePoint>()
				.HasKey(rp => rp.Id);

			modelBuilder.Entity<RoutePoint>()
				.HasOne(rp => rp.Coordinate)
				.WithMany()
				.HasForeignKey(rp => rp.CoordinateId);

			modelBuilder.Entity<RoutePoint>()
				.HasOne(rp => rp.Vechicle)
				.WithMany()
				.HasForeignKey(rp => rp.VechicleId);

			modelBuilder.Entity<Schedule>()
				.HasKey(s => s.Id);

			modelBuilder.Entity<Vechicle>()
				.HasKey(v => v.Id);

			modelBuilder.Entity<Vechicle>()
				.HasOne(v => v.Location)
				.WithMany()
				.HasForeignKey(v => v.LocationId);

			modelBuilder.Entity<Vechicle>()
				.HasOne(v => v.Route)
				.WithMany()
				.HasForeignKey(v => v.RouteId);
		}
	}
}
