using Microsoft.EntityFrameworkCore;
using TaskWeb1.Models;

namespace TaskWeb1.Data
{
	public class ApplicationDbContext: DbContext 
	{
		public DbSet<Employee>Employees { get; set; }
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("server=.;database=asp10t1; trusted_connection=true; trustServerCertificate=true");
		}
	}
}
