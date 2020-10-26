using MadPay724.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace MadPay724.Data.DatabaseContext
{
	public class MadpayDbContext : DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Data Source=ZIZO-HPC;Initial Catalog=MadPay724db;Integrated Security=true;MultipleActiveResultSets=true;User Id=sa;Password=P@ssw0rd;");
		}

		public DbSet<User> Users { get; set; }
		public DbSet<Photo> Photos { get; set; }
		public DbSet<BankCard> BankCards { get; set; }


	}
}
