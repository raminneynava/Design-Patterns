using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public abstract class Builder
    {
        protected Product product;
        public Builder()
        {
            product = new Product();
        }

        public abstract void BuildCategory();
        public abstract void BuildPrice();

        public virtual Product GetResult()
        {
            return product;
        }
    }
}
