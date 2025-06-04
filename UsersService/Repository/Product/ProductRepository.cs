using Microsoft.EntityFrameworkCore;
using UsersService.DBContext;
using UsersService.Models;

namespace UsersService.Repository.Products
{
	public class ProductRepository : IProductRepository
	{
		private readonly UsersDbContext _context;

		public ProductRepository(UsersDbContext context)
		{
			_context = context;
		}

		public async Task<IEnumerable<Product>> GetAll()
		{
			var product = await _context.Products.ToListAsync();
			return product;
		}
		public async Task<Product?> GetProductByIdAsync(int id)
		{
			var product = await _context.Products.FindAsync(id);
			return product;
		}
	}
}
