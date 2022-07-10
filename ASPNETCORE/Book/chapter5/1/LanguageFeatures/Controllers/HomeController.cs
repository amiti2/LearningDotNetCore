using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using LanguageFeatures.Models;

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            Dictionary<string, Product> products = new Dictionary<string, Product>
            {
                ["kayak"] = new Product { Name = "Kayak", Price = 275M },
                ["Life Jacket"] = new Product { Name = "Life Jacket", Price = 49.75M }
            };


            object[] data = new object[6] { 22M, 29.5M, "Adidad", "Nike", 3 ,5 };

            decimal total = default;

            for(int i=0;i <data.Length; i++)
            {
                if (data[i] is decimal d)
                {
                    total += d;
                }
            }

            return View(new string[] { $"Total :  {total:c2} " });
        }
    }
}
