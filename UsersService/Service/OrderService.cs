using UsersService.Models;
using UsersService.Repository;
using UsersService.Service;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace UsersService.Service
{
	public class OrderService : IOrderService
	{
		private readonly IOrderRepository _orderRepository;

		public OrderService(IOrderRepository orderRepository)
		{
			_orderRepository = orderRepository;
		}

		public async Task<IEnumerable<Order>> GetAllOrders()
		{
			var order = await _orderRepository.GetAllOrders();
			return order;
		}
		public async Task<Order> GetOrderById(int id)
		{
			var order = await _orderRepository.GetOrderByIdAsync(id);
			return order;	
		}

		public async Task<IEnumerable<Order>> GetOrdersByDate(DateTime date)
		{
			var order = await _orderRepository.GetOrdersByDateAsync(date);
			return order;	
		}
		//public async Task<IEnumerable<Order>> GetOrdersByTotal(double total)
		//{
		//	var order = await _orderRepository.GetOrdersByTotalAsync(total);
		//	return order;
		//}

	}
}
