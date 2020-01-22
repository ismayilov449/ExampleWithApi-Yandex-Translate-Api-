using ExampleWithApi_Google_Translate_APİ_.Entities;
using ExampleWithApi_Google_Translate_APİ_.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExampleWithApi_Google_Translate_APİ_.Repository.Concrete.EntityFramework
{
    public class EfProductRepository : EfGenericRepository<Product>, IProductRepository
    {

        public EfProductRepository(ProductsDbContext context) : base(context)
        {

        }

        public ProductsDbContext ProjectContext { get { return context as ProductsDbContext; } }

    }
}
