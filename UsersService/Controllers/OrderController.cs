using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using UsersService.Models;
using UsersService.Service;
namespace UsersService.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class OrderController : ControllerBase
	{
		private readonly IOrderService _orderService;

		public OrderController(IOrderService orderService)
		{
			_orderService = orderService;
		}

		[HttpGet]
		public async Task<IEnumerable<Order>> GetAll()
		{
			var order= await _orderService.GetAllOrders();
			return order;
		}

		[HttpGet("{id}")]
		public async Task<Order> GetById(int id)
		{
			var order = await _orderService.GetOrderById(id);
			return order;
		}

		[HttpGet("by-date/{date}")]
		public async Task<IEnumerable<Order>> GetOrdersByDate(DateTime date)
		{
			var order = await _orderService.GetOrdersByDate(date);
			return order;
		}
		[HttpGet("by-date/{date}")]
		public async Task<IEnumerable<Order>> GetOrdersByUserId(DateTime date)
		{
			var order = await _orderService.GetOrdersByDate(date);
			return order;
		}
	}
}
