using MadPay724.Data.DatabaseContext;
using MadPay724.Data.Models;
using Microsoft.EntityFrameworkCore;
using IUserRepository = MadPay724.Repo.Repositories.Interface.IUserRepository;

namespace MadPay724.Repo.Repositories.Repo
{
	public class UserRepository : MadPay724.Repo.Infrastructure.Repository<User>, IUserRepository
	{
		private readonly DbContext _db;

		public UserRepository(DbContext dbContext) : base(dbContext)
		{
			_db = (_db ?? (MadpayDbContext)_db);
		}
	}
}
