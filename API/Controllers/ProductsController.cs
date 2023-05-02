 
using API.Core.DbModels;
using API.Core.Interfaces;
using API.Infrastructure.DataContext;
using API.Infrastructure.Implements;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IGenericRepository<Product> _productRepository;

        public ProductsController(IGenericRepository<Product> productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts()
        {
            var data = await _productRepository.ListAllAsync();
            return Ok(data);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id)
        {
            var data = _productRepository.GetByIdAsync(id);
            return Ok(data);
        }
    }
}
