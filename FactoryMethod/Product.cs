using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public abstract class Product
    {
        public abstract void Excute();
    }
    public class conCreateProd1 : Product
    {
        public override void Excute()
        {
            Console.WriteLine("conCreateProd1");
        }
    }

    public class conCreateProd2 : Product
    {
        public override void Excute()
        {
            Console.WriteLine("conCreateProd2");
        }
    }
    public abstract class Creator
    {
        public abstract Product factory(int i);
    }

    public class ConcreateCreator : Creator
    {
        public override Product factory(int i)
        {
            if (i < 0) return new conCreateProd1();
            else return new conCreateProd2();
        }
    }
}
