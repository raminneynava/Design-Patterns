using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Directore
    {
        private Builder _builder;
        public void SetBuilder(Builder builder)
        {
            _builder = builder;
        }

        public void Construct()
        {
            _builder.BuildCategory();
            _builder.BuildPrice();
        }
    }
}
