using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using LanguageFeatures.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

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

        public async Task<ViewResult> Index()
        {

            List<string> output = new List<string>();
            await foreach (long? len in MyAsyncMethods.GetPageLengths(output, "apress.com", "microsoft.com", "amazon.com"))
            {
                output.Add($"Page length: {len}");
            }
            return View(output);
        }

        //public async Task<ViewResult> Index()
        //{
        //    List<string> output = new List<string>();
        //    await foreach (long? len in MyAsyncMethods.GetPageLengths(output,
        //    "apress.com", "microsoft.com", "amazon.com"))
        //    {
        //        output.Add($"Page length: {len}");
        //    }
        //    return View(output);
        //}

        public ViewResult Index1()
        {
            //var products = new[] {
            //                        new { Name = "Kayak", Price = 275M },
            //                        new { Name = "Lifejacket", Price = 48.95M },
            //                        new { Name = "Soccer ball", Price = 19.50M },
            //                        new { Name = "Corner flag", Price = 34.95M },
            //                        new { Name = "David", Price = 22.5M}
            // };

            //var g = new { Name = "Kayak", Price = 275M };
            //string dd = products.Select(p => p.GetType().Name) + "--------------" + g.GetType().Name;
            //return View(new String[] { dd });

            IProductSelection productSelection = new ShoppingCart (
                                                new Product { Name = "Kayak", Price = 275M },
                                                new Product { Name = "Lifejacket", Price = 48.95M },
                                                new Product { Name = "Soccer ball", Price = 19.50M },
                                                new Product { Name = "Corner flag", Price = 34.95M } );

            return View(productSelection.Names);
        }

    }
}
