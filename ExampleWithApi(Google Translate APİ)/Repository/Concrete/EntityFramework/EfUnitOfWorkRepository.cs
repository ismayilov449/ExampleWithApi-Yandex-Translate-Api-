using ExampleWithApi_Google_Translate_APİ_.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExampleWithApi_Google_Translate_APİ_.Repository.Concrete.EntityFramework
{
    public class EfUnitOfWork : IUnitOfWork
    {

        private readonly ProductsDbContext productsDbContext;

        public EfUnitOfWork(ProductsDbContext _productsDbContext)
        {
            productsDbContext = _productsDbContext ?? throw new ArgumentNullException("dbcontext can not be null");
        }


        private IProductRepository _products;

     

        public IProductRepository Products
        {
            get
            {
                return _products ?? (_products = new EfProductRepository(productsDbContext));
            }
        }
         
        public int SaveChanges()
        {
            try
            {
                return productsDbContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }

        }

        public void Dispose()
        {
            productsDbContext.Dispose();

        }
    }
}
