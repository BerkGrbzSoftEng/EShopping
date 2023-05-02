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
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity, new()

    {
        private readonly EShopContext _context;

        public GenericRepository(EShopContext context)
        {
            _context = context;
        }

        public  async  Task<T> GetByIdAsync(int id)
        { 
                return await _context.Set<T>().FirstOrDefaultAsync(x => x.Id == id);
           
        }

        public async Task<IReadOnlyList<T>> ListAllAsync()
        {
            
                return await _context.Set<T>().ToListAsync();
            
        }
    }
}
