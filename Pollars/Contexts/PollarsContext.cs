using Microsoft.EntityFrameworkCore;
using Pollars.Models;

namespace Pollar.Model.Contexts
{
	public class PollarsContext : DbContext
	{
		public virtual DbSet<User> Users { get; set; }
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Pollars;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;");
		}
	}
}
