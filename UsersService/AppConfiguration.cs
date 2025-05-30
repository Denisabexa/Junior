using UsersService.DBContext;
using UsersService.Models;
using UsersService.Repository;
using UsersService.Service;

namespace UsersService
{
	public static class AppConfiguration
	{
		public static void AddServices(IServiceCollection services)
		{
			services.AddScoped<IOrderService, OrderService>();
			services.AddScoped<IOrderRepository, OrderRepository>();

			services.AddScoped<IUserService, UserService>();
			services.AddScoped<IUserRepository, UserRepository>();


		}
		public static void SeedDB(IServiceProvider services)
		{
			using (var scope = services.CreateScope())
			{
				var db = scope.ServiceProvider.GetRequiredService<UsersDbContext>();

				if (!db.Users.Any())
				{
					db.Users.AddRange(
						new User { Id = 1, Username = "admin", Email = "admin@example.com", Password = "admin123" },
						new User { Id = 2, Username = "john", Email = "john@example.com", Password = "johnpass" }
					);
					db.SaveChanges();
				}
			}
		}
	}
}
