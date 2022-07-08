namespace LanguageFeatures.Models
{
    public class Product
    {
        public string Name { get; set; }
        public decimal? Price { get; set; }

        public Product Related { get; set; }

        public static Product[] GetProducts()
        {
            Product kayak = new Product { Name = "Kayak", Price = 275M };
            Product LifeJacket = new Product { Name="Life Jacket", Price = 48.95M};
            kayak.Related = LifeJacket;

            return new Product[] { kayak, LifeJacket, null };

        }
    }
}
