using UsersService.Models;
using UsersService.Repository.Products;
using UsersService.Service.Products;

namespace UsersService.Service.Products
{
	public class ProductService : IProductService
	{
		private readonly IProductRepository _productRepository;

		public ProductService(IProductRepository productRepository)
		{
			_productRepository = productRepository;
		}
		public async Task<IEnumerable<Product>> GetAll()
		{
			var product = await _productRepository.GetAll();
			return product;
		}
		public async Task<Product?> GetProductByIdAsync(int id)
		{
			var product = await _productRepository.GetProductByIdAsync(id);
			return product;
		}
	}
}
