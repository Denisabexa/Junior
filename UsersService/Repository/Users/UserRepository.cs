using Microsoft.EntityFrameworkCore;
using UsersService.DBContext;
using UsersService.Models;

namespace UsersService.Repository.Users
{
//this is a small dumb comment
	public class UserRepository : IUserRepository
	{
		private readonly UsersDbContext _context;
		public UserRepository(UsersDbContext context) 
		{
			_context = context;
		}

		public async Task<IEnumerable<User>> GetAll()
		{
			var users = await _context.Users.ToListAsync();
			return users;
		}
		public async Task<User?> GetByIdAsync(int id)
		{
			var user = await _context.Users
				.AsNoTracking()
				.FirstOrDefaultAsync(u=>u.Id == id);
			return user;
		}
		public async Task<User?> GetByEmailAsync(string email)
		{
			var user = await _context.Users
				.AsNoTracking()
				.FirstOrDefaultAsync(u => u.Email == email);
			return user;
		}
		public async Task<User?> GetByUsernameAndPasswordAsync(string username, string password)
		{
			var user = await _context.Users
				.AsNoTracking()
				.FirstOrDefaultAsync(u => u.Username == username && u.Password == password);
			return user;
		}
	}
}
