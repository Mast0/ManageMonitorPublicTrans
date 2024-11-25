using Data.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
	public interface IRepository<TEntity>
		where TEntity : class
	{
		Task AddAsync(TEntity entity);

		Task<TEntity> GetAsync(int id);

		Task<ICollection<TEntity>> GetAllAsync();

		Task UpdateAsync(TEntity entity);

		Task DeleteAsync(int id);
	}
}
