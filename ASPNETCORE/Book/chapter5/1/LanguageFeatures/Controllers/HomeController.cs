using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using LanguageFeatures.Models;

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            Dictionary<string, Product> products = new Dictionary<string, Product> {
                ["kayak"] = new Product { Name = "Kayak" , Price = 275M },
                ["Life Jacket"] = new Product {  Name="Life Jacket", Price = 49.75M}
            };


           

            return View(products.Keys);
        }
    }
}
