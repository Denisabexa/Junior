using UsersService.Models;

namespace UsersService.Service.UserOrders
{
	public interface IUserOrdersService
	{
		Task<IEnumerable<Order>> GetOrdersByUserIdAsync(int userId);
		Task<User?> GetUserByOrderId(int orderId);
	}
}
