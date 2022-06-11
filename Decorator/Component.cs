using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class Component
    {
        public abstract void Operation();
    }

    public class concreatComponent : Component
    {
        public override void Operation()
        {
            Console.WriteLine("concreatComponent.Operation");
        }
    }
}
