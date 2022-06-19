using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Bridge.Bridge.Implementors;

namespace Bridge.Bridge.Abstractions
{
    public abstract class Abstraction
    {
        private Implementor implementor;

        protected Abstraction()
        {
            this.implementor = new concreateImplementor();
        }

        public virtual void Function()
        {
            implementor.Implemention();
        }
    }

    public class RefindeAbstraction : Abstraction
    {

    }


}
