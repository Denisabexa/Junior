using UsersService.Models;
using UsersService.Repository.Orders;
using UsersService.Repository.Users;

namespace UsersService.Service.Orders
{
	public class UserOrdersService : IUserOrdersService
	{
		private readonly IOrderRepository _orderRepository;
		private readonly IUserRepository _userRepository;

		public UserOrdersService(IOrderRepository orderRepository, IUserRepository userRepository)
		{
			_orderRepository = orderRepository;
			_userRepository = userRepository;
		}

		public async Task<IEnumerable<Order>> GetOrdersByUserIdAsync(int userId)
		{
			var order = await _orderRepository.GetOrdersByUserIdAsync(userId);
			return order;
		}

		public async Task<User?> GetUserByOrderId(int orderId)
		{
			var order = await _orderRepository.GetOrderByIdAsync(orderId);
			if (order == null) return null;

			var user = await _userRepository.GetByIdAsync(order.UserId);
			return user;
		}
	}
}
