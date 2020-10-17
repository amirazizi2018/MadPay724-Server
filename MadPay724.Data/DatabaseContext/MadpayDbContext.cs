using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace MadPay724.Data.DatabaseContext
{
	class MadpayDbContext : DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Data Source=ZIZO-HPC;Initial Catalog=MadPay724db;Integrated Security=true;MultipleActiveResultSets=true;");
		}
	}
}
