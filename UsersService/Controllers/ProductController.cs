using Microsoft.AspNetCore.Mvc;
using UsersService.Models;
using UsersService.Service.Products;

namespace UsersService.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class ProductController : ControllerBase
	{
		private readonly IProductService _productService;
		public ProductController(IProductService productService)
		{
			_productService = productService;
		}
		[HttpGet]
		public async Task<IEnumerable<Product>> GetAll()
		{
			var products = await _productService.GetAll();
			return products;
		}

		[HttpGet("{id}")]
		public async Task<Product?> GetProductByIdAsync(int id)
		{
			var product = await _productService.GetProductByIdAsync(id);
			return product;
		}

	}
}


