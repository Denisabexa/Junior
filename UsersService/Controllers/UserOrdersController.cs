using Microsoft.AspNetCore.Mvc;
using UsersService.Models;
using UsersService.Service.Orders;

namespace UsersService.Controllers
{

	[ApiController]
	[Route("api/[controller]")]
	public class UserOrdersController : ControllerBase
	{

		private readonly IUserOrdersService _orderService;

		public UserOrdersController(IUserOrdersService orderService)
		{
			_orderService = orderService;
		}

		[HttpGet("get-orders-by-user-id/{userId}")]
		public async Task<IEnumerable<Order>> GetOrdersByUserId(int userId)
		{
			var order = await _orderService.GetOrdersByUserIdAsync(userId);
			return order;
		}

		[HttpGet("get-user-by-order-id/{orderId}")]
		public async Task<User?> GetUserByOrderId(int orderId)
		{
			var order = await _orderService.GetUserByOrderId(orderId);
			return order;
		}
	}
}
