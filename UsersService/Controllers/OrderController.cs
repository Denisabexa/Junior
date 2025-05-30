using Microsoft.AspNetCore.Mvc;
using UsersService.Models;
using UsersService.Service.Orders;

namespace UsersService.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class OrderController : ControllerBase
	{
		private readonly IUserOrdersService _orderService;

		public OrderController(IUserOrdersService orderService)
		{
			_orderService = orderService;
		}

		[HttpGet]
		public async Task<IEnumerable<Order>> GetAll()
		{
			var order= await _orderService.GetAllOrdersAsync();
			return order;
		}

		[HttpGet("{id}")]
		public async Task<Order?> GetById(int id)
		{
			var order = await _orderService.GetOrderByIdAsync(id);
			return order;
		}

		[HttpGet("by-date/{date}")]
		public async Task<IEnumerable<Order>> GetOrdersByDate(DateTime date)
		{
			var order = await _orderService.GetOrdersByDateAsync(date);
			return order;
		}
	}
}
