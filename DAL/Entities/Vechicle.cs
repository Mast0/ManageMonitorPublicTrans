using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entites
{
	public sealed class Vechicle
	{
		public int Id { get; set; }

		public string Type { get; set; }

		public int LocationId { get; set; }

		public Coordinates Location { get; set; }

		public int RouteId { get; set; }

		public Route Route { get; set; }

		public IEnumerable<RoutePoint> History { get; set; }
	}
}
