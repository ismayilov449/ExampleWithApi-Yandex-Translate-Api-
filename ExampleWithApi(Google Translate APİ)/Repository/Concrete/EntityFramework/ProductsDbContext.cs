using ExampleWithApi_Google_Translate_APİ_.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExampleWithApi_Google_Translate_APİ_.Repository.Concrete.EntityFramework
{
    public class ProductsDbContext : DbContext
    {

        public ProductsDbContext(DbContextOptions<ProductsDbContext> options)
          : base(options)
        {

        }


        public DbSet<Product> Products { get; set; }


    }
}
