using UsersService.Models;
using UsersService.Repository;

namespace UsersService.Service
{
	public class OrderService : IOrderService
	{
		private readonly IOrderRepository _orderRepository;

		public OrderService(IOrderRepository orderRepository)
		{
			_orderRepository = orderRepository;
		}

		public async Task<IEnumerable<Order>> GetAllOrdersAsync()
		{
			var order = await _orderRepository.GetAllOrdersAsync();
			return order;
		}
		public async Task<Order?> GetOrderByIdAsync(int id)
		{
			var order = await _orderRepository.GetOrderByIdAsync(id);
			return order;
		}

		public async Task<IEnumerable<Order>> GetOrdersByDateAsync(DateTime date)
		{
			var order = await _orderRepository.GetOrdersByDateAsync(date);
			return order;
		}
		public async Task<IEnumerable<Order>> GetOrdersByUserIdAsync(int userId)
		{
			var order = await _orderRepository.GetOrdersByUserIdAsync(userId);
			return order;
		}

	}
}
