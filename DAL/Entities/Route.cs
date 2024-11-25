using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entites
{
	public sealed class Route
	{
		public int Id { get; set; }

		public int ScheduleId { get; set; }

		public Schedule Schedule { get; set; }
	}
}
