using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class ConcreateBuilder1 : Builder
    {
        public override void BuildCategory()
        {
            product.Category = "Cat1";
        }

        public override void BuildPrice()
        {
            product.Price = "100000";
        }

        public override Product GetResult()
        {
            product.Name = "Product 1";
            Console.WriteLine($"{product.Name} is Created");
            return base.GetResult();
        }
    }
}
