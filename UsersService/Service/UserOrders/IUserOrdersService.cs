using UsersService.Models;

namespace UsersService.Service.Orders
{
	public interface IUserOrdersService
	{
		Task<IEnumerable<Order>> GetOrdersByUserIdAsync(int userId);
		Task<User?> GetUserByOrderId(int orderId);
	}
}
