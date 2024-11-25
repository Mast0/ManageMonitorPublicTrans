using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entites
{
	public sealed class RoutePoint
	{
		public int Id { get; set; }

		public Coordinates Coordinate { get; set; }

		public DateTime TimeStamp { get; set; }
	}
}
