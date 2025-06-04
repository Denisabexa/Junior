using UsersService.DBContext;
using UsersService.Models;
using Microsoft.EntityFrameworkCore;
using UsersService.Service.Orders;
using UsersService.Service.Users;
using UsersService.Repository.Orders;
using UsersService.Repository.Users;
using UsersService.Service.UserOrders;
using UsersService.Service.Products;
using UsersService.Repository.Products;
using UsersService.Service.Products;

namespace UsersService
{
	public static class AppConfiguration
	{
		public static void AddServices(IServiceCollection services)
		{
			services.AddScoped<IOrdersService, OrderService>();
			services.AddScoped<IOrderRepository, OrderRepository>();

			services.AddScoped<IUserService, UserService>();
			services.AddScoped<IUserRepository, UserRepository>();

			services.AddScoped<IUserOrdersService, UserOrdersService>();

			services.AddScoped<IProductService, ProductService>();
			services.AddScoped<IProductRepository, ProductRepository>();

		}
		public static void AddDBContext(IServiceCollection services)
		{
			services.AddDbContext<UsersDbContext>(options =>
				options.UseInMemoryDatabase("UsersDb")
			);
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

				if (!db.Orders.Any())
				{
					db.Orders.AddRange(
						new Order { Id = 3, UserId = 1, Date = DateTime.Now.AddMonths(-1), Total = 120.5 },
						new Order { Id = 4, UserId = 2, Date = DateTime.Now.AddDays(-1), Total = 85.11 }
					);
					db.SaveChanges();
				}
				if (!db.Products.Any())
				{
					db.Products.AddRange(
						new Product { Id = 5,  },
						new Product { Id = 6,  }
					);
					db.SaveChanges();
				}
			}
		}
	}
}
