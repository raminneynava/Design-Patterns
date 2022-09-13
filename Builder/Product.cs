using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Product
    {
        public string Category { get; set; }
        public string Price { get; set; }
        public string Name { get; set; }

        public void Display()
        {
            Console.WriteLine($"Product Name:{this.Name}");
            Console.WriteLine($"Product Category:{this.Category}");
            Console.WriteLine($"Product Price:{this.Price}");
        }
    }
}
