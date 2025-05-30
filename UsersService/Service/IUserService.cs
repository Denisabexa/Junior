using UsersService.Models;

namespace UsersService.Service
{
	public interface IUserService
	{
		Task<IEnumerable<User>> GetAll();
		Task<User> GetById(int id);
		Task<User?> GetByEmail(string email);
		Task<User?> GetByUsernameAndPassword(string username, string password);
	}
}
