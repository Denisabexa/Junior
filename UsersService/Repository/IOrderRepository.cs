using System.Collections.Generic;
using System.Threading.Tasks;
using UsersService.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace UsersService.Repository
{
	public interface IOrderRepository
	{
		Task<IEnumerable<Order>> GetAllOrders();
		Task<Order> GetOrderByIdAsync(int id);
		Task<IEnumerable<Order>> GetOrdersByDateAsync(DateTime date);
		//Task<IEnumerable<Order>> GetOrdersByTotalAsync(double total);
	}
}

