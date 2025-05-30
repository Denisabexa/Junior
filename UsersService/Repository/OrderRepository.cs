using Microsoft.EntityFrameworkCore;
using UsersService.DBContext;
using UsersService.Models;

namespace UsersService.Repository
{
	public class OrderRepository : IOrderRepository
	{
		private readonly UsersDbContext _context;

		public OrderRepository(UsersDbContext context)
		{
			_context = context;
		}

		public async Task<IEnumerable<Order>> GetAllOrdersAsync()
		{
			var orders = await _context.Orders.ToListAsync();
			return orders;
		}

		public async Task<Order?> GetOrderByIdAsync(int id)
		{
			var order = await _context.Orders.FindAsync(id);
			return order;
		}
		public async Task<IEnumerable<Order>> GetOrdersByDateAsync(DateTime date)
		{
			return await _context.Orders
				.Where(o => o.Date.Date == date.Date)
				.ToListAsync();
		}
		public async Task<IEnumerable<Order>> GetOrdersByUserIdAsync(int userId)
		{
			return await _context.Orders
				.Where(o => o.UserId == userId)
				.ToListAsync();
		}
	}
}
