using UsersService.Models;

namespace UsersService.Service.Orders
{
	public interface IOrdersService
	{
		Task<IEnumerable<Order>> GetAllOrdersAsync();
		Task<Order?> GetOrderByIdAsync(int id);
		Task<IEnumerable<Order>> GetOrdersByDateAsync(DateTime date);
	}
}
