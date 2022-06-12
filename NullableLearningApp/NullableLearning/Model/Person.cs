using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableLearning.Model
{
     #nullable disable
    internal class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Address AddressDetails { get; set; }
    }
}
