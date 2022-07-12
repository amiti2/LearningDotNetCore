using System;
using System.Collections.Generic;
namespace LanguageFeatures.Models
{
    public static class MyExtensionMethods
    {
        public static decimal TotalPrices(this ShoppingCart p)
        {
            decimal total = 0;
            foreach (Product product in p.Products)
            {
                total += product?.Price ?? 0;
            }

            return total;
        }

        public static decimal TotalPrices(this IEnumerable<Product> products)
        {

            decimal total = 0;
           foreach (Product product in products)
            {
                total += product?.Price ?? 0;
            }

            return total;
        }

        public static IEnumerable<Product> Filter ( this IEnumerable<Product> products, Func<Product, bool> selector )
        {
            foreach (Product product in products)
            {
                if (selector(product))
                {
                    yield return product;
                }
            }
        }

        

        public static IEnumerable<Product> FilterPrice(this IEnumerable<Product> p, decimal minimum )
        {
            foreach(Product product in p)
            {
                if(product.Price > minimum)
                {
                    yield return product;
                }
            }
        }

        public static IEnumerable<Product> FilterByName(this IEnumerable<Product> products, string name)
        {
            foreach(Product product in products)
            {
                if(product.Name.StartsWith(name))
                {
                    yield return product;
                }
            }
        }

        public static string ToString1(this Product p)
        {
            return ($"{p.Name}- { p.Price}");
        }

    }
}