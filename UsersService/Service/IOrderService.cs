using System.Collections.Generic;
using System.Threading.Tasks;
using UsersService.Models;

namespace UsersService.Service
{
	public interface IOrderService
	{
		Task<IEnumerable<Order>> GetAllOrders();
		Task<Order> GetOrderById(int id);
		Task<IEnumerable<Order>> GetOrdersByDate(DateTime date);
		//Task<IEnumerable<Order>> GetOrdersByTotal(double total);
	}
}
