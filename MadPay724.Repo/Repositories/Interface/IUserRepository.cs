using System.Threading.Tasks;
using MadPay724.Data.Models;

namespace MadPay724.Repo.Repositories.Interface
{
	public interface IUserRepository : MadPay724.Repo.Infrastructure.IRepository<User>
	{
		Task<User> UserExists(string username);
	}
}
