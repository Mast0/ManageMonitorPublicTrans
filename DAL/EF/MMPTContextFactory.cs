using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace DAL.EF
{
	public class MMPTContextFactory : IDesignTimeDbContextFactory<MMPTContext>
	{
		public MMPTContext CreateDbContext(string[] args)
		{

			var optionsBuilder = new DbContextOptionsBuilder<MMPTContext>();
			optionsBuilder.UseNpgsql(Environment.GetEnvironmentVariable("PostgresConnection"));

			return new MMPTContext(optionsBuilder.Options);
		}
	}
}
