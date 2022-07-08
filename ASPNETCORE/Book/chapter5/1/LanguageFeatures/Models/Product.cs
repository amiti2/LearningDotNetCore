namespace LanguageFeatures.Models
{
    public class Product
    {
        public string Name { get; set; }
        public decimal? Price { get; set; }

        //auto initializer property
        public Product Related { get; set; }

        //read-only property
        public bool Instock { get; }= true;

        //property with auto initializer.
        public string Category { get; set; } = "water sports cat name";

        //property initializer with Traditional Getter and Setter

        //define field name
        private decimal cost;

        //define Property
        public decimal Cost
        {
            get
            {
                return cost;
            }
            set
            {
                cost = value;
            }
        }
        
        //read only property is set in constructors
        public Product(bool stock =true)
        {
            Instock = stock;
           
        }

       

        public static Product[] GetProducts()
        {
            Product kayak = new Product { Name = "Kayak", Price = 275M, Category = "test sport"};
            Product LifeJacket = new Product(false) { Name="Life Jacket", Price = 48.95M};
            kayak.Related = LifeJacket;
            

            return new Product[] { kayak, LifeJacket, null };

        }
    }
}
