using System;

namespace NullHandling
{
    class Program
    {
        #nullable enable
        class Address
        {
            public string? Building;            
            public string Street = string.Empty;
            public string City = string.Empty;
            public string Region = string.Empty;
        }

        static void Main(string[] args)
        {
            //int? f = 34;
            Console.WriteLine("Hello World!");
            
            var address = new Address();
            address.Building = null;
            address.Street = null;
            address.City = "London";
            address.Region = null;
            if (address == null)
            {
                Console.WriteLine("work is done");
            }
        }
    }
}
