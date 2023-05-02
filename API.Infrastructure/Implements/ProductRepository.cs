using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using API.Core.DbModels;
using API.Core.Interfaces;
using API.Infrastructure.DataContext;
using Microsoft.EntityFrameworkCore;

namespace API.Infrastructure.Implements
{
    public class ProductRepository:IProductRepository
    {
        private readonly EShopContext _context;

        public ProductRepository(EShopContext context)
        {
            _context = context;
        }

        public async Task<Product> GetProductByIdAsync(int id)
        { 
            return await _context.Products.FindAsync(id);
        }

        public async Task<IReadOnlyList<Product>> GetProductsAsync()
        { 
            return await _context.Products.ToListAsync();
        }
    }
}
