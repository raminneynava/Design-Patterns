using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Sort
{
    public  class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Creadit { get; set; }


        public void Display()
        {
            Console.WriteLine($"Id:{Id} Name:{Name},LastName:{LastName},Creadit:{Creadit}");
        }
    }
}
