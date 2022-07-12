using System.Collections;
using System.Linq;
using System.Collections.Generic;

namespace LanguageFeatures.Models
{
    public interface IProductSelection
    {
        IEnumerable<Product> Products { get; }
        IEnumerable<string> Names => Products.Select(p => p.Name);


    }


    public class ShoppingCart : IProductSelection
    {
        private List<Product> products = new List<Product>();

        public ShoppingCart(params Product[] prods)
        {
            products.AddRange(prods);
        }      

        public IEnumerable<Product> Products => products;
    }
}
