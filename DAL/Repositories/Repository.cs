using DAL.EF;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
	public class Repository<T>
		where T : class
	{
		private readonly MMPTContext context;
		private readonly DbSet<T> dbSet;

        protected Repository(MMPTContext context)
        {
            this.context = context;
			this.dbSet = this.context.Set<T>();
        }

		protected MMPTContext Context { get { return this.context; } }
		protected DbSet<T> DbSet { get { return this.dbSet; } }

		public async Task AddAsync(T entity)
		{
			await DbSet.AddAsync(entity);
			await Context.SaveChangesAsync();
		}

		public async Task<T> GetAsync(int id)
		{
			return await DbSet.FindAsync(id);
		}

		public async Task
    }
}
