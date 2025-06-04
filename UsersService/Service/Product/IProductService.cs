using UsersService.Models;

namespace UsersService.Service.Products
{
	public interface IProductService
	{
		Task<IEnumerable<Product>> GetAll();
		Task<Product?> GetProductByIdAsync(int id);
	}
}
