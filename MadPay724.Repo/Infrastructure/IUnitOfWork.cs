using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using IUserRepository = MadPay724.Repo.Repositories.Interface.IUserRepository;

namespace MadPay724.Repo.Infrastructure
{
	public interface IUnitOfWork<TContext> : IDisposable where TContext : DbContext
	{
		IUserRepository UserRepository { get; }
		void Save();
		Task<int> SaveAsync();
	}
}
