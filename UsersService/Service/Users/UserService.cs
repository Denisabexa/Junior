using UsersService.Models;
using UsersService.Repository.Users;

namespace UsersService.Service.Users
{
	public class UserService : IUserService
	{
		private readonly IUserRepository _userRepository;

		public UserService(IUserRepository userRepository) 
		{
			_userRepository = userRepository;
		}

		public async Task<IEnumerable<User>> GetAll()
		{
			var users = await _userRepository.GetAll();
			return users;
		}
		public async Task<User?> GetById(int id)
		{
			var users = await _userRepository.GetByIdAsync(id);
			return users;
		}
		public async Task<User?> GetByEmail(string email)
		{
			var user = await _userRepository.GetByEmailAsync(email);
			return user;
		}
		public async Task<User?> GetByUsernameAndPassword(string username, string password)
		{
			var user = await _userRepository.GetByUsernameAndPasswordAsync(username, password);
			return user;
		}
	}
}