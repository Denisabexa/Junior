using Microsoft.EntityFrameworkCore;
using UsersService.Models;

namespace UsersService.DBContext
{
	public class UsersDbContext : DbContext
	{
		public UsersDbContext(DbContextOptions options) : base(options) { }

		public DbSet<User> Users => Set<User>();
		public DbSet<Order> Orders => Set<Order>();
		public DbSet<Product> Products => Set<Product>();
	}
}
