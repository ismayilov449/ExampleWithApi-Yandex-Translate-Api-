using ExampleWithApi_Google_Translate_APİ_.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExampleWithApi_Google_Translate_APİ_.Models
{
    public class ProductModel
    {

        public int ProductId { get; set; }

        public Product Product { get; set; }

        public string DescriptionENG { get; set; }
    }
}
