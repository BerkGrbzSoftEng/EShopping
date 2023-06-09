﻿using API.Core.DbModels;
using Microsoft.EntityFrameworkCore;

namespace API.Infrastructure.DataContext
{
    public class EShopContext:DbContext
    {
        public EShopContext(DbContextOptions options):base(options)
        {
            
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<ProductBrand> ProductBrands { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
    }
}
