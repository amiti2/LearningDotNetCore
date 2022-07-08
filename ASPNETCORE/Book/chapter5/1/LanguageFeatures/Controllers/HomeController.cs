using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using LanguageFeatures.Models;

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
          
            List<string> results = new List<string>();
            foreach(var product in Product.GetProducts())
            {
                string name = product?.Name ?? "No Name";
                decimal price = product?.Price ?? 0.25M;
                string relatedName = product?.Related?.Name ?? "No Related Product Name";
                string category = product?.Category;
                bool inStock = product?.Instock ?? false;
               
                results.Add(string.Format("Name: {0, 80}, Price:{1 , 5  }, Related:{2}, Category : {3}, In stock = {4}", name, price, relatedName, category, inStock));
            }

            return results[0];
            //return View(results);
            //return View(new string[] { "C#", "Language", "Features" });
        }
    }
}
