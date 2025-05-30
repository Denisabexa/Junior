using UsersService.Models;

namespace UsersService.Repository
{
	public interface IOrderRepository
	{
		Task<IEnumerable<Order>> GetAllOrdersAsync();
		Task<Order?> GetOrderByIdAsync(int id);
		Task<IEnumerable<Order>> GetOrdersByDateAsync(DateTime date);
		Task<IEnumerable<Order>> GetOrdersByUserIdAsync(int userId);
	}
}

