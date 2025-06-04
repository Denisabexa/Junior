using UsersService.Models;

namespace UsersService.Repository.Products
{
	public interface IProductRepository
	{
		Task<IEnumerable<Product>> GetAll();
		Task<Product?> GetProductByIdAsync(int id);
	}
}
