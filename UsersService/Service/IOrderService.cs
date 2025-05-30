using UsersService.Models;

namespace UsersService.Service
{
	public interface IOrderService
	{
		Task<IEnumerable<Order>> GetAllOrdersAsync();
		Task<Order?> GetOrderByIdAsync(int id);
		Task<IEnumerable<Order>> GetOrdersByDateAsync(DateTime date);
		Task<IEnumerable<Order>> GetOrdersByUserIdAsync(int userId);
	}
}
