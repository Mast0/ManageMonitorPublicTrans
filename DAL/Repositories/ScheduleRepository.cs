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
	public sealed class ScheduleRepository : Repository<Schedule>, IScheduleRepository
	{
        public ScheduleRepository(MMPTContext context) : base(context)
        {
        }
    }
}
