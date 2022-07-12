using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using LanguageFeatures.Models;
using System;

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {

        static bool FilterByPrice(Product p)
        {
            return p.Price > 20;
        }

        static bool FilterByName(Product p)
        {
            return p.Name.StartsWith("S");
        }

        
        public ViewResult Index()
        {
            //Dictionary<string, Product> products = new Dictionary<string, Product>
            //{
            //    ["kayak"] = new Product { Name = "Kayak", Price = 275M },
            //    ["Life Jacket"] = new Product { Name = "Life Jacket", Price = 49.75M }
            //};


            //object[] data = new object[6] { 22M, 29.5M, "Adidad", "Nike", 3 ,5 };

            //decimal total = default;

            //for(int i=0;i <data.Length; i++)
            //{
            //    if (data[i] is decimal d)
            //    {
            //        total += d;
            //    }
            //}

            //ShoppingCart cart = new ShoppingCart { Products = Product.GetProducts() };
            //decimal cartTotal = cart.TotalPrices();
            //return View("Index", new string[] { $"Total: {cartTotal:C2}" });

            //ShoppingCart cart = new ShoppingCart { Products = Product.GetProducts() };

            //Product[] productArray = {  
            //        new Product {Name = "Kayak", Price = 275M},
            //        new Product {Name = "Lifejacket", Price = 48.95M}
            //        };

            //decimal cartTotal = cart.TotalPrices();
            //decimal arrayTotal = productArray.TotalPrices();

            //return View("Index", new string[] {
            //                        $"Cart Total: {cartTotal:C2}",
            //                        $"Array Total: {arrayTotal:C2}" });

            Func<Product, bool> NameFilter = delegate (Product p)
            {
                return p.Name.StartsWith("S");
            };

            Product[] productArray = {
                    new Product {Name = "Kayak", Price = 275M},
                    new Product {Name = "Lifejacket", Price = 48.95M},
                    new Product {Name = "Soccer ball", Price = 19.50M},
                    new Product {Name = "Corner flag", Price = 34.95M}
};
            //decimal arrayTotal = productArray.FilterPrice(20).TotalPrices();

            //decimal nameFilterTotal = productArray.FilterByName("C").TotalPrices();

            decimal arrayTotal = productArray.Filter(FilterByPrice).TotalPrices();
            //decimal nameFilterTotal = productArray.Filter(FilterByName).TotalPrices();

            decimal nameFilterTotal = productArray.Filter(NameFilter).TotalPrices();

            return View("Index", new string[] { $"Array Total: {arrayTotal:C2}" , $"Array Total: { nameFilterTotal:C2}" });
        }
    }
}
