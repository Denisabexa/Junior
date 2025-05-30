using UsersService.Models;

namespace UsersService.Repository.Users
{
	public interface IUserRepository
	{
		Task<IEnumerable<User>> GetAll();
		Task<User?> GetByIdAsync(int id);
		Task<User?> GetByEmailAsync(string email);
		Task<User?> GetByUsernameAndPasswordAsync(string username, string password);
	}
}