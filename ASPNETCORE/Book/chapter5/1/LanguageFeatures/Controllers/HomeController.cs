using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using LanguageFeatures.Models;

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            List<string> results = new List<string>();
            foreach(var product in Product.GetProducts())
            {
                string name = product?.Name ?? "No Name";
                decimal price = product?.Price ?? 0.25M;
                string relatedName = product?.Related?.Name ?? "No Related Product Name";
                results.Add(string.Format("Name: {0}, Price:{1}, Related:{2}", name, price, relatedName));
            }
            return View(results);
            //return View(new string[] { "C#", "Language", "Features" });
        }
    }
}
