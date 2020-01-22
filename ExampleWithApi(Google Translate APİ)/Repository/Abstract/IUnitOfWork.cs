using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExampleWithApi_Google_Translate_APİ_.Repository.Abstract
{
    public interface IUnitOfWork : IDisposable
    {
        IProductRepository Products { get; }
         
        int SaveChanges();

    }
}
