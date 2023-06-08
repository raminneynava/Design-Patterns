using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.ClassAdapter
{
    public interface ITarget
    {
       void Operation();
    }

    public class AdapterClass : Adaptee, ITarget
    {
        public void Operation()
        {
          base.SpecificOperation();
        }
    }

}
