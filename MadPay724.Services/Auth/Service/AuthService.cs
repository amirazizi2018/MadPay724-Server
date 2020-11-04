using System.Threading.Tasks;
using MadPay724.Common.Helper;
using MadPay724.Data.DatabaseContext;
using MadPay724.Data.Models;
using MadPay724.Repo.Infrastructure;
using MadPay724.Services.Auth.Interface;

namespace MadPay724.Services.Auth.Service
{
	public class AuthService : IAuthService
	{
		private readonly IUnitOfWork<MadpayDbContext> _db;

		public AuthService(IUnitOfWork<MadpayDbContext> dbContext)
		{
			_db = dbContext;
		}

		public async Task<User> Login(string username, string password)
		{
			throw new System.NotImplementedException();
		}

		public async Task<User> Register(User user, string password)
		{
			byte[] passwordHash, passwordSalt;
			Utilites.CreatePasswordHash(password, out passwordHash, out passwordSalt);
			user.PasswordHash = passwordHash;
			user.PasswordSalt = passwordSalt;

			await _db.UserRepository.InsertAsync(user);
			await _db.SaveAsync();

			return user;

		}

		
	}
}
