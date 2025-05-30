using Microsoft.AspNetCore.Mvc;
using UsersService.Models;
using UsersService.Service.Users;

namespace UsersService.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class UserController : ControllerBase
	{
		private readonly IUserService _userService;

		public UserController(IUserService userService)
		{
			_userService = userService;
		}

		[HttpGet]
		public async Task<IEnumerable<User>> GetAll()
		{
			var users = await _userService.GetAll();
			return users;
		}

		[HttpGet("{id}")]
		public async Task<User> GetById(int id)
		{
			var user = await _userService.GetById(id);
			return user;
		}

		[HttpGet("email/{email}")]
		public async Task<User?> GetByEmail(string email)
		{
			var user = await _userService.GetByEmail(email);
			return user;
		}
		
		[HttpGet("username/{username}&&password/{password}")]
		public async Task<User?> GetByUsernameAndPassword(string username, string password)
		{
			var user = await _userService.GetByUsernameAndPassword(username, password);
			return user;
		}
	}
}
