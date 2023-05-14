using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using Shopping.API.Models;
using Shopping.Client.Data;

namespace Shopping.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController
    {
        private readonly ProductContext _context;
        private readonly ILogger<ProductController> _logger;

        public ProductController(ILogger<ProductController> logger, ProductContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public async Task<IEnumerable<Product>> Get()
        {
            return await _context.Products.Find(p => true).ToListAsync();
        }
    }
}
