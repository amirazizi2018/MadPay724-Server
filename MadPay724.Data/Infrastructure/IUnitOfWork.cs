using System;
using System.Threading.Tasks;
using MadPay724.Data.Repositories.Interface;
using Microsoft.EntityFrameworkCore;

namespace MadPay724.Data.Infrastructure
{
	public interface IUnitOfWork<TContext> : IDisposable where TContext : DbContext
	{
		IUserRepository UserRepository { get; }
		void Save();
		Task<int> SaveAsync();
	}
}
