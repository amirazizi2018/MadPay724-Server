using System.Threading.Tasks;
using MadPay724.Data.Models;

namespace MadPay724.Services.Auth.Interface
{
	public interface IAuthService
	{
		Task<User> Register(User user, string password);
		Task<User> Login(string username, string password);
	}
}
