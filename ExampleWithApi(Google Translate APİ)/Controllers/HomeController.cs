using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExampleWithApi_Google_Translate_APİ_.Models;
using ExampleWithApi_Google_Translate_APİ_.Repository.Abstract;
using ExampleWithApi_Google_Translate_APİ_.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ExampleWithApi_Google_Translate_APİ_.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUnitOfWork uow;
        public HomeController(IUnitOfWork _uow)
        {
            uow = _uow;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ProductsList()
        {
            var currentProducts = uow.Products.GetAll();
            List<ProductModel> productModels = new List<ProductModel>();
            foreach (var currentProduct in currentProducts)
            {
                productModels.Add(new ProductModel()
                {
                   Product = currentProduct,
                   DescriptionENG = TranslatorAzToEng.AzToEng(currentProduct.Description)
                    
                });
            }


            return View(productModels);
        }
    }
}