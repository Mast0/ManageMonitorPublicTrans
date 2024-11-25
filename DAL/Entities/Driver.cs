using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entites
{
	public sealed class Driver : User
	{
		public int VechicleId { get; set; }

		public Vechicle Vechicle { get; set; }
	}
}
