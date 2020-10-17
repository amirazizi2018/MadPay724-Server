using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MadPay724.Data.Infrastructure
{
	public class UnitOfWork<TContext> : IUnitOfWork<TContext> where TContext : DbContext, new()
	{
		#region ctor
		protected readonly DbContext Db;

		public UnitOfWork()
		{
			Db = new TContext();
		}

		#endregion

		#region Save
		public void Save()
		{
			Db.SaveChanges();
		}

		public Task<int> SaveAsync()
		{
			return Db.SaveChangesAsync();
		}

		#endregion

		#region Dispose
		private bool _disposed = false;
		protected virtual void Dispose(bool disposing)
		{
			if (!_disposed)
			{
				if (disposing)
				{
					Db.Dispose();
				}
			}

			_disposed = true;
		}

		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}

		~UnitOfWork()
		{
			Dispose(false);
		}


		#endregion

	}
}
