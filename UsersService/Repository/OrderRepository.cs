using UsersService.DBContext;
using UsersService.Models;
using UsersService.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace UsersService.Repository
{
	public class OrderRepository : IOrderRepository
	{
		private readonly UsersDbContext _context;

		public OrderRepository(UsersDbContext context)
		{
			_context = context;
		}

		public async Task<IEnumerable<Order>> GetAllOrders()
		{
			var orders = await _context.Orders.ToListAsync();
			return orders;
		}

		public async Task<Order> GetOrderByIdAsync(int id)
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
		//public async Task<IEnumerable<Order>> GetOrdersByTotalAsync(double total)
		//{
		//	return await _context.Orders
		//		.Where(o => o.Total == total)
		//		.ToListAsync();
		//}
	}
}
