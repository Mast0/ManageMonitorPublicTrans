using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace DAL.EF
{
	public class MMPTContextFactory : IDesignTimeDbContextFactory<MMPTContext>
	{
		public MMPTContext CreateDbContext(string[] args)
		{
			var configuration = new ConfigurationBuilder()
			.SetBasePath(AppContext.BaseDirectory)
			.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
			.AddEnvironmentVariables()
			.Build();

			var optionsBuilder = new DbContextOptionsBuilder<MMPTContext>();
			optionsBuilder.UseNpgsql();

			return new MMPTContext(optionsBuilder.Options);
		}
	}
}
